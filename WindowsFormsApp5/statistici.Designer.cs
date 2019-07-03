namespace WindowsFormsApp5
{
    partial class statistici
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chart2);
            this.panel1.Controls.Add(this.chart4);
            this.panel1.Controls.Add(this.grid1);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 589);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Black;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea6.BackColor = System.Drawing.Color.Black;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.Black;
            legend6.BorderColor = System.Drawing.Color.Black;
            legend6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend6.ForeColor = System.Drawing.Color.Red;
            legend6.InterlacedRowsColor = System.Drawing.Color.Black;
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            legend6.TitleBackColor = System.Drawing.Color.Black;
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(3, 29);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series6.BackImageTransparentColor = System.Drawing.Color.Black;
            series6.BackSecondaryColor = System.Drawing.Color.Black;
            series6.BorderColor = System.Drawing.Color.Black;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Color = System.Drawing.Color.Black;
            series6.LabelBackColor = System.Drawing.Color.Black;
            series6.LabelBorderColor = System.Drawing.Color.Black;
            series6.Legend = "Legend1";
            series6.MarkerBorderColor = System.Drawing.Color.Black;
            series6.MarkerColor = System.Drawing.Color.Black;
            series6.MarkerImageTransparentColor = System.Drawing.Color.Black;
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(464, 301);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // grid1
            // 
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(852, 370);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(242, 189);
            this.grid1.TabIndex = 3;
            this.grid1.Visible = false;
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.Black;
            this.chart4.BackSecondaryColor = System.Drawing.Color.Black;
            this.chart4.BorderlineColor = System.Drawing.Color.Black;
            chartArea5.BackColor = System.Drawing.Color.Black;
            chartArea5.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.Black;
            legend5.BorderColor = System.Drawing.Color.Black;
            legend5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend5.ForeColor = System.Drawing.Color.Red;
            legend5.InterlacedRowsColor = System.Drawing.Color.Black;
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            legend5.TitleBackColor = System.Drawing.Color.Black;
            this.chart4.Legends.Add(legend5);
            this.chart4.Location = new System.Drawing.Point(340, 317);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series5.BackImageTransparentColor = System.Drawing.Color.Black;
            series5.BackSecondaryColor = System.Drawing.Color.Black;
            series5.BorderColor = System.Drawing.Color.Black;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Color = System.Drawing.Color.Black;
            series5.LabelBackColor = System.Drawing.Color.Black;
            series5.LabelBorderColor = System.Drawing.Color.Black;
            series5.Legend = "Legend1";
            series5.MarkerBorderColor = System.Drawing.Color.Black;
            series5.MarkerColor = System.Drawing.Color.Black;
            series5.MarkerImageTransparentColor = System.Drawing.Color.Black;
            series5.Name = "Series1";
            this.chart4.Series.Add(series5);
            this.chart4.Size = new System.Drawing.Size(471, 301);
            this.chart4.TabIndex = 4;
            this.chart4.Text = "chart4";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Black;
            this.chart2.BackSecondaryColor = System.Drawing.Color.Black;
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Black;
            legend4.BorderColor = System.Drawing.Color.Black;
            legend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.ForeColor = System.Drawing.Color.Red;
            legend4.InterlacedRowsColor = System.Drawing.Color.Black;
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            legend4.TitleBackColor = System.Drawing.Color.Black;
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(572, 29);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.BackImageTransparentColor = System.Drawing.Color.Black;
            series4.BackSecondaryColor = System.Drawing.Color.Black;
            series4.BorderColor = System.Drawing.Color.Black;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Color = System.Drawing.Color.Black;
            series4.LabelBackColor = System.Drawing.Color.Black;
            series4.LabelBorderColor = System.Drawing.Color.Black;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.Black;
            series4.MarkerColor = System.Drawing.Color.Black;
            series4.MarkerImageTransparentColor = System.Drawing.Color.Black;
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(464, 301);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numarul studentiilor inscrisi pe facultati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(568, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numarul universitatiilor partenere din totalitatea tarirol\r\n";
            // 
            // statistici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "statistici";
            this.Size = new System.Drawing.Size(1100, 592);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
