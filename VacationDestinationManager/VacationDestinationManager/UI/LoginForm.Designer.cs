namespace VacationDestinationManager.UI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTLP = new TableLayoutPanel();
            mainP = new Panel();
            loginFormTLP = new TableLayoutPanel();
            usernameL = new Label();
            passwordL = new Label();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            loginB = new Button();
            borderP = new Panel();
            mainTLP.SuspendLayout();
            mainP.SuspendLayout();
            loginFormTLP.SuspendLayout();
            borderP.SuspendLayout();
            SuspendLayout();
            // 
            // mainTLP
            // 
            mainTLP.ColumnCount = 3;
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 294F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTLP.Controls.Add(mainP, 1, 1);
            mainTLP.Dock = DockStyle.Fill;
            mainTLP.Location = new Point(0, 0);
            mainTLP.Name = "mainTLP";
            mainTLP.RowCount = 3;
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTLP.RowStyles.Add(new RowStyle());
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTLP.Size = new Size(445, 230);
            mainTLP.TabIndex = 0;
            // 
            // mainP
            // 
            mainP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mainP.AutoSize = true;
            mainP.BorderStyle = BorderStyle.FixedSingle;
            mainP.Controls.Add(loginFormTLP);
            mainP.Location = new Point(78, 64);
            mainP.Name = "mainP";
            mainP.Padding = new Padding(6);
            mainP.Size = new Size(288, 101);
            mainP.TabIndex = 1;
            // 
            // loginFormTLP
            // 
            loginFormTLP.AutoSize = true;
            loginFormTLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginFormTLP.ColumnCount = 2;
            loginFormTLP.ColumnStyles.Add(new ColumnStyle());
            loginFormTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loginFormTLP.Controls.Add(usernameL, 0, 0);
            loginFormTLP.Controls.Add(passwordL, 0, 1);
            loginFormTLP.Controls.Add(usernameTB, 1, 0);
            loginFormTLP.Controls.Add(passwordTB, 1, 1);
            loginFormTLP.Controls.Add(loginB, 0, 2);
            loginFormTLP.Dock = DockStyle.Fill;
            loginFormTLP.Location = new Point(6, 6);
            loginFormTLP.Name = "loginFormTLP";
            loginFormTLP.RowCount = 3;
            loginFormTLP.RowStyles.Add(new RowStyle());
            loginFormTLP.RowStyles.Add(new RowStyle());
            loginFormTLP.RowStyles.Add(new RowStyle());
            loginFormTLP.Size = new Size(274, 87);
            loginFormTLP.TabIndex = 0;
            // 
            // usernameL
            // 
            usernameL.Anchor = AnchorStyles.Left;
            usernameL.AutoSize = true;
            usernameL.Location = new Point(3, 7);
            usernameL.Name = "usernameL";
            usernameL.Size = new Size(63, 15);
            usernameL.TabIndex = 0;
            usernameL.Text = "Username:";
            // 
            // passwordL
            // 
            passwordL.Anchor = AnchorStyles.Left;
            passwordL.AutoSize = true;
            passwordL.Location = new Point(3, 36);
            passwordL.Name = "passwordL";
            passwordL.Size = new Size(60, 15);
            passwordL.TabIndex = 1;
            passwordL.Text = "Password:";
            // 
            // usernameTB
            // 
            usernameTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usernameTB.Location = new Point(72, 3);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(199, 23);
            usernameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            passwordTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTB.Location = new Point(72, 32);
            passwordTB.Name = "passwordTB";
            passwordTB.PasswordChar = '*';
            passwordTB.Size = new Size(199, 23);
            passwordTB.TabIndex = 3;
            // 
            // loginB
            // 
            loginB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginFormTLP.SetColumnSpan(loginB, 2);
            loginB.Location = new Point(3, 61);
            loginB.Name = "loginB";
            loginB.Size = new Size(268, 23);
            loginB.TabIndex = 4;
            loginB.Text = "Login";
            loginB.UseVisualStyleBackColor = true;
            loginB.Click += LoginB_Click;
            // 
            // borderP
            // 
            borderP.BorderStyle = BorderStyle.FixedSingle;
            borderP.Controls.Add(mainTLP);
            borderP.Dock = DockStyle.Fill;
            borderP.Location = new Point(12, 12);
            borderP.Name = "borderP";
            borderP.Size = new Size(447, 232);
            borderP.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 256);
            Controls.Add(borderP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            Padding = new Padding(12);
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            mainTLP.ResumeLayout(false);
            mainTLP.PerformLayout();
            mainP.ResumeLayout(false);
            mainP.PerformLayout();
            loginFormTLP.ResumeLayout(false);
            loginFormTLP.PerformLayout();
            borderP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTLP;
        private TableLayoutPanel loginFormTLP;
        private Label usernameL;
        private Label passwordL;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Button loginB;
        private Panel mainP;
        private Panel borderP;
    }
}