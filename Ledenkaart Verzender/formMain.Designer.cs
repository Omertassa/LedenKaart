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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblCounterSkipped = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPreviousSkipped = new System.Windows.Forms.Button();
            this.btnNextSkipped = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmailSkipped = new System.Windows.Forms.Label();
            this.lblEmailAdresSkipped = new System.Windows.Forms.Label();
            this.labelPhoneSkipped = new System.Windows.Forms.Label();
            this.lblLocationSkipped = new System.Windows.Forms.Label();
            this.labelMobileSkipped = new System.Windows.Forms.Label();
            this.lblFullNameSkipped = new System.Windows.Forms.Label();
            this.lblMobileNumberSkipped = new System.Windows.Forms.Label();
            this.lblAdresSkipped = new System.Windows.Forms.Label();
            this.lblPhoneNumberSkipped = new System.Windows.Forms.Label();
            this.lblPostcodeSkipped = new System.Windows.Forms.Label();
            this.lblPhoneNumberImported = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCounterImported = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPreviousImported = new System.Windows.Forms.Button();
            this.btnNextImported = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.lblEmailAdresImported = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.lblLocationImported = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.lblFullNameImported = new System.Windows.Forms.Label();
            this.lblMobileImported = new System.Windows.Forms.Label();
            this.lblAdresImported = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPostodeImported = new System.Windows.Forms.Label();
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
            this.lblPhoneNumberImported.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnImport.Location = new System.Drawing.Point(10, 138);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(134, 74);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Importeren";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(10, 293);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(134, 74);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Verzenden";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Crimson;
            this.lblStatus.Location = new System.Drawing.Point(0, 423);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(941, 54);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "label1";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(9, 10);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnImport);
            this.splitContainer1.Panel1.Controls.Add(this.btnSend);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Enabled = false;
            this.splitContainer1.Size = new System.Drawing.Size(921, 411);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ledenkaart_Verzender.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.lblPhoneNumberImported);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 411);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.lblCounterSkipped);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnPreviousSkipped);
            this.tabPage1.Controls.Add(this.btnNextSkipped);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelEmailSkipped);
            this.tabPage1.Controls.Add(this.lblEmailAdresSkipped);
            this.tabPage1.Controls.Add(this.labelPhoneSkipped);
            this.tabPage1.Controls.Add(this.lblLocationSkipped);
            this.tabPage1.Controls.Add(this.labelMobileSkipped);
            this.tabPage1.Controls.Add(this.lblFullNameSkipped);
            this.tabPage1.Controls.Add(this.lblMobileNumberSkipped);
            this.tabPage1.Controls.Add(this.lblAdresSkipped);
            this.tabPage1.Controls.Add(this.lblPhoneNumberSkipped);
            this.tabPage1.Controls.Add(this.lblPostcodeSkipped);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(763, 385);
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
            this.dataGridView2.Location = new System.Drawing.Point(20, 126);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
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
            this.dataGridView2.Size = new System.Drawing.Size(734, 218);
            this.dataGridView2.TabIndex = 35;
            // 
            // lblCounterSkipped
            // 
            this.lblCounterSkipped.AutoSize = true;
            this.lblCounterSkipped.Location = new System.Drawing.Point(377, 357);
            this.lblCounterSkipped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounterSkipped.Name = "lblCounterSkipped";
            this.lblCounterSkipped.Size = new System.Drawing.Size(24, 15);
            this.lblCounterSkipped.TabIndex = 16;
            this.lblCounterSkipped.Text = "0/0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hoofdbewoner:";
            // 
            // btnPreviousSkipped
            // 
            this.btnPreviousSkipped.Location = new System.Drawing.Point(326, 349);
            this.btnPreviousSkipped.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreviousSkipped.Name = "btnPreviousSkipped";
            this.btnPreviousSkipped.Size = new System.Drawing.Size(34, 31);
            this.btnPreviousSkipped.TabIndex = 1;
            this.btnPreviousSkipped.Text = "<<";
            this.btnPreviousSkipped.UseVisualStyleBackColor = true;
            this.btnPreviousSkipped.Click += new System.EventHandler(this.PreviousSkipped_Click);
            // 
            // btnNextSkipped
            // 
            this.btnNextSkipped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNextSkipped.Location = new System.Drawing.Point(414, 349);
            this.btnNextSkipped.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextSkipped.Name = "btnNextSkipped";
            this.btnNextSkipped.Size = new System.Drawing.Size(34, 31);
            this.btnNextSkipped.TabIndex = 0;
            this.btnNextSkipped.Text = ">>";
            this.btnNextSkipped.UseVisualStyleBackColor = true;
            this.btnNextSkipped.Click += new System.EventHandler(this.NextSkipped_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gezinsleden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------------------";
            // 
            // labelEmailSkipped
            // 
            this.labelEmailSkipped.Location = new System.Drawing.Point(510, 14);
            this.labelEmailSkipped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmailSkipped.Name = "labelEmailSkipped";
            this.labelEmailSkipped.Size = new System.Drawing.Size(40, 14);
            this.labelEmailSkipped.TabIndex = 13;
            // 
            // lblEmailAdresSkipped
            // 
            this.lblEmailAdresSkipped.AutoSize = true;
            this.lblEmailAdresSkipped.Location = new System.Drawing.Point(443, 14);
            this.lblEmailAdresSkipped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailAdresSkipped.Name = "lblEmailAdresSkipped";
            this.lblEmailAdresSkipped.Size = new System.Drawing.Size(77, 15);
            this.lblEmailAdresSkipped.TabIndex = 4;
            this.lblEmailAdresSkipped.Text = "Email-adres:";
            this.lblEmailAdresSkipped.Visible = false;
            // 
            // labelPhoneSkipped
            // 
            this.labelPhoneSkipped.AutoSize = true;
            this.labelPhoneSkipped.Location = new System.Drawing.Point(510, 37);
            this.labelPhoneSkipped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhoneSkipped.Name = "labelPhoneSkipped";
            this.labelPhoneSkipped.Size = new System.Drawing.Size(0, 15);
            this.labelPhoneSkipped.TabIndex = 12;
            // 
            // lblLocationSkipped
            // 
            this.lblLocationSkipped.AutoSize = true;
            this.lblLocationSkipped.Location = new System.Drawing.Point(194, 59);
            this.lblLocationSkipped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationSkipped.Name = "lblLocationSkipped";
            this.lblLocationSkipped.Size = new System.Drawing.Size(0, 15);
            this.lblLocationSkipped.TabIndex = 5;
            // 
            // labelMobileSkipped
            // 
            this.labelMobileSkipped.AutoSize = true;
            this.labelMobileSkipped.Location = new System.Drawing.Point(510, 59);
            this.labelMobileSkipped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMobileSkipped.Name = "labelMobileSkipped";
            this.labelMobileSkipped.Size = new System.Drawing.Size(0, 15);
            this.labelMobileSkipped.TabIndex = 11;
            // 
            // lblFullNameSkipped
            // 
            this.lblFullNameSkipped.AutoSize = true;
            this.lblFullNameSkipped.Location = new System.Drawing.Point(140, 14);
            this.lblFullNameSkipped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullNameSkipped.Name = "lblFullNameSkipped";
            this.lblFullNameSkipped.Size = new System.Drawing.Size(0, 15);
            this.lblFullNameSkipped.TabIndex = 6;
            // 
            // lblMobileNumberSkipped
            // 
            this.lblMobileNumberSkipped.AutoSize = true;
            this.lblMobileNumberSkipped.Location = new System.Drawing.Point(443, 59);
            this.lblMobileNumberSkipped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMobileNumberSkipped.Name = "lblMobileNumberSkipped";
            this.lblMobileNumberSkipped.Size = new System.Drawing.Size(48, 15);
            this.lblMobileNumberSkipped.TabIndex = 10;
            this.lblMobileNumberSkipped.Text = "Mobiel:";
            this.lblMobileNumberSkipped.Visible = false;
            // 
            // lblAdresSkipped
            // 
            this.lblAdresSkipped.AutoSize = true;
            this.lblAdresSkipped.Location = new System.Drawing.Point(140, 37);
            this.lblAdresSkipped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresSkipped.Name = "lblAdresSkipped";
            this.lblAdresSkipped.Size = new System.Drawing.Size(0, 15);
            this.lblAdresSkipped.TabIndex = 7;
            // 
            // lblPhoneNumberSkipped
            // 
            this.lblPhoneNumberSkipped.AutoSize = true;
            this.lblPhoneNumberSkipped.Location = new System.Drawing.Point(443, 37);
            this.lblPhoneNumberSkipped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumberSkipped.Name = "lblPhoneNumberSkipped";
            this.lblPhoneNumberSkipped.Size = new System.Drawing.Size(58, 15);
            this.lblPhoneNumberSkipped.TabIndex = 9;
            this.lblPhoneNumberSkipped.Text = "Telefoon:";
            this.lblPhoneNumberSkipped.Visible = false;
            // 
            // lblPostcodeSkipped
            // 
            this.lblPostcodeSkipped.AutoSize = true;
            this.lblPostcodeSkipped.Location = new System.Drawing.Point(140, 59);
            this.lblPostcodeSkipped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostcodeSkipped.Name = "lblPostcodeSkipped";
            this.lblPostcodeSkipped.Size = new System.Drawing.Size(0, 15);
            this.lblPostcodeSkipped.TabIndex = 8;
            // 
            // lblPhoneNumberImported
            // 
            this.lblPhoneNumberImported.Controls.Add(this.label5);
            this.lblPhoneNumberImported.Controls.Add(this.dataGridView1);
            this.lblPhoneNumberImported.Controls.Add(this.lblCounterImported);
            this.lblPhoneNumberImported.Controls.Add(this.label7);
            this.lblPhoneNumberImported.Controls.Add(this.btnPreviousImported);
            this.lblPhoneNumberImported.Controls.Add(this.btnNextImported);
            this.lblPhoneNumberImported.Controls.Add(this.label10);
            this.lblPhoneNumberImported.Controls.Add(this.labelEmail);
            this.lblPhoneNumberImported.Controls.Add(this.lblEmailAdresImported);
            this.lblPhoneNumberImported.Controls.Add(this.labelPhone);
            this.lblPhoneNumberImported.Controls.Add(this.lblLocationImported);
            this.lblPhoneNumberImported.Controls.Add(this.labelMobile);
            this.lblPhoneNumberImported.Controls.Add(this.lblFullNameImported);
            this.lblPhoneNumberImported.Controls.Add(this.lblMobileImported);
            this.lblPhoneNumberImported.Controls.Add(this.lblAdresImported);
            this.lblPhoneNumberImported.Controls.Add(this.label20);
            this.lblPhoneNumberImported.Controls.Add(this.lblPostodeImported);
            this.lblPhoneNumberImported.Location = new System.Drawing.Point(4, 22);
            this.lblPhoneNumberImported.Margin = new System.Windows.Forms.Padding(2);
            this.lblPhoneNumberImported.Name = "lblPhoneNumberImported";
            this.lblPhoneNumberImported.Padding = new System.Windows.Forms.Padding(2);
            this.lblPhoneNumberImported.Size = new System.Drawing.Size(763, 385);
            this.lblPhoneNumberImported.TabIndex = 1;
            this.lblPhoneNumberImported.Text = "Geimporteerd";
            this.lblPhoneNumberImported.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(783, 15);
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
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
            this.dataGridView1.Size = new System.Drawing.Size(734, 218);
            this.dataGridView1.TabIndex = 36;
            // 
            // lblCounterImported
            // 
            this.lblCounterImported.AutoSize = true;
            this.lblCounterImported.Location = new System.Drawing.Point(377, 358);
            this.lblCounterImported.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounterImported.Name = "lblCounterImported";
            this.lblCounterImported.Size = new System.Drawing.Size(24, 15);
            this.lblCounterImported.TabIndex = 32;
            this.lblCounterImported.Text = "0/0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hoofdbewoner:";
            // 
            // btnPreviousImported
            // 
            this.btnPreviousImported.Location = new System.Drawing.Point(326, 349);
            this.btnPreviousImported.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreviousImported.Name = "btnPreviousImported";
            this.btnPreviousImported.Size = new System.Drawing.Size(34, 31);
            this.btnPreviousImported.TabIndex = 17;
            this.btnPreviousImported.Text = "<<";
            this.btnPreviousImported.UseVisualStyleBackColor = true;
            this.btnPreviousImported.Click += new System.EventHandler(this.PreviousImported_Click);
            // 
            // btnNextImported
            // 
            this.btnNextImported.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNextImported.Location = new System.Drawing.Point(414, 349);
            this.btnNextImported.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextImported.Name = "btnNextImported";
            this.btnNextImported.Size = new System.Drawing.Size(34, 31);
            this.btnNextImported.TabIndex = 16;
            this.btnNextImported.Text = ">>";
            this.btnNextImported.UseVisualStyleBackColor = true;
            this.btnNextImported.Click += new System.EventHandler(this.NextImported_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Gezinsleden";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(511, 14);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 15);
            this.labelEmail.TabIndex = 29;
            // 
            // lblEmailAdresImported
            // 
            this.lblEmailAdresImported.AutoSize = true;
            this.lblEmailAdresImported.Location = new System.Drawing.Point(444, 14);
            this.lblEmailAdresImported.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailAdresImported.Name = "lblEmailAdresImported";
            this.lblEmailAdresImported.Size = new System.Drawing.Size(77, 15);
            this.lblEmailAdresImported.TabIndex = 20;
            this.lblEmailAdresImported.Text = "Email-adres:";
            this.lblEmailAdresImported.Visible = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(511, 37);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(0, 15);
            this.labelPhone.TabIndex = 28;
            // 
            // lblLocationImported
            // 
            this.lblLocationImported.AutoSize = true;
            this.lblLocationImported.Location = new System.Drawing.Point(192, 59);
            this.lblLocationImported.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationImported.Name = "lblLocationImported";
            this.lblLocationImported.Size = new System.Drawing.Size(0, 15);
            this.lblLocationImported.TabIndex = 21;
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Location = new System.Drawing.Point(511, 59);
            this.labelMobile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(0, 15);
            this.labelMobile.TabIndex = 27;
            // 
            // lblFullNameImported
            // 
            this.lblFullNameImported.AutoSize = true;
            this.lblFullNameImported.Location = new System.Drawing.Point(137, 14);
            this.lblFullNameImported.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullNameImported.Name = "lblFullNameImported";
            this.lblFullNameImported.Size = new System.Drawing.Size(0, 15);
            this.lblFullNameImported.TabIndex = 22;
            // 
            // lblMobileImported
            // 
            this.lblMobileImported.AutoSize = true;
            this.lblMobileImported.Location = new System.Drawing.Point(444, 59);
            this.lblMobileImported.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMobileImported.Name = "lblMobileImported";
            this.lblMobileImported.Size = new System.Drawing.Size(48, 15);
            this.lblMobileImported.TabIndex = 26;
            this.lblMobileImported.Text = "Mobiel:";
            this.lblMobileImported.Visible = false;
            // 
            // lblAdresImported
            // 
            this.lblAdresImported.AutoSize = true;
            this.lblAdresImported.Location = new System.Drawing.Point(137, 37);
            this.lblAdresImported.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresImported.Name = "lblAdresImported";
            this.lblAdresImported.Size = new System.Drawing.Size(0, 15);
            this.lblAdresImported.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(444, 37);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 15);
            this.label20.TabIndex = 25;
            this.label20.Text = "Telefoon:";
            this.label20.Visible = false;
            // 
            // lblPostodeImported
            // 
            this.lblPostodeImported.AutoSize = true;
            this.lblPostodeImported.Location = new System.Drawing.Point(137, 59);
            this.lblPostodeImported.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostodeImported.Name = "lblPostodeImported";
            this.lblPostodeImported.Size = new System.Drawing.Size(0, 15);
            this.lblPostodeImported.TabIndex = 24;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(941, 477);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.lblPhoneNumberImported.ResumeLayout(false);
            this.lblPhoneNumberImported.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelPhoneSkipped;
        private System.Windows.Forms.Label labelMobileSkipped;
        private System.Windows.Forms.Label lblMobileNumberSkipped;
        private System.Windows.Forms.Label lblPhoneNumberSkipped;
        private System.Windows.Forms.Label lblPostcodeSkipped;
        private System.Windows.Forms.Label lblAdresSkipped;
        private System.Windows.Forms.Label lblFullNameSkipped;
        private System.Windows.Forms.Label lblLocationSkipped;
        private System.Windows.Forms.Label lblEmailAdresSkipped;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreviousSkipped;
        private System.Windows.Forms.Button btnNextSkipped;
        private System.Windows.Forms.Label labelEmailSkipped;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage lblPhoneNumberImported;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPreviousImported;
        private System.Windows.Forms.Button btnNextImported;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label lblEmailAdresImported;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label lblLocationImported;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label lblFullNameImported;
        private System.Windows.Forms.Label lblMobileImported;
        private System.Windows.Forms.Label lblAdresImported;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblPostodeImported;
        private System.Windows.Forms.Label lblCounterSkipped;
        private System.Windows.Forms.Label lblCounterImported;
        private System.Windows.Forms.BindingSource importerBindingSource;
        private System.Windows.Forms.BindingSource importerBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

