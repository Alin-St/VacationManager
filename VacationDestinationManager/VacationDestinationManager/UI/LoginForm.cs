using VacationDestinationManager.Utilities;

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
            // Check credentials.
            var userService = ApplicationManager.GetUserService();

            var user = userService.FindByKey(usernameTB.Text);
            if (user is null)
            {
                MessageBox.Show("User " + usernameTB.Text + " not found!", "Error:");
                return;
            }

            var hashedPassword = Utility.HashStringSha256(passwordTB.Text);
            if (!user.PasswordHash.SequenceEqual(hashedPassword))
            {
                MessageBox.Show("Incorrect password!", "Error;");
                return;
            }

            // Open corresponding form.
            Form newForm;

            if (usernameTB.Text == "admin")
                newForm = new AdminForm();
            else
                newForm = new ClientForm() { Username = usernameTB.Text };

            newForm.Show();
            newForm.FormClosed += (_, _) => this.Close();
            this.Hide();
        }
    }
}
