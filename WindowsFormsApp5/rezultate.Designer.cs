namespace WindowsFormsApp5
{
    partial class rezultate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.applicationpanel = new System.Windows.Forms.Panel();
            this.rezultategrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.notebtm = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.dropprogram = new Bunifu.Framework.UI.BunifuDropdown();
            this.dropfac = new Bunifu.Framework.UI.BunifuDropdown();
            this.dropuniv = new Bunifu.Framework.UI.BunifuDropdown();
            this.datan = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addpr = new System.Windows.Forms.Button();
            this.adresa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cnp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.contb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.telefon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.tara = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.semestru = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.student = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.oras = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.applicationpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezultategrid)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationpanel
            // 
            this.applicationpanel.BackColor = System.Drawing.Color.Black;
            this.applicationpanel.Controls.Add(this.notebtm);
            this.applicationpanel.Controls.Add(this.rezultategrid);
            this.applicationpanel.Location = new System.Drawing.Point(0, 0);
            this.applicationpanel.Name = "applicationpanel";
            this.applicationpanel.Size = new System.Drawing.Size(1100, 606);
            this.applicationpanel.TabIndex = 265;
            this.applicationpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.applicationpanel_Paint);
            // 
            // rezultategrid
            // 
            this.rezultategrid.AllowUserToAddRows = false;
            this.rezultategrid.AllowUserToDeleteRows = false;
            this.rezultategrid.AllowUserToResizeColumns = false;
            this.rezultategrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.rezultategrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rezultategrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rezultategrid.BackgroundColor = System.Drawing.Color.Black;
            this.rezultategrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rezultategrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.rezultategrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rezultategrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rezultategrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezultategrid.ColumnHeadersVisible = false;
            this.rezultategrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rezultategrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.rezultategrid.DoubleBuffered = true;
            this.rezultategrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rezultategrid.EnableHeadersVisualStyles = false;
            this.rezultategrid.GridColor = System.Drawing.Color.Black;
            this.rezultategrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.rezultategrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.rezultategrid.Location = new System.Drawing.Point(15, 87);
            this.rezultategrid.MultiSelect = false;
            this.rezultategrid.Name = "rezultategrid";
            this.rezultategrid.ReadOnly = true;
            this.rezultategrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rezultategrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.rezultategrid.RowHeadersVisible = false;
            this.rezultategrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Teal;
            this.rezultategrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.rezultategrid.RowTemplate.DividerHeight = 1;
            this.rezultategrid.RowTemplate.Height = 44;
            this.rezultategrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rezultategrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rezultategrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rezultategrid.ShowEditingIcon = false;
            this.rezultategrid.Size = new System.Drawing.Size(1071, 432);
            this.rezultategrid.TabIndex = 264;
            this.rezultategrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rezultategrid_CellContentClick);
            // 
            // notebtm
            // 
            this.notebtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.notebtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notebtm.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notebtm.Location = new System.Drawing.Point(1362, 561);
            this.notebtm.Name = "notebtm";
            this.notebtm.Size = new System.Drawing.Size(106, 37);
            this.notebtm.TabIndex = 262;
            this.notebtm.Text = "Note";
            this.notebtm.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.oras);
            this.panel.Controls.Add(this.dropprogram);
            this.panel.Controls.Add(this.dropfac);
            this.panel.Controls.Add(this.dropuniv);
            this.panel.Controls.Add(this.datan);
            this.panel.Controls.Add(this.dateTimePicker1);
            this.panel.Controls.Add(this.addpr);
            this.panel.Controls.Add(this.adresa);
            this.panel.Controls.Add(this.cnp);
            this.panel.Controls.Add(this.contb);
            this.panel.Controls.Add(this.email);
            this.panel.Controls.Add(this.telefon);
            this.panel.Controls.Add(this.label41);
            this.panel.Controls.Add(this.label42);
            this.panel.Controls.Add(this.label43);
            this.panel.Controls.Add(this.label44);
            this.panel.Controls.Add(this.label45);
            this.panel.Controls.Add(this.label46);
            this.panel.Controls.Add(this.label47);
            this.panel.Controls.Add(this.tara);
            this.panel.Controls.Add(this.semestru);
            this.panel.Controls.Add(this.student);
            this.panel.Controls.Add(this.label25);
            this.panel.Controls.Add(this.label26);
            this.panel.Controls.Add(this.label27);
            this.panel.Controls.Add(this.label28);
            this.panel.Controls.Add(this.label29);
            this.panel.Controls.Add(this.label30);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1100, 606);
            this.panel.TabIndex = 266;
            this.panel.Visible = false;
            // 
            // dropprogram
            // 
            this.dropprogram.BackColor = System.Drawing.Color.Transparent;
            this.dropprogram.BorderRadius = 3;
            this.dropprogram.DisabledColor = System.Drawing.Color.Gray;
            this.dropprogram.ForeColor = System.Drawing.Color.White;
            this.dropprogram.Items = new string[0];
            this.dropprogram.Location = new System.Drawing.Point(829, 192);
            this.dropprogram.Name = "dropprogram";
            this.dropprogram.NomalColor = System.Drawing.Color.Black;
            this.dropprogram.onHoverColor = System.Drawing.Color.Red;
            this.dropprogram.selectedIndex = -1;
            this.dropprogram.Size = new System.Drawing.Size(217, 35);
            this.dropprogram.TabIndex = 287;
            this.dropprogram.onItemSelected += new System.EventHandler(this.dropprogram_onItemSelected);
            // 
            // dropfac
            // 
            this.dropfac.BackColor = System.Drawing.Color.Transparent;
            this.dropfac.BorderRadius = 3;
            this.dropfac.DisabledColor = System.Drawing.Color.Gray;
            this.dropfac.ForeColor = System.Drawing.Color.White;
            this.dropfac.Items = new string[0];
            this.dropfac.Location = new System.Drawing.Point(829, 111);
            this.dropfac.Name = "dropfac";
            this.dropfac.NomalColor = System.Drawing.Color.Black;
            this.dropfac.onHoverColor = System.Drawing.Color.Red;
            this.dropfac.selectedIndex = -1;
            this.dropfac.Size = new System.Drawing.Size(217, 35);
            this.dropfac.TabIndex = 286;
            this.dropfac.onItemSelected += new System.EventHandler(this.dropfac_onItemSelected);
            // 
            // dropuniv
            // 
            this.dropuniv.BackColor = System.Drawing.Color.Transparent;
            this.dropuniv.BorderRadius = 3;
            this.dropuniv.DisabledColor = System.Drawing.Color.Gray;
            this.dropuniv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropuniv.ForeColor = System.Drawing.Color.White;
            this.dropuniv.Items = new string[0];
            this.dropuniv.Location = new System.Drawing.Point(829, 27);
            this.dropuniv.Name = "dropuniv";
            this.dropuniv.NomalColor = System.Drawing.Color.Black;
            this.dropuniv.onHoverColor = System.Drawing.Color.Red;
            this.dropuniv.selectedIndex = -1;
            this.dropuniv.Size = new System.Drawing.Size(217, 35);
            this.dropuniv.TabIndex = 285;
            this.dropuniv.onItemSelected += new System.EventHandler(this.dropuniv_onItemSelected);
            // 
            // datan
            // 
            this.datan.Location = new System.Drawing.Point(221, 380);
            this.datan.Name = "datan";
            this.datan.Size = new System.Drawing.Size(200, 20);
            this.datan.TabIndex = 283;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(829, 450);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 282;
            // 
            // addpr
            // 
            this.addpr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addpr.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpr.Location = new System.Drawing.Point(982, 541);
            this.addpr.Name = "addpr";
            this.addpr.Size = new System.Drawing.Size(106, 37);
            this.addpr.TabIndex = 281;
            this.addpr.Text = "Adauga";
            this.addpr.UseVisualStyleBackColor = false;
            this.addpr.Click += new System.EventHandler(this.addpr_Click);
            // 
            // adresa
            // 
            this.adresa.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.adresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adresa.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adresa.HintText = "";
            this.adresa.isPassword = false;
            this.adresa.LineFocusedColor = System.Drawing.Color.Red;
            this.adresa.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adresa.LineMouseHoverColor = System.Drawing.Color.Red;
            this.adresa.LineThickness = 3;
            this.adresa.Location = new System.Drawing.Point(176, 434);
            this.adresa.Margin = new System.Windows.Forms.Padding(4);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(293, 33);
            this.adresa.TabIndex = 279;
            this.adresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cnp
            // 
            this.cnp.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.cnp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cnp.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cnp.HintText = "";
            this.cnp.isPassword = false;
            this.cnp.LineFocusedColor = System.Drawing.Color.Red;
            this.cnp.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cnp.LineMouseHoverColor = System.Drawing.Color.Red;
            this.cnp.LineThickness = 3;
            this.cnp.Location = new System.Drawing.Point(176, 291);
            this.cnp.Margin = new System.Windows.Forms.Padding(4);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(293, 33);
            this.cnp.TabIndex = 277;
            this.cnp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // contb
            // 
            this.contb.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.contb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.contb.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.contb.HintText = "";
            this.contb.isPassword = false;
            this.contb.LineFocusedColor = System.Drawing.Color.Red;
            this.contb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.contb.LineMouseHoverColor = System.Drawing.Color.Red;
            this.contb.LineThickness = 3;
            this.contb.Location = new System.Drawing.Point(176, 224);
            this.contb.Margin = new System.Windows.Forms.Padding(4);
            this.contb.Name = "contb";
            this.contb.Size = new System.Drawing.Size(293, 33);
            this.contb.TabIndex = 276;
            this.contb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // email
            // 
            this.email.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.email.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.email.HintText = "";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.Red;
            this.email.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.email.LineMouseHoverColor = System.Drawing.Color.Red;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(176, 158);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(293, 33);
            this.email.TabIndex = 275;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // telefon
            // 
            this.telefon.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.telefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telefon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.telefon.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.telefon.HintText = "";
            this.telefon.isPassword = false;
            this.telefon.LineFocusedColor = System.Drawing.Color.Red;
            this.telefon.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.telefon.LineMouseHoverColor = System.Drawing.Color.Red;
            this.telefon.LineThickness = 3;
            this.telefon.Location = new System.Drawing.Point(176, 77);
            this.telefon.Margin = new System.Windows.Forms.Padding(4);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(293, 33);
            this.telefon.TabIndex = 274;
            this.telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label41.Location = new System.Drawing.Point(2, 224);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(141, 22);
            this.label41.TabIndex = 273;
            this.label41.Text = "Cont bancar :";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label42.Location = new System.Drawing.Point(35, 158);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(74, 22);
            this.label42.TabIndex = 272;
            this.label42.Text = "Email  :";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label43.Location = new System.Drawing.Point(35, 88);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(89, 22);
            this.label43.TabIndex = 271;
            this.label43.Text = "Telefon  :";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label44.Location = new System.Drawing.Point(2, 378);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(144, 22);
            this.label44.TabIndex = 269;
            this.label44.Text = "Data nasterii  :";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label45.Location = new System.Drawing.Point(35, 280);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(65, 22);
            this.label45.TabIndex = 268;
            this.label45.Text = "CNP  :";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label46.Location = new System.Drawing.Point(19, 445);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(90, 22);
            this.label46.TabIndex = 270;
            this.label46.Text = "Adresa  :";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label47.Location = new System.Drawing.Point(562, 450);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(141, 22);
            this.label47.TabIndex = 267;
            this.label47.Text = "Data plecarii :";
            // 
            // tara
            // 
            this.tara.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tara.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tara.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tara.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tara.HintText = "";
            this.tara.isPassword = false;
            this.tara.LineFocusedColor = System.Drawing.Color.Red;
            this.tara.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tara.LineMouseHoverColor = System.Drawing.Color.Red;
            this.tara.LineThickness = 3;
            this.tara.Location = new System.Drawing.Point(791, 396);
            this.tara.Margin = new System.Windows.Forms.Padding(4);
            this.tara.Name = "tara";
            this.tara.Size = new System.Drawing.Size(293, 33);
            this.tara.TabIndex = 18;
            this.tara.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // semestru
            // 
            this.semestru.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.semestru.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.semestru.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.semestru.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.semestru.HintText = "";
            this.semestru.isPassword = false;
            this.semestru.LineFocusedColor = System.Drawing.Color.Red;
            this.semestru.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.semestru.LineMouseHoverColor = System.Drawing.Color.Red;
            this.semestru.LineThickness = 3;
            this.semestru.Location = new System.Drawing.Point(791, 281);
            this.semestru.Margin = new System.Windows.Forms.Padding(4);
            this.semestru.Name = "semestru";
            this.semestru.Size = new System.Drawing.Size(293, 33);
            this.semestru.TabIndex = 17;
            this.semestru.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // student
            // 
            this.student.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.student.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.student.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.student.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.student.HintText = "";
            this.student.isPassword = false;
            this.student.LineFocusedColor = System.Drawing.Color.Red;
            this.student.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.student.LineMouseHoverColor = System.Drawing.Color.Red;
            this.student.LineThickness = 3;
            this.student.Location = new System.Drawing.Point(176, 16);
            this.student.Margin = new System.Windows.Forms.Padding(4);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(293, 33);
            this.student.TabIndex = 13;
            this.student.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label25.Location = new System.Drawing.Point(562, 368);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 22);
            this.label25.TabIndex = 11;
            this.label25.Text = "Tara :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label26.Location = new System.Drawing.Point(562, 281);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(107, 22);
            this.label26.TabIndex = 10;
            this.label26.Text = "Semestrul :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label27.Location = new System.Drawing.Point(562, 133);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(123, 22);
            this.label27.TabIndex = 8;
            this.label27.Text = "Facultatea :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label28.Location = new System.Drawing.Point(550, 40);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(209, 22);
            this.label28.TabIndex = 7;
            this.label28.Text = "Universitatea aleasa :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label29.Location = new System.Drawing.Point(31, 27);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(93, 22);
            this.label29.TabIndex = 6;
            this.label29.Text = "Student :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label30.Location = new System.Drawing.Point(562, 205);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(188, 22);
            this.label30.TabIndex = 9;
            this.label30.Text = "Program de studiu :";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // oras
            // 
            this.oras.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.oras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.oras.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.oras.HintText = "";
            this.oras.isPassword = false;
            this.oras.LineFocusedColor = System.Drawing.Color.Red;
            this.oras.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.oras.LineMouseHoverColor = System.Drawing.Color.Red;
            this.oras.LineThickness = 3;
            this.oras.Location = new System.Drawing.Point(791, 337);
            this.oras.Margin = new System.Windows.Forms.Padding(4);
            this.oras.Name = "oras";
            this.oras.Size = new System.Drawing.Size(293, 33);
            this.oras.TabIndex = 288;
            this.oras.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(385, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 289;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(434, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 289;
            this.label2.Text = "label1";
            this.label2.Visible = false;
            // 
            // rezultate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.applicationpanel);
            this.Name = "rezultate";
            this.Size = new System.Drawing.Size(1323, 606);
            this.applicationpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rezultategrid)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel applicationpanel;
        private System.Windows.Forms.Button notebtm;
        private Bunifu.Framework.UI.BunifuCustomDataGrid rezultategrid;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button addpr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adresa;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cnp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contb;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tara;
        private Bunifu.Framework.UI.BunifuMaterialTextbox semestru;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox telefon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox student;
        private System.Windows.Forms.DateTimePicker datan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuDropdown dropprogram;
        private Bunifu.Framework.UI.BunifuDropdown dropfac;
        private Bunifu.Framework.UI.BunifuDropdown dropuniv;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox oras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
