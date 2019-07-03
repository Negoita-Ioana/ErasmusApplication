namespace WindowsFormsApp5
{
    partial class rapoarte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.raport1 = new System.Windows.Forms.Panel();
            this.noteengraport = new System.Windows.Forms.Button();
            this.gridraport1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.raport2 = new System.Windows.Forms.Button();
            this.raport3 = new System.Windows.Forms.Button();
            this.raport4 = new System.Windows.Forms.Button();
            this.raport5 = new System.Windows.Forms.Button();
            this.raportuniv = new Bunifu.Framework.UI.BunifuDropdown();
            this.raport1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridraport1)).BeginInit();
            this.SuspendLayout();
            // 
            // raport1
            // 
            this.raport1.BackColor = System.Drawing.Color.Black;
            this.raport1.Controls.Add(this.raportuniv);
            this.raport1.Controls.Add(this.raport5);
            this.raport1.Controls.Add(this.raport4);
            this.raport1.Controls.Add(this.raport3);
            this.raport1.Controls.Add(this.raport2);
            this.raport1.Controls.Add(this.gridraport1);
            this.raport1.Controls.Add(this.noteengraport);
            this.raport1.Location = new System.Drawing.Point(0, 0);
            this.raport1.Name = "raport1";
            this.raport1.Size = new System.Drawing.Size(1100, 606);
            this.raport1.TabIndex = 0;
            // 
            // noteengraport
            // 
            this.noteengraport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.noteengraport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteengraport.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteengraport.Location = new System.Drawing.Point(28, 21);
            this.noteengraport.Name = "noteengraport";
            this.noteengraport.Size = new System.Drawing.Size(163, 37);
            this.noteengraport.TabIndex = 262;
            this.noteengraport.Text = "Raport note engleza";
            this.noteengraport.UseVisualStyleBackColor = false;
            this.noteengraport.Click += new System.EventHandler(this.noteengraport_Click);
            // 
            // gridraport1
            // 
            this.gridraport1.AllowUserToAddRows = false;
            this.gridraport1.AllowUserToDeleteRows = false;
            this.gridraport1.AllowUserToResizeColumns = false;
            this.gridraport1.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            this.gridraport1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gridraport1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridraport1.BackgroundColor = System.Drawing.Color.Black;
            this.gridraport1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridraport1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridraport1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridraport1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridraport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridraport1.ColumnHeadersVisible = false;
            this.gridraport1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridraport1.DefaultCellStyle = dataGridViewCellStyle13;
            this.gridraport1.DoubleBuffered = true;
            this.gridraport1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridraport1.EnableHeadersVisualStyles = false;
            this.gridraport1.GridColor = System.Drawing.Color.Black;
            this.gridraport1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridraport1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.gridraport1.Location = new System.Drawing.Point(3, 495);
            this.gridraport1.MultiSelect = false;
            this.gridraport1.Name = "gridraport1";
            this.gridraport1.ReadOnly = true;
            this.gridraport1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridraport1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gridraport1.RowHeadersVisible = false;
            this.gridraport1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Teal;
            this.gridraport1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gridraport1.RowTemplate.DividerHeight = 1;
            this.gridraport1.RowTemplate.Height = 44;
            this.gridraport1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridraport1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridraport1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridraport1.ShowEditingIcon = false;
            this.gridraport1.Size = new System.Drawing.Size(175, 108);
            this.gridraport1.TabIndex = 264;
            this.gridraport1.Visible = false;
            // 
            // raport2
            // 
            this.raport2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.raport2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raport2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raport2.Location = new System.Drawing.Point(289, 21);
            this.raport2.Name = "raport2";
            this.raport2.Size = new System.Drawing.Size(163, 37);
            this.raport2.TabIndex = 265;
            this.raport2.Text = "Raport medie totala";
            this.raport2.UseVisualStyleBackColor = false;
            this.raport2.Click += new System.EventHandler(this.button1_Click);
            // 
            // raport3
            // 
            this.raport3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.raport3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raport3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raport3.Location = new System.Drawing.Point(529, 21);
            this.raport3.Name = "raport3";
            this.raport3.Size = new System.Drawing.Size(219, 37);
            this.raport3.TabIndex = 266;
            this.raport3.Text = "Raport Universitati partenere";
            this.raport3.UseVisualStyleBackColor = false;
            this.raport3.Click += new System.EventHandler(this.raport3_Click);
            // 
            // raport4
            // 
            this.raport4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.raport4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raport4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raport4.Location = new System.Drawing.Point(852, 21);
            this.raport4.Name = "raport4";
            this.raport4.Size = new System.Drawing.Size(182, 37);
            this.raport4.TabIndex = 267;
            this.raport4.Text = "Raport Studenti inscrisi";
            this.raport4.UseVisualStyleBackColor = false;
            // 
            // raport5
            // 
            this.raport5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.raport5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raport5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raport5.Location = new System.Drawing.Point(18, 103);
            this.raport5.Name = "raport5";
            this.raport5.Size = new System.Drawing.Size(182, 37);
            this.raport5.TabIndex = 268;
            this.raport5.Text = "Raport Studenti outgoing";
            this.raport5.UseVisualStyleBackColor = false;
            // 
            // raportuniv
            // 
            this.raportuniv.BackColor = System.Drawing.Color.Black;
            this.raportuniv.BorderRadius = 3;
            this.raportuniv.DisabledColor = System.Drawing.Color.Black;
            this.raportuniv.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raportuniv.ForeColor = System.Drawing.Color.Cyan;
            this.raportuniv.Items = new string[0];
            this.raportuniv.Location = new System.Drawing.Point(696, 148);
            this.raportuniv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.raportuniv.Name = "raportuniv";
            this.raportuniv.NomalColor = System.Drawing.Color.Black;
            this.raportuniv.onHoverColor = System.Drawing.Color.Black;
            this.raportuniv.selectedIndex = -1;
            this.raportuniv.Size = new System.Drawing.Size(228, 33);
            this.raportuniv.TabIndex = 300;
            // 
            // rapoarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.raport1);
            this.Name = "rapoarte";
            this.Size = new System.Drawing.Size(1211, 691);
            this.Load += new System.EventHandler(this.rapoarte_Load);
            this.raport1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridraport1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel raport1;
        private System.Windows.Forms.Button noteengraport;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridraport1;
        private System.Windows.Forms.Button raport2;
        private System.Windows.Forms.Button raport5;
        private System.Windows.Forms.Button raport4;
        private System.Windows.Forms.Button raport3;
        private Bunifu.Framework.UI.BunifuDropdown raportuniv;
    }
}
