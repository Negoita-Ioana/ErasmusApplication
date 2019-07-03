using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class statistici : UserControl
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public statistici()
        {
            InitializeComponent();
        }

        private void Grid()
        {
            MySqlConnection con = new MySqlConnection(conn);

            con.Open();
            MySqlDataAdapter gr = new MySqlDataAdapter();
            string cmd = "select * from studenti";
            gr.SelectCommand = new MySqlCommand(cmd, con);
            DataTable studenti = new DataTable();
            gr.Fill(studenti);
            BindingSource bs = new BindingSource();
            bs.DataSource = studenti;
            grid1.DataSource = bs;
            con.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Series1");
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.Series["Series1"].IsValueShownAsLabel = true;

            chart2.Series.Clear();
            chart2.Series.Add("Series2");
            chart2.Series["Series2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            chart2.Series["Series2"].IsValueShownAsLabel = true;
            chart2.Series["Series2"].IsValueShownAsLabel = true;

            MySqlConnection con = new MySqlConnection(conn);
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd2 = new MySqlCommand();
            MySqlCommand cmd3 = new MySqlCommand();
            MySqlCommand cmd4 = new MySqlCommand();
            MySqlCommand cmd5 = new MySqlCommand();
            MySqlCommand cmd6 = new MySqlCommand();
            MySqlCommand cmd7 = new MySqlCommand();
            MySqlCommand cmd8 = new MySqlCommand();
            MySqlCommand cmd9 = new MySqlCommand();
            MySqlCommand cmd10 = new MySqlCommand();
            MySqlCommand cmd11 = new MySqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select count(*) from inscrieri where facultateura='IM' ";
            cmd.ExecuteNonQuery();

            int IM = Convert.ToInt32(cmd.ExecuteScalar());


            cmd2.Connection = con;
            cmd2.CommandText = "select count(*) from inscrieri where facultateura='DREPT' ";
            cmd2.ExecuteNonQuery();

            int DREPT = Convert.ToInt32(cmd2.ExecuteScalar());

            cmd3.Connection = con;
            cmd3.CommandText = "select count(*) from inscrieri where facultateura='MM' ";
            cmd3.ExecuteNonQuery();

            int MM = Convert.ToInt32(cmd3.ExecuteScalar());

            cmd4.Connection = con;
            cmd4.CommandText = "select count(*) from inscrieri where facultateura='SIEE' ";
            cmd4.ExecuteNonQuery();

            int SIEE = Convert.ToInt32(cmd4.ExecuteScalar());

            cmd5.Connection = con;
            cmd5.CommandText = "select count(*) from inscrieri where facultateura='RCFBII' ";
            cmd5.ExecuteNonQuery();

            int RCFBII = Convert.ToInt32(cmd5.ExecuteScalar());

            cmd6.Connection = con;
            cmd6.CommandText = "select count(*) from inscrieri where facultateura='ETII' ";
            cmd6.ExecuteNonQuery();

            int ETII = Convert.ToInt32(cmd6.ExecuteScalar());

            cmd7.Connection = con;
            cmd7.CommandText = "select count(*) from inscrieri where facultateura='EFSK' ";
            cmd7.ExecuteNonQuery();

            int EFSK = Convert.ToInt32(cmd7.ExecuteScalar());

            cmd8.Connection = con;
            cmd8.CommandText = "select count(*) from universitati where tara='Anglia' ";
            cmd8.ExecuteNonQuery();

            int Anglia = Convert.ToInt32(cmd8.ExecuteScalar());

            cmd9.Connection = con;
            cmd9.CommandText = "select count(*) from universitati where tara='Olanda' ";
            cmd9.ExecuteNonQuery();

            int Olanda = Convert.ToInt32(cmd9.ExecuteScalar());

            cmd10.Connection = con;
            cmd10.CommandText = "select count(*) from universitati where tara='Franta' ";
            cmd10.ExecuteNonQuery();

            int Franta = Convert.ToInt32(cmd10.ExecuteScalar());

            cmd11.Connection = con;
            cmd11.CommandText = "select count(*) from universitati where tara='Spania' ";
            cmd11.ExecuteNonQuery();

            int Spania = Convert.ToInt32(cmd11.ExecuteScalar());

            con.Close();
            chart1.Series["Series1"].Points.AddXY("IM", IM);
            chart1.Series["Series1"].Points.AddXY("Drept", DREPT);
            chart1.Series["Series1"].Points.AddXY("MM", MM);
            chart1.Series["Series1"].Points.AddXY("Siee", SIEE);
            chart1.Series["Series1"].Points.AddXY("RCFBII", RCFBII);
            chart1.Series["Series1"].Points.AddXY("ETII", ETII);
            chart1.Series["Series1"].Points.AddXY("EFSK", EFSK);

            chart2.Series["Series2"].Points.AddXY("Anglia", Anglia);
            chart2.Series["Series2"].Points.AddXY("Olanda", Olanda);
            chart2.Series["Series2"].Points.AddXY("Franta", Franta);
            chart2.Series["Series2"].Points.AddXY("Spania", Spania);
            
        }
    }
}
