using VacationDestinationManager.Domain;
using VacationDestinationManager.ServiceLayer;
using VacationDestinationManager.Utilities;

namespace VacationDestinationManager.UI
{
    public partial class AdminForm : Form
    {
        DestinationService? _service;
        List<Destination> _destinations = new();
        bool _editing = false;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            _service = ApplicationManager.GetDestinationService();

            RefreshDestinations();
            RefreshStatus();
        }

        private void DestinationsLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshStatus(updateDisplayedEntity: true);
        }

        void RefreshDestinations()
        {
            _destinations = _service!.GetAll().ToList();
            destinationsLV.Items.Clear();

            foreach (var destination in _destinations)
            {
                destinationsLV.Items.Add(new ListViewItem(new string[]
                {
                    destination.Geolocation,
                    destination.Title,
                    destination.Description,
                    destination.StayDate.ToString(),
                }));
            }

            RefreshStatus();
        }

        void RefreshStatus(bool updateDisplayedEntity = false)
        {
            int selectedIndex = (destinationsLV.SelectedItems.Count == 0) ? -1 : destinationsLV.SelectedItems[0].Index;

            // Enable / Disable controls.
            destinationsLV.Enabled = !_editing;

            geolocationTB.ReadOnly = !_editing;
            titleTB.ReadOnly = !_editing;
            descriptionTB.ReadOnly = !_editing;
            stayDateDTP.Enabled = _editing;

            addItemB.Enabled = !_editing;
            editB.Enabled = !_editing && selectedIndex >= 0;
            okB.Enabled = _editing;
            cancelB.Enabled = _editing;
            removeB.Enabled = !_editing && selectedIndex >= 0;

            clearB.Enabled = _editing;
            selectB.Enabled = _editing;

            if (!_editing)
                updateDisplayedEntity = true;

            // Update displayed entity.
            if (updateDisplayedEntity)
            {
                if (selectedIndex < 0)
                {
                    geolocationTB.Text = "";
                    titleTB.Text = "";
                    descriptionTB.Text = "";
                    stayDateDTP.Value = DateTime.Now;
                    imagePB.Image = null;
                }
                else
                {
                    var destination = _destinations[selectedIndex];

                    geolocationTB.Text = destination.Geolocation;
                    titleTB.Text = destination.Title;
                    descriptionTB.Text = destination.Description;
                    stayDateDTP.Text = destination.StayDate.ToString();

                    if (destination.Image is null || destination.Image.Length == 0)
                        imagePB.Image = null;
                    else
                    {
                        using var memoryStream = new MemoryStream(destination.Image);
                        imagePB.Image = Image.FromStream(memoryStream);
                    }
                }
            }
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            imagePB.Image = null;
        }

        private void SelectB_Click(object sender, EventArgs e)
        {
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

        private void AddItemB_Click(object sender, EventArgs e)
        {
            _editing = true;
            destinationsLV.SelectedIndices.Clear();
            RefreshStatus(updateDisplayedEntity: true);
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            bool hasSelection = (destinationsLV.SelectedItems.Count > 0);
            if (hasSelection)
            {
                _editing = true;
                RefreshStatus(updateDisplayedEntity: true);
            }
        }

        private void OkB_Click(object sender, EventArgs e)
        {
            var selectedItem = destinationsLV.SelectedIndices.Count == 0 ? null : _destinations[destinationsLV.SelectedIndices[0]];

            if (selectedItem is null)
            {
                _service!.AddDestination(
                    "admin",
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
            RefreshDestinations();
            RefreshStatus(updateDisplayedEntity: true);
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            _editing = false;
            RefreshStatus(updateDisplayedEntity: true);
        }

        private void RemoveB_Click(object sender, EventArgs e)
        {
            var selectedItem = destinationsLV.SelectedIndices.Count > 0 ? _destinations[destinationsLV.SelectedIndices[0]] : null;
            if (selectedItem is not null)
            {
                if (MessageBox.Show("Are you sure you want to remove this item?", "Vacation Manager:") != DialogResult.OK)
                    return;

                _service!.Remove(selectedItem.Id);
                RefreshDestinations();
                RefreshStatus(updateDisplayedEntity: true);
            }
        }
    }
}
