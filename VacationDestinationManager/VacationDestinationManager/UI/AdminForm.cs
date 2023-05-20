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
            RefreshSelection();
            RefreshStatus();
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
        }

        void RefreshSelection()
        {
            int selectedIndex = (destinationsLV.SelectedItems.Count == 0) ? -1 : destinationsLV.SelectedItems[0].Index;

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

            RefreshStatus();
        }

        void RefreshStatus()
        {
            destinationsLV.Enabled = !_editing;
            bool hasSelection = (destinationsLV.SelectedItems.Count > 0);

            geolocationTB.ReadOnly = !_editing;
            titleTB.ReadOnly = !_editing;
            descriptionTB.ReadOnly = !_editing;
            stayDateDTP.Enabled = _editing;

            addItemB.Enabled = !_editing;
            editB.Enabled = !_editing && hasSelection;
            okB.Enabled = _editing;
            cancelB.Enabled = _editing;
            removeB.Enabled = !_editing && hasSelection;
        }

        private void AddItemB_Click(object sender, EventArgs e)
        {
            destinationsLV.SelectedItems.Clear();
            _editing = true;
        }

        private void EditB_Click(object sender, EventArgs e)
        {

        }

        private void OkB_Click(object sender, EventArgs e)
        {

        }

        private void CancelB_Click(object sender, EventArgs e)
        {

        }

        private void RemoveB_Click(object sender, EventArgs e)
        {

        }
    }
}
