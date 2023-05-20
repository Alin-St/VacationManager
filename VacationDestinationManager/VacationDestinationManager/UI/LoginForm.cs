namespace VacationDestinationManager.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                ApplicationManager.InitializeAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while loading the app:");

                // Close the app and bypass form closing events.
                Environment.Exit(1);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ApplicationManager.SaveAndCloseAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while closing the app:");
            }
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            // Read user login data.
            string loginData = File.ReadAllText(Path.Combine(Application.LocalUserAppDataPath, "loginData.csv"));
            var lines = loginData.Split(new[] { "\n", "\r\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            var users = lines.Select(line =>
            {
                var values = line.Split(',');
                if (values.Length != 2)
                    throw new InvalidOperationException("Invalid login data.");
                return (username: values[0], password: values[1]);
            });

            if (!users.Any(u => u.username == "admin"))
                throw new InvalidOperationException("No admin found.");

            // Check credentials.
            if (!users.Any(u => u.username == usernameTB.Text))
            {
                MessageBox.Show("User " + usernameTB.Text + " not found!", "Error:");
                return;
            }

            var (username, password) = users.First(u => u.username == usernameTB.Text);
            if (password != passwordTB.Text)
            {
                MessageBox.Show("Incorrect password!", "Error;");
                return;
            }

            // Open corresponding form.
            Form newForm;

            if (username == "admin")
                newForm = new AdminForm();
            else
                newForm = new ClientForm() { Username = username };

            newForm.Show();
            newForm.FormClosed += (_, _) => this.Close();
            this.Hide();
        }
    }
}
