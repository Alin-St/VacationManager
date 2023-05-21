using VacationDestinationManager.Domain;
using VacationDestinationManager.ServiceLayer;

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

            if (!_editing)
                updateDisplayedEntity = false;

            // Update displayed entity.
            if (updateDisplayedEntity)
            {
                if (selectedIndex < 0)
                {
                    geolocationTB.Text = "";
                    titleTB.Text = "";
                    descriptionTB.Text = "";
                    stayDateDTP.Text = "";
                }
                else
                {
                    geolocationTB.Text = _destinations[selectedIndex].Geolocation;
                    titleTB.Text = _destinations[selectedIndex].Title;
                    descriptionTB.Text = _destinations[selectedIndex].Description;
                    stayDateDTP.Text = _destinations[selectedIndex].StayDate.ToString();
                }
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
                    Array.Empty<byte>(),
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
                    Array.Empty<byte>(),
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
