namespace VacationDestinationManager.UI
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            destinationsLV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            geolocationTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            titleTB = new TextBox();
            descriptionTB = new TextBox();
            stayDateDTP = new DateTimePicker();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            addItemB = new Button();
            editB = new Button();
            okB = new Button();
            cancelB = new Button();
            removeB = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // destinationsLV
            // 
            destinationsLV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            destinationsLV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            destinationsLV.FullRowSelect = true;
            destinationsLV.GridLines = true;
            destinationsLV.Location = new Point(3, 32);
            destinationsLV.MultiSelect = false;
            destinationsLV.Name = "destinationsLV";
            destinationsLV.Size = new Size(361, 188);
            destinationsLV.TabIndex = 0;
            destinationsLV.UseCompatibleStateImageBehavior = false;
            destinationsLV.View = View.Details;
            destinationsLV.SelectedIndexChanged += DestinationsLV_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Geolocation";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Title";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Stay Date";
            columnHeader4.Width = 80;
            // 
            // geolocationTB
            // 
            geolocationTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            geolocationTB.Location = new Point(83, 3);
            geolocationTB.Name = "geolocationTB";
            geolocationTB.Size = new Size(275, 23);
            geolocationTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Geolocation:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 65);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 94);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 5;
            label4.Text = "Stay Date:";
            // 
            // titleTB
            // 
            titleTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            titleTB.Location = new Point(83, 32);
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(275, 23);
            titleTB.TabIndex = 6;
            // 
            // descriptionTB
            // 
            descriptionTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descriptionTB.Location = new Point(83, 61);
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(275, 23);
            descriptionTB.TabIndex = 7;
            // 
            // stayDateDTP
            // 
            stayDateDTP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            stayDateDTP.Location = new Point(83, 90);
            stayDateDTP.Name = "stayDateDTP";
            stayDateDTP.Size = new Size(275, 23);
            stayDateDTP.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(392, 15);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Image:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(392, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 348);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // addItemB
            // 
            addItemB.Location = new Point(3, 3);
            addItemB.Name = "addItemB";
            addItemB.Size = new Size(66, 23);
            addItemB.TabIndex = 11;
            addItemB.Text = "Add Item";
            addItemB.UseVisualStyleBackColor = true;
            addItemB.Click += AddItemB_Click;
            // 
            // editB
            // 
            editB.Location = new Point(75, 3);
            editB.Name = "editB";
            editB.Size = new Size(66, 23);
            editB.TabIndex = 12;
            editB.Text = "Edit";
            editB.UseVisualStyleBackColor = true;
            editB.Click += EditB_Click;
            // 
            // okB
            // 
            okB.Location = new Point(147, 3);
            okB.Name = "okB";
            okB.Size = new Size(66, 23);
            okB.TabIndex = 13;
            okB.Text = "OK";
            okB.UseVisualStyleBackColor = true;
            okB.Click += OkB_Click;
            // 
            // cancelB
            // 
            cancelB.Location = new Point(219, 3);
            cancelB.Name = "cancelB";
            cancelB.Size = new Size(66, 23);
            cancelB.TabIndex = 14;
            cancelB.Text = "Cancel";
            cancelB.UseVisualStyleBackColor = true;
            cancelB.Click += CancelB_Click;
            // 
            // removeB
            // 
            removeB.Location = new Point(291, 3);
            removeB.Name = "removeB";
            removeB.Size = new Size(67, 23);
            removeB.TabIndex = 15;
            removeB.Text = "Remove";
            removeB.UseVisualStyleBackColor = true;
            removeB.Click += RemoveB_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(addItemB, 0, 0);
            tableLayoutPanel1.Controls.Add(removeB, 4, 0);
            tableLayoutPanel1.Controls.Add(editB, 1, 0);
            tableLayoutPanel1.Controls.Add(cancelB, 3, 0);
            tableLayoutPanel1.Controls.Add(okB, 2, 0);
            tableLayoutPanel1.Location = new Point(3, 354);
            tableLayoutPanel1.Margin = new Padding(3, 6, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(361, 29);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(stayDateDTP, 1, 3);
            tableLayoutPanel2.Controls.Add(geolocationTB, 1, 0);
            tableLayoutPanel2.Controls.Add(descriptionTB, 1, 2);
            tableLayoutPanel2.Controls.Add(titleTB, 1, 1);
            tableLayoutPanel2.Location = new Point(3, 229);
            tableLayoutPanel2.Margin = new Padding(3, 6, 3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(361, 116);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = SystemColors.ControlDark;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 0);
            label6.Margin = new Padding(3, 0, 3, 6);
            label6.Name = "label6";
            label6.Size = new Size(361, 23);
            label6.TabIndex = 18;
            label6.Text = "Public Destinations";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 3);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel3.Controls.Add(destinationsLV, 0, 1);
            tableLayoutPanel3.Location = new Point(7, 7);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(367, 386);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(24, 24);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(752, 402);
            panel1.TabIndex = 20;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AdminForm";
            Padding = new Padding(24);
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView destinationsLV;
        private TextBox geolocationTB;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox titleTB;
        private TextBox descriptionTB;
        private DateTimePicker stayDateDTP;
        private Label label5;
        private PictureBox pictureBox1;
        private Button addItemB;
        private Button editB;
        private Button okB;
        private Button cancelB;
        private Button removeB;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
    }
}