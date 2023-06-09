using System.Diagnostics;
using VacationDestinationManager.Domain;
using VacationDestinationManager.ServiceLayer;
using VacationDestinationManager.Utilities;

namespace VacationDestinationManager.UI
{
    public partial class ClientForm : Form
    {
        public string Username { get; set; } = "";

        DestinationService? _service;
        List<Destination> _publicDestinations = new();
        List<Destination> _privateDestinations = new();
        bool _editing = false;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            _service = ApplicationManager.GetDestinationService();

            LoadPublicDestinations();
            RefreshPrivateDestinations();
            RefreshStatus();
        }

        void LoadPublicDestinations()
        {
            _publicDestinations = _service!.GetAll().Where(d => d.Username == "admin").ToList();
            publicDestinationsLV.Items.Clear();

            foreach (var destination in _publicDestinations)
            {
                publicDestinationsLV.Items.Add(new ListViewItem(new string[]
                {
                    destination.Geolocation,
                    destination.Title,
                    destination.Description,
                    destination.StayDate.ToString(),
                }));
            }
        }

        private void RefreshPrivateDestinations()
        {
            _privateDestinations = _service!.GetAll().Where(d => d.Username == this.Username).ToList();
            privateDestinationsLV.Items.Clear();

            foreach (var destination in _privateDestinations)
            {
                privateDestinationsLV.Items.Add(new ListViewItem(new string[]
                {
                    destination.Geolocation,
                    destination.Title,
                    destination.Description,
                    destination.StayDate.ToString(),
                }));
            }

            RefreshStatus();
        }

        private void RefreshStatus(bool updateDisplayedPrivateDestination = false)
        {
            // Get selection information.
            // Selection mode: 0 - no item selected; 1 - item selected from public list; 2 - item selected from private list
            int selectionMode = 0;
            int selectedIndex = -1;
            if (publicDestinationsLV.SelectedIndices.Count > 0)
            {
                selectionMode = 1;
                selectedIndex = publicDestinationsLV.SelectedIndices[0];

                Debug.Assert(privateDestinationsLV.SelectedIndices.Count == 0);
            }
            else if (privateDestinationsLV.SelectedIndices.Count > 0)
            {
                selectionMode = 2;
                selectedIndex = privateDestinationsLV.SelectedIndices[0];
            }

            Debug.Assert(selectionMode >= 0 && selectionMode <= 2);
            Debug.Assert(!(selectionMode == 1 && _editing));

            // Enable / Disable controls.
            publicDestinationsLV.Enabled = !_editing;
            addToPrivateListB.Enabled = (selectionMode == 1);

            privateDestinationsLV.Enabled = !_editing;
            geolocationTB.ReadOnly = !_editing;
            titleTB.ReadOnly = !_editing;
            descriptionTB.ReadOnly = !_editing;
            stayDateDTP.Enabled = _editing;

            addB.Enabled = !_editing;
            editB.Enabled = !_editing && selectionMode == 2 && selectedIndex >= 0;
            okB.Enabled = _editing;
            cancelB.Enabled = _editing;
            removeB.Enabled = !_editing && selectionMode == 2 && selectedIndex >= 0;

            clearB.Enabled = _editing;
            selectB.Enabled = _editing;

            // Update displayed public destination.
            if (selectionMode != 1)
            {
                pd_geolocationTB.Text = "";
                pd_titleTB.Text = "";
                pd_descriptionTB.Text = "";
                pd_stayDateTB.Text = "";
            }
            else
            {
                var publicDestination = _publicDestinations[selectedIndex];

                pd_geolocationTB.Text = publicDestination.Geolocation;
                pd_titleTB.Text = publicDestination.Title;
                pd_descriptionTB.Text = publicDestination.Description;
                pd_stayDateTB.Text = publicDestination.StayDate.ToString();

                if (publicDestination.Image is null || publicDestination.Image.Length == 0)
                    imagePB.Image = null;
                else
                {
                    using var memoryStream = new MemoryStream(publicDestination.Image);
                    imagePB.Image = Image.FromStream(memoryStream);
                }
            }

            // Update displayed private destination.
            if (!_editing)
                updateDisplayedPrivateDestination = true;

            if (updateDisplayedPrivateDestination)
            {
                if (selectionMode != 2)
                {
                    geolocationTB.Text = "";
                    titleTB.Text = "";
                    descriptionTB.Text = "";
                    stayDateDTP.Value = DateTime.Now;
                }
                else
                {
                    var privateDestination = _privateDestinations[selectedIndex];

                    geolocationTB.Text = privateDestination.Geolocation;
                    titleTB.Text = privateDestination.Title;
                    descriptionTB.Text = privateDestination.Description;
                    stayDateDTP.Value = privateDestination.StayDate;

                    if (privateDestination.Image is null || privateDestination.Image.Length == 0)
                        imagePB.Image = null;
                    else
                    {
                        using var memoryStream = new MemoryStream(privateDestination.Image);
                        imagePB.Image = Image.FromStream(memoryStream);
                    }
                }
            }

            // Update displayed image if necessary.
            if (selectionMode == 0)
                imagePB.Image = null;
        }

        private void AddFromPublicListB_Click(object sender, EventArgs e)
        {
            // Add the selected public destination to the list of private destinations for the current user.
            var selectedItem = publicDestinationsLV.SelectedIndices.Count == 0 ? null
                : _publicDestinations[publicDestinationsLV.SelectedIndices[0]];

            Debug.Assert(selectedItem is not null);

            _service!.AddDestination(
                Username,
                selectedItem.Geolocation,
                selectedItem.Title,
                selectedItem.Image,
                selectedItem.Description,
                selectedItem.StayDate);

            // Refresh items and select the added destination.
            RefreshPrivateDestinations();
            privateDestinationsLV.SelectedIndices.Add(_privateDestinations.FindIndex(d => d.Title == selectedItem.Title));
            RefreshStatus(updateDisplayedPrivateDestination: true);
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            _editing = true;
            publicDestinationsLV.SelectedItems.Clear();
            privateDestinationsLV.SelectedItems.Clear();
            RefreshStatus(updateDisplayedPrivateDestination: true);
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            Debug.Assert(publicDestinationsLV.SelectedItems.Count == 0 &&
                         privateDestinationsLV.SelectedItems.Count > 0);

            _editing = true;
            RefreshStatus(updateDisplayedPrivateDestination: true);
        }

        private void OkB_Click(object sender, EventArgs e)
        {
            var selectedItem = privateDestinationsLV.SelectedIndices.Count == 0 ? null
                : _privateDestinations[privateDestinationsLV.SelectedIndices[0]];

            if (selectedItem is null)
            {
                _service!.AddDestination(
                    Username,
                    geolocationTB.Text,
                    titleTB.Text,
                    Utility.ImageToBytes(imagePB.Image),
                    descriptionTB.Text,
                    stayDateDTP.Value);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to edit this item?", "Vacation Manager:") != DialogResult.OK)
                    return;

                _service!.UpdateDestination(
                    selectedItem.Id,
                    geolocationTB.Text,
                    titleTB.Text,
                    Utility.ImageToBytes(imagePB.Image),
                    descriptionTB.Text,
                    stayDateDTP.Value);
            }

            _editing = false;
            RefreshPrivateDestinations();
            RefreshStatus(updateDisplayedPrivateDestination: true);
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            _editing = false;
            RefreshStatus(updateDisplayedPrivateDestination: true);
        }

        private void RemoveB_Click(object sender, EventArgs e)
        {
            var selectedItem = privateDestinationsLV.SelectedIndices.Count == 0 ? null
                : _privateDestinations[privateDestinationsLV.SelectedIndices[0]];

            Debug.Assert(selectedItem is not null);

            if (MessageBox.Show("Are you sure you want to remove this item?", "Vacation Manager:") != DialogResult.OK)
                return;

            _service!.Remove(selectedItem.Id);
            RefreshPrivateDestinations();
            RefreshStatus(updateDisplayedPrivateDestination: true);
        }

        private void ClearImageB_Click(object sender, EventArgs e)
        {
            Debug.Assert(_editing);
            imagePB.Image = null;
        }

        private void SelectImageB_Click(object sender, EventArgs e)
        {
            Debug.Assert(_editing);

            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                Image selectedImage = Image.FromFile(selectedImagePath);
                imagePB.Image = selectedImage;
            }
        }

        private void DestinationsLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can't select an item from the public list and one from the private list simultaneously.
            if (publicDestinationsLV.SelectedItems.Count > 0 && privateDestinationsLV.SelectedItems.Count > 0)
            {
                if (sender == publicDestinationsLV)
                    privateDestinationsLV.SelectedItems.Clear();
                else
                    publicDestinationsLV.SelectedItems.Clear();
            }

            // Refresh status
            RefreshStatus(updateDisplayedPrivateDestination: true);
        }
    }
}
