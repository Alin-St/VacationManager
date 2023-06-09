namespace VacationDestinationManager.UI
{
    partial class ClientForm
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
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            addToPrivateListB = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pd_geolocationTB = new TextBox();
            pd_descriptionTB = new TextBox();
            pd_titleTB = new TextBox();
            pd_stayDateTB = new TextBox();
            publicDestinationsLV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            addB = new Button();
            removeB = new Button();
            editB = new Button();
            cancelB = new Button();
            okB = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            stayDateDTP = new DateTimePicker();
            geolocationTB = new TextBox();
            descriptionTB = new TextBox();
            titleTB = new TextBox();
            privateDestinationsLV = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            selectB = new Button();
            clearB = new Button();
            imagePB = new PictureBox();
            label14 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            label11 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            tableLayoutPanel9 = new TableLayoutPanel();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePB).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(24, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(752, 402);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 402);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 3);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel3.Controls.Add(publicDestinationsLV, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(248, 400);
            tableLayoutPanel3.TabIndex = 20;
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
            label6.Size = new Size(242, 23);
            label6.TabIndex = 18;
            label6.Text = "Public Destinations";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(addToPrivateListB, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 368);
            tableLayoutPanel1.Margin = new Padding(3, 6, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(242, 29);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // addToPrivateListB
            // 
            addToPrivateListB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addToPrivateListB.Location = new Point(3, 3);
            addToPrivateListB.Name = "addToPrivateListB";
            addToPrivateListB.Size = new Size(236, 23);
            addToPrivateListB.TabIndex = 11;
            addToPrivateListB.Text = "Add to private list";
            addToPrivateListB.UseVisualStyleBackColor = true;
            addToPrivateListB.Click += AddFromPublicListB_Click;
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
            tableLayoutPanel2.Controls.Add(pd_geolocationTB, 1, 0);
            tableLayoutPanel2.Controls.Add(pd_descriptionTB, 1, 2);
            tableLayoutPanel2.Controls.Add(pd_titleTB, 1, 1);
            tableLayoutPanel2.Controls.Add(pd_stayDateTB, 1, 3);
            tableLayoutPanel2.Location = new Point(3, 243);
            tableLayoutPanel2.Margin = new Padding(3, 6, 3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(242, 116);
            tableLayoutPanel2.TabIndex = 17;
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
            // pd_geolocationTB
            // 
            pd_geolocationTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pd_geolocationTB.Location = new Point(83, 3);
            pd_geolocationTB.Name = "pd_geolocationTB";
            pd_geolocationTB.ReadOnly = true;
            pd_geolocationTB.Size = new Size(156, 23);
            pd_geolocationTB.TabIndex = 1;
            // 
            // pd_descriptionTB
            // 
            pd_descriptionTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pd_descriptionTB.Location = new Point(83, 61);
            pd_descriptionTB.Name = "pd_descriptionTB";
            pd_descriptionTB.ReadOnly = true;
            pd_descriptionTB.Size = new Size(156, 23);
            pd_descriptionTB.TabIndex = 7;
            // 
            // pd_titleTB
            // 
            pd_titleTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pd_titleTB.Location = new Point(83, 32);
            pd_titleTB.Name = "pd_titleTB";
            pd_titleTB.ReadOnly = true;
            pd_titleTB.Size = new Size(156, 23);
            pd_titleTB.TabIndex = 6;
            // 
            // pd_stayDateTB
            // 
            pd_stayDateTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pd_stayDateTB.Location = new Point(83, 90);
            pd_stayDateTB.Name = "pd_stayDateTB";
            pd_stayDateTB.ReadOnly = true;
            pd_stayDateTB.Size = new Size(156, 23);
            pd_stayDateTB.TabIndex = 8;
            // 
            // publicDestinationsLV
            // 
            publicDestinationsLV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            publicDestinationsLV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            publicDestinationsLV.FullRowSelect = true;
            publicDestinationsLV.GridLines = true;
            publicDestinationsLV.Location = new Point(3, 32);
            publicDestinationsLV.MultiSelect = false;
            publicDestinationsLV.Name = "publicDestinationsLV";
            publicDestinationsLV.Size = new Size(242, 202);
            publicDestinationsLV.TabIndex = 0;
            publicDestinationsLV.UseCompatibleStateImageBehavior = false;
            publicDestinationsLV.View = View.Details;
            publicDestinationsLV.SelectedIndexChanged += DestinationsLV_SelectedIndexChanged;
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
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel4);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(selectB);
            splitContainer2.Panel2.Controls.Add(clearB);
            splitContainer2.Panel2.Controls.Add(imagePB);
            splitContainer2.Panel2.Controls.Add(label14);
            splitContainer2.Size = new Size(498, 402);
            splitContainer2.SplitterDistance = 253;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel4.Controls.Add(privateDestinationsLV, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(251, 400);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = SystemColors.ControlDark;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 0);
            label5.Margin = new Padding(3, 0, 3, 6);
            label5.Name = "label5";
            label5.Size = new Size(245, 23);
            label5.TabIndex = 18;
            label5.Text = "Private Destinations";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Controls.Add(addB, 0, 0);
            tableLayoutPanel5.Controls.Add(removeB, 4, 0);
            tableLayoutPanel5.Controls.Add(editB, 1, 0);
            tableLayoutPanel5.Controls.Add(cancelB, 3, 0);
            tableLayoutPanel5.Controls.Add(okB, 2, 0);
            tableLayoutPanel5.Location = new Point(3, 368);
            tableLayoutPanel5.Margin = new Padding(3, 6, 3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(245, 29);
            tableLayoutPanel5.TabIndex = 16;
            // 
            // addB
            // 
            addB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addB.Location = new Point(3, 3);
            addB.Name = "addB";
            addB.Size = new Size(43, 23);
            addB.TabIndex = 11;
            addB.Text = "Add Item";
            addB.UseVisualStyleBackColor = true;
            addB.Click += AddB_Click;
            // 
            // removeB
            // 
            removeB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            removeB.Location = new Point(199, 3);
            removeB.Name = "removeB";
            removeB.Size = new Size(43, 23);
            removeB.TabIndex = 15;
            removeB.Text = "Remove";
            removeB.UseVisualStyleBackColor = true;
            removeB.Click += RemoveB_Click;
            // 
            // editB
            // 
            editB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            editB.Location = new Point(52, 3);
            editB.Name = "editB";
            editB.Size = new Size(43, 23);
            editB.TabIndex = 12;
            editB.Text = "Edit";
            editB.UseVisualStyleBackColor = true;
            editB.Click += EditB_Click;
            // 
            // cancelB
            // 
            cancelB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cancelB.Location = new Point(150, 3);
            cancelB.Name = "cancelB";
            cancelB.Size = new Size(43, 23);
            cancelB.TabIndex = 14;
            cancelB.Text = "Cancel";
            cancelB.UseVisualStyleBackColor = true;
            cancelB.Click += CancelB_Click;
            // 
            // okB
            // 
            okB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            okB.Location = new Point(101, 3);
            okB.Name = "okB";
            okB.Size = new Size(43, 23);
            okB.TabIndex = 13;
            okB.Text = "OK";
            okB.UseVisualStyleBackColor = true;
            okB.Click += OkB_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label7, 0, 0);
            tableLayoutPanel6.Controls.Add(label8, 0, 1);
            tableLayoutPanel6.Controls.Add(label9, 0, 2);
            tableLayoutPanel6.Controls.Add(label10, 0, 3);
            tableLayoutPanel6.Controls.Add(stayDateDTP, 1, 3);
            tableLayoutPanel6.Controls.Add(geolocationTB, 1, 0);
            tableLayoutPanel6.Controls.Add(descriptionTB, 1, 2);
            tableLayoutPanel6.Controls.Add(titleTB, 1, 1);
            tableLayoutPanel6.Location = new Point(3, 243);
            tableLayoutPanel6.Margin = new Padding(3, 6, 3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 4;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Size = new Size(245, 116);
            tableLayoutPanel6.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 7);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 2;
            label7.Text = "Geolocation:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 36);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 3;
            label8.Text = "Title:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 65);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 4;
            label9.Text = "Description:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 94);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 5;
            label10.Text = "Stay Date:";
            // 
            // stayDateDTP
            // 
            stayDateDTP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            stayDateDTP.Location = new Point(83, 90);
            stayDateDTP.Name = "stayDateDTP";
            stayDateDTP.Size = new Size(159, 23);
            stayDateDTP.TabIndex = 8;
            // 
            // geolocationTB
            // 
            geolocationTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            geolocationTB.Location = new Point(83, 3);
            geolocationTB.Name = "geolocationTB";
            geolocationTB.Size = new Size(159, 23);
            geolocationTB.TabIndex = 1;
            // 
            // descriptionTB
            // 
            descriptionTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descriptionTB.Location = new Point(83, 61);
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(159, 23);
            descriptionTB.TabIndex = 7;
            // 
            // titleTB
            // 
            titleTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            titleTB.Location = new Point(83, 32);
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(159, 23);
            titleTB.TabIndex = 6;
            // 
            // privateDestinationsLV
            // 
            privateDestinationsLV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            privateDestinationsLV.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            privateDestinationsLV.FullRowSelect = true;
            privateDestinationsLV.GridLines = true;
            privateDestinationsLV.Location = new Point(3, 32);
            privateDestinationsLV.MultiSelect = false;
            privateDestinationsLV.Name = "privateDestinationsLV";
            privateDestinationsLV.Size = new Size(245, 202);
            privateDestinationsLV.TabIndex = 0;
            privateDestinationsLV.UseCompatibleStateImageBehavior = false;
            privateDestinationsLV.View = View.Details;
            privateDestinationsLV.SelectedIndexChanged += DestinationsLV_SelectedIndexChanged;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Geolocation";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Title";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Description";
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Stay Date";
            columnHeader8.Width = 80;
            // 
            // selectB
            // 
            selectB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectB.Location = new Point(158, 8);
            selectB.Name = "selectB";
            selectB.Size = new Size(75, 23);
            selectB.TabIndex = 23;
            selectB.Text = "Select";
            selectB.UseVisualStyleBackColor = true;
            selectB.Click += SelectImageB_Click;
            // 
            // clearB
            // 
            clearB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearB.Location = new Point(77, 8);
            clearB.Name = "clearB";
            clearB.Size = new Size(75, 23);
            clearB.TabIndex = 22;
            clearB.Text = "Clear";
            clearB.UseVisualStyleBackColor = true;
            clearB.Click += ClearImageB_Click;
            // 
            // imagePB
            // 
            imagePB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imagePB.BorderStyle = BorderStyle.FixedSingle;
            imagePB.Location = new Point(5, 35);
            imagePB.Name = "imagePB";
            imagePB.Size = new Size(228, 359);
            imagePB.SizeMode = PictureBoxSizeMode.Zoom;
            imagePB.TabIndex = 12;
            imagePB.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(5, 8);
            label14.Name = "label14";
            label14.Size = new Size(54, 20);
            label14.TabIndex = 11;
            label14.Text = "Image:";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label11, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 3);
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(200, 100);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.BackColor = SystemColors.ControlDark;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 0);
            label11.Margin = new Padding(3, 0, 3, 6);
            label11.Name = "label11";
            label11.Size = new Size(194, 14);
            label11.TabIndex = 18;
            label11.Text = "Public Destinations";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.AutoSize = true;
            tableLayoutPanel8.ColumnCount = 5;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.Controls.Add(button6, 0, 0);
            tableLayoutPanel8.Controls.Add(button7, 4, 0);
            tableLayoutPanel8.Controls.Add(button8, 1, 0);
            tableLayoutPanel8.Controls.Add(button9, 3, 0);
            tableLayoutPanel8.Controls.Add(button10, 2, 0);
            tableLayoutPanel8.Location = new Point(3, 67);
            tableLayoutPanel8.Margin = new Padding(3, 6, 3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle());
            tableLayoutPanel8.Size = new Size(194, 29);
            tableLayoutPanel8.TabIndex = 16;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(32, 23);
            button6.TabIndex = 11;
            button6.Text = "Add Item";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button7.Location = new Point(155, 3);
            button7.Name = "button7";
            button7.Size = new Size(36, 23);
            button7.TabIndex = 15;
            button7.Text = "Remove";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button8.Location = new Point(41, 3);
            button8.Name = "button8";
            button8.Size = new Size(32, 23);
            button8.TabIndex = 12;
            button8.Text = "Edit";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button9.Location = new Point(117, 3);
            button9.Name = "button9";
            button9.Size = new Size(32, 23);
            button9.TabIndex = 14;
            button9.Text = "Cancel";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button10.Location = new Point(79, 3);
            button10.Name = "button10";
            button10.Size = new Size(32, 23);
            button10.TabIndex = 13;
            button10.Text = "OK";
            button10.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel9.AutoSize = true;
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(label12, 0, 0);
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.Size = new Size(200, 100);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(3, 42);
            label12.Name = "label12";
            label12.Size = new Size(74, 15);
            label12.TabIndex = 2;
            label12.Text = "Geolocation:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(3, 50);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 3;
            label13.Text = "Title:";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "ClientForm";
            Padding = new Padding(24);
            Text = "ClientForm";
            Load += ClientForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagePB).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Button addToPrivateListB;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox pd_geolocationTB;
        private TextBox pd_descriptionTB;
        private TextBox pd_titleTB;
        private ListView publicDestinationsLV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel5;
        private Button addB;
        private Button removeB;
        private Button editB;
        private Button cancelB;
        private Button okB;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker stayDateDTP;
        private TextBox geolocationTB;
        private TextBox descriptionTB;
        private TextBox titleTB;
        private ListView privateDestinationsLV;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel8;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label12;
        private Label label13;
        private PictureBox imagePB;
        private Label label14;
        private Button selectB;
        private Button clearB;
        private TextBox pd_stayDateTB;
    }
}