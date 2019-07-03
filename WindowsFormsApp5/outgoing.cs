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


namespace WindowsFormsApp5
{
    public partial class outgoing : UserControl
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public outgoing()
        {
            InitializeComponent();
            Grid();
        }
        private void Grid()
        {
            MySqlConnection con = new MySqlConnection(conn);

            con.Open();
            MySqlDataAdapter gr = new MySqlDataAdapter();
            string cmd = "select studenti.codstudent,studenti.facultateura,studenti.nume,studenti.prenume from studenti,plecari where plecari.razgandit = 0 and studenti.codstudent = plecari.codstudent";
            gr.SelectCommand = new MySqlCommand(cmd, con);
            DataTable studenti = new DataTable();
            gr.Fill(studenti);
            BindingSource bs = new BindingSource();
            bs.DataSource = studenti;
            gridout.DataSource = bs;
            con.Close();


        }

        public int id_cod;
        private void gridout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_cod = Convert.ToInt32(gridout.Rows[e.RowIndex].Cells["codstudent"].Value.ToString());
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();

            con.Open();


            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.CommandText = "select studenti.`codstudent`,studenti.`facultateura`,studenti.`nume`,studenti.`prenume`,studenti.`datanasterii`," +
                "studenti.`telefon`,studenti.`email`,studenti.`adresa`,studenti.`anstudiu`,studenti.`cnp`,studenti.`codinscriere`,studenti.`codevaluare`," +
                "studenti.`outgoing`, studenti.contbancar,evaluare.medie as 'evaluare', inscrieri.medie as 'inscriere', plecari.dataplecare,programestudii.semestru,programestudii.denumire as 'Program', facultati.denumire as 'FACULTATI'," +
                " universitati.denumire as 'Universitate',universitati.tara from studenti  inner join evaluare on studenti.codevaluare = evaluare.codevaluare" +
                " inner join inscrieri on studenti.codinscriere = inscrieri.codinscriere inner join plecari on studenti.codstudent = plecari.codstudent inner join programestudii on plecari.codprogramstudii = programestudii.codprogramstudii" +
                " inner join facultati on facultati.codfacultate = programestudii.codfacultate inner join universitati on facultati.coduniversitate = universitati.coduniversitate ";
            cmd.Parameters.AddWithValue("@cod", id_cod);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                label32.Text = dr["nume"].ToString() + " " + dr["prenume"].ToString();

                label21.Text = dr["facultateura"].ToString();
                label14.Text = dr["anstudiu"].ToString();

                label20.Text = dr["evaluare"].ToString();
                label19.Text = dr["inscriere"].ToString();
                label31.Text = dr["Universitate"].ToString();
                label24.Text = dr["FACULTATI"].ToString();
                label33.Text = dr["Program"].ToString();
                label23.Text = dr["semestru"].ToString();
                label22.Text = dr["tara"].ToString();
                label40.Text = dr["telefon"].ToString();
                label40.Text = dr["telefon"].ToString();


                label34.Text = dr["contbancar"].ToString();
                label36.Text = dr["cnp"].ToString();
                label39.Text = dr["adresa"].ToString();
                label38.Text = dr["dataplecare"].ToString();

            }

            panel1.Visible = true;
            panel1.BringToFront();
        } 

            private void adaugabtn_Click(object sender, EventArgs e)
        {
            applicationpanel.Visible = false;
          
        }

        private void razganditbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update  plecari set razgandit=1 where codstudent=@cod";
            con.Open();


            cmd.Parameters.AddWithValue("@cod", id_cod);
            
            cmd.ExecuteNonQuery();
            con.Close();


            panel1.Visible = false;
            Grid();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Grid();
            panel1.Visible = false;

        }
    }
}
