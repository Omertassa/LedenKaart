namespace Ledenkaart_Verzender
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelCounterSkipped = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PreviousSkipped = new System.Windows.Forms.Button();
            this.NextSkipped = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmailSkipped = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPhoneSkipped = new System.Windows.Forms.Label();
            this.labelLocationSkipped = new System.Windows.Forms.Label();
            this.labelMobileSkipped = new System.Windows.Forms.Label();
            this.labelFullNameSkipped = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAdresSkipped = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPostcodeSkipped = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCounterImported = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PreviousImported = new System.Windows.Forms.Button();
            this.NextImported = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelPostcode = new System.Windows.Forms.Label();
            this.importerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.importerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImport
            // 
            this.buttonImport.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonImport.Location = new System.Drawing.Point(13, 170);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(178, 91);
            this.buttonImport.TabIndex = 0;
            this.buttonImport.Text = "Importeren";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(13, 275);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(178, 91);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Verzenden";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Crimson;
            this.statusLabel.Location = new System.Drawing.Point(0, 521);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLabel.Size = new System.Drawing.Size(1255, 66);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "label1";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonImport);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSend);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Enabled = false;
            this.splitContainer1.Size = new System.Drawing.Size(1228, 506);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ledenkaart_Verzender.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 506);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.labelCounterSkipped);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.PreviousSkipped);
            this.tabPage1.Controls.Add(this.NextSkipped);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelEmailSkipped);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelPhoneSkipped);
            this.tabPage1.Controls.Add(this.labelLocationSkipped);
            this.tabPage1.Controls.Add(this.labelMobileSkipped);
            this.tabPage1.Controls.Add(this.labelFullNameSkipped);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.labelAdresSkipped);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.labelPostcodeSkipped);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overgeslagen";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.Location = new System.Drawing.Point(26, 155);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(978, 268);
            this.dataGridView2.TabIndex = 35;
            // 
            // labelCounterSkipped
            // 
            this.labelCounterSkipped.AutoSize = true;
            this.labelCounterSkipped.Location = new System.Drawing.Point(503, 439);
            this.labelCounterSkipped.Name = "labelCounterSkipped";
            this.labelCounterSkipped.Size = new System.Drawing.Size(28, 17);
            this.labelCounterSkipped.TabIndex = 16;
            this.labelCounterSkipped.Text = "0/0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hoofdbewoner:";
            // 
            // PreviousSkipped
            // 
            this.PreviousSkipped.Location = new System.Drawing.Point(434, 429);
            this.PreviousSkipped.Name = "PreviousSkipped";
            this.PreviousSkipped.Size = new System.Drawing.Size(45, 38);
            this.PreviousSkipped.TabIndex = 1;
            this.PreviousSkipped.Text = "<<";
            this.PreviousSkipped.UseVisualStyleBackColor = true;
            this.PreviousSkipped.Click += new System.EventHandler(this.PreviousSkipped_Click);
            // 
            // NextSkipped
            // 
            this.NextSkipped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextSkipped.Location = new System.Drawing.Point(552, 429);
            this.NextSkipped.Name = "NextSkipped";
            this.NextSkipped.Size = new System.Drawing.Size(45, 38);
            this.NextSkipped.TabIndex = 0;
            this.NextSkipped.Text = ">>";
            this.NextSkipped.UseVisualStyleBackColor = true;
            this.NextSkipped.Click += new System.EventHandler(this.NextSkipped_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gezinsleden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(978, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------------------";
            // 
            // labelEmailSkipped
            // 
            this.labelEmailSkipped.Location = new System.Drawing.Point(680, 17);
            this.labelEmailSkipped.Name = "labelEmailSkipped";
            this.labelEmailSkipped.Size = new System.Drawing.Size(54, 17);
            this.labelEmailSkipped.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email-adres:";
            this.label3.Visible = false;
            // 
            // labelPhoneSkipped
            // 
            this.labelPhoneSkipped.AutoSize = true;
            this.labelPhoneSkipped.Location = new System.Drawing.Point(680, 46);
            this.labelPhoneSkipped.Name = "labelPhoneSkipped";
            this.labelPhoneSkipped.Size = new System.Drawing.Size(0, 17);
            this.labelPhoneSkipped.TabIndex = 12;
            // 
            // labelLocationSkipped
            // 
            this.labelLocationSkipped.AutoSize = true;
            this.labelLocationSkipped.Location = new System.Drawing.Point(259, 73);
            this.labelLocationSkipped.Name = "labelLocationSkipped";
            this.labelLocationSkipped.Size = new System.Drawing.Size(0, 17);
            this.labelLocationSkipped.TabIndex = 5;
            // 
            // labelMobileSkipped
            // 
            this.labelMobileSkipped.AutoSize = true;
            this.labelMobileSkipped.Location = new System.Drawing.Point(680, 73);
            this.labelMobileSkipped.Name = "labelMobileSkipped";
            this.labelMobileSkipped.Size = new System.Drawing.Size(0, 17);
            this.labelMobileSkipped.TabIndex = 11;
            // 
            // labelFullNameSkipped
            // 
            this.labelFullNameSkipped.AutoSize = true;
            this.labelFullNameSkipped.Location = new System.Drawing.Point(186, 17);
            this.labelFullNameSkipped.Name = "labelFullNameSkipped";
            this.labelFullNameSkipped.Size = new System.Drawing.Size(0, 17);
            this.labelFullNameSkipped.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(591, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mobiel:";
            this.label9.Visible = false;
            // 
            // labelAdresSkipped
            // 
            this.labelAdresSkipped.AutoSize = true;
            this.labelAdresSkipped.Location = new System.Drawing.Point(186, 46);
            this.labelAdresSkipped.Name = "labelAdresSkipped";
            this.labelAdresSkipped.Size = new System.Drawing.Size(0, 17);
            this.labelAdresSkipped.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(591, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telefoon:";
            this.label8.Visible = false;
            // 
            // labelPostcodeSkipped
            // 
            this.labelPostcodeSkipped.AutoSize = true;
            this.labelPostcodeSkipped.Location = new System.Drawing.Point(186, 73);
            this.labelPostcodeSkipped.Name = "labelPostcodeSkipped";
            this.labelPostcodeSkipped.Size = new System.Drawing.Size(0, 17);
            this.labelPostcodeSkipped.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.labelCounterImported);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.PreviousImported);
            this.tabPage2.Controls.Add(this.NextImported);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.labelEmail);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.labelPhone);
            this.tabPage2.Controls.Add(this.labelLocation);
            this.tabPage2.Controls.Add(this.labelMobile);
            this.tabPage2.Controls.Add(this.labelFullName);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.labelAdres);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.labelPostcode);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1020, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geimporteerd";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(978, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------------------";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(26, 155);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(978, 268);
            this.dataGridView1.TabIndex = 36;
            // 
            // labelCounterImported
            // 
            this.labelCounterImported.AutoSize = true;
            this.labelCounterImported.Location = new System.Drawing.Point(503, 440);
            this.labelCounterImported.Name = "labelCounterImported";
            this.labelCounterImported.Size = new System.Drawing.Size(28, 17);
            this.labelCounterImported.TabIndex = 32;
            this.labelCounterImported.Text = "0/0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hoofdbewoner:";
            // 
            // PreviousImported
            // 
            this.PreviousImported.Location = new System.Drawing.Point(434, 429);
            this.PreviousImported.Name = "PreviousImported";
            this.PreviousImported.Size = new System.Drawing.Size(45, 38);
            this.PreviousImported.TabIndex = 17;
            this.PreviousImported.Text = "<<";
            this.PreviousImported.UseVisualStyleBackColor = true;
            this.PreviousImported.Click += new System.EventHandler(this.PreviousImported_Click);
            // 
            // NextImported
            // 
            this.NextImported.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextImported.Location = new System.Drawing.Point(552, 429);
            this.NextImported.Name = "NextImported";
            this.NextImported.Size = new System.Drawing.Size(45, 38);
            this.NextImported.TabIndex = 16;
            this.NextImported.Text = ">>";
            this.NextImported.UseVisualStyleBackColor = true;
            this.NextImported.Click += new System.EventHandler(this.NextImported_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Gezinsleden";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(681, 17);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 17);
            this.labelEmail.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(592, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Email-adres:";
            this.label13.Visible = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(681, 46);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(0, 17);
            this.labelPhone.TabIndex = 28;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(256, 73);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(0, 17);
            this.labelLocation.TabIndex = 21;
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Location = new System.Drawing.Point(681, 73);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(0, 17);
            this.labelMobile.TabIndex = 27;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(183, 17);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(0, 17);
            this.labelFullName.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(592, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 17);
            this.label18.TabIndex = 26;
            this.label18.Text = "Mobiel:";
            this.label18.Visible = false;
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(183, 46);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(0, 17);
            this.labelAdres.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(592, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 17);
            this.label20.TabIndex = 25;
            this.label20.Text = "Telefoon:";
            this.label20.Visible = false;
            // 
            // labelPostcode
            // 
            this.labelPostcode.AutoSize = true;
            this.labelPostcode.Location = new System.Drawing.Point(183, 73);
            this.labelPostcode.Name = "labelPostcode";
            this.labelPostcode.Size = new System.Drawing.Size(0, 17);
            this.labelPostcode.TabIndex = 24;
            // 
            // importerBindingSource1
            // 
            this.importerBindingSource1.DataSource = typeof(Ledenkaart_Verzender.Importer);
            // 
            // importerBindingSource
            // 
            this.importerBindingSource.DataSource = typeof(Ledenkaart_Verzender.Importer);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1255, 587);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoofdmenu";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelPhoneSkipped;
        private System.Windows.Forms.Label labelMobileSkipped;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPostcodeSkipped;
        private System.Windows.Forms.Label labelAdresSkipped;
        private System.Windows.Forms.Label labelFullNameSkipped;
        private System.Windows.Forms.Label labelLocationSkipped;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PreviousSkipped;
        private System.Windows.Forms.Button NextSkipped;
        private System.Windows.Forms.Label labelEmailSkipped;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button PreviousImported;
        private System.Windows.Forms.Button NextImported;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelPostcode;
        private System.Windows.Forms.Label labelCounterSkipped;
        private System.Windows.Forms.Label labelCounterImported;
        private System.Windows.Forms.BindingSource importerBindingSource;
        private System.Windows.Forms.BindingSource importerBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

