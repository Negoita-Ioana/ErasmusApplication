using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class rezultate : UserControl

    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public rezultate()
        {
            InitializeComponent();
            Grid();
            LstUniv = new List<int>();
        }

        private void Grid()
        {
            MySqlConnection con = new MySqlConnection(conn);

            con.Open();
            MySqlDataAdapter gr = new MySqlDataAdapter();
            string cmd = "select inscrieri.codinscriere as cod, inscrieri.nume as nume, inscrieri.prenume as prenume, evaluare.notaengleza as nota, evaluare.notainterviu as notaa, evaluare.medie as medie from inscrieri inner join evaluare on evaluare.codinscriere = inscrieri.codinscriere where evaluare.validare=0 order by evaluare.medie desc limit 0,8"; 
            gr.SelectCommand = new MySqlCommand(cmd, con);
            DataTable inscrieri = new DataTable();
            gr.Fill(inscrieri);
            BindingSource bs = new BindingSource();
            bs.DataSource = inscrieri;
            rezultategrid.DataSource = bs;
            con.Close();


        }
        List<int> LstUniv;
        public string nume, prenume;
        public int id_cod;
        private void rezultategrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_cod = Convert.ToInt32(rezultategrid.Rows[e.RowIndex].Cells["cod"].Value.ToString());
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            con.Open();


            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.CommandText = "select *   from inscrieri where codinscriere=@cod";
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
                student.Text = dr["nume"].ToString() + " " + dr["prenume"].ToString();
                telefon.Text = dr["telefon"].ToString();
                email.Text = dr["email"].ToString();
                label1.Text = dr["nume"].ToString();
                label2.Text= dr["prenume"].ToString();

                

            }

            
            MySqlCommand cmd2 = new MySqlCommand();

            cmd2.Connection = con;
            cmd2.Parameters.Clear();
            cmd2.CommandText = "select denumire , coduniversitate from universitati";
            cmd2.ExecuteNonQuery();

            DataTable dtt = new DataTable();
            DataTable dtt1 = new DataTable();
            MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd2);
            MySqlDataAdapter daa = new MySqlDataAdapter(cmd2);
            DataSet dss = new DataSet();
            daa1.Fill(dss);
            daa.Fill(dtt);

            foreach (DataRow dr in dtt.Rows)
            {
                LstUniv.Add(Convert.ToInt32(dr["coduniversitate"]));
                dropuniv.AddItem(dr["denumire"].ToString());
            }


            panel.Visible = true;
            panel.BringToFront();
        }

        private void addpr_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(conn);


            //adauga student


            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Parameters.Clear();
            cmd2.Connection = con;
            cmd2.CommandText = "insert into studenti (nume, prenume, telefon, email ,codevaluare, codinscriere,contbancar,cnp,adresa,datanasterii) values (@nume, @prenume, @telefon, @email , (select codevaluare from evaluare where codinscriere=@cod), @codinscriere,@contbancar,@cnp,@adresa,@datan)";
            cmd2.Parameters.AddWithValue("@nume", label1.Text);
            cmd2.Parameters.AddWithValue("@prenume", label2.Text);
            cmd2.Parameters.AddWithValue("@telefon", telefon.Text);
            cmd2.Parameters.AddWithValue("@email", email.Text);
            cmd2.Parameters.AddWithValue("@contbancar", contb.Text);
            cmd2.Parameters.AddWithValue("@cnp", cnp.Text);
            cmd2.Parameters.AddWithValue("@adresa", adresa.Text);

            cmd2.Parameters.AddWithValue("@datan", datan.Value.Date);


            cmd2.Parameters.AddWithValue("@cod", id_cod);
            cmd2.Parameters.AddWithValue("@codinscriere", id_cod);

            



            ///

            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.Clear();
            cmd.Connection = con;

            cmd.CommandText = "insert into plecari (codprogramstudii, codstudent, dataplecare) values ((select codprogramstudii from programestudii where denumire=@denumire), (select codstudent from studenti where nume=@nume and prenume=@prenume), @dataplecare)";
            cmd.Parameters.AddWithValue("@denumire", dropprogram.selectedValue);
            cmd.Parameters.AddWithValue("@nume", label1.Text);
            cmd.Parameters.AddWithValue("@prenume", label2.Text);
            cmd.Parameters.AddWithValue("@dataplecare", dateTimePicker1.Value.Date);
            



            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = con;
            cmd3.CommandText = "update  evaluare set validare=1 where codinscriere=@cod";
            cmd3.Parameters.AddWithValue("@cod", id_cod);


            con.Open();

            cmd2.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();

            con.Close();

            Grid();
            panel.Visible = false;

        }

        public int coduniv;
        private void dropuniv_onItemSelected(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conn);
           
            con.Open();
            MySqlCommand cmd2 = new MySqlCommand();

            cmd2.Connection = con;
            cmd2.Parameters.Clear();
            cmd2.CommandText = "select denumire ,tara, oras, coduniversitate from universitati where denumire=@coduniv";
            cmd2.Parameters.AddWithValue("@coduniv", dropuniv.selectedValue);
            cmd2.ExecuteNonQuery();

            DataTable dtt = new DataTable();
            DataTable dtt1 = new DataTable();
            MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd2);
            MySqlDataAdapter daa = new MySqlDataAdapter(cmd2);
            DataSet dss = new DataSet();
            daa1.Fill(dss);
            daa.Fill(dtt);

            foreach (DataRow dr in dtt.Rows)
            {
                
                coduniv=Convert.ToInt32(dr["coduniversitate"].ToString());
                oras.Text = dr["oras"].ToString();
                tara.Text = dr["tara"].ToString();
            }

            MySqlCommand cmd3 = new MySqlCommand();

            cmd3.Connection = con;
            cmd3.Parameters.Clear();
            cmd3.CommandText = "select denumire , codfacultate from facultati where coduniversitate=@coduniv";
            cmd3.Parameters.AddWithValue("@coduniv", coduniv);
            cmd3.ExecuteNonQuery();

            DataTable dttt = new DataTable();
           
            MySqlDataAdapter daaa1 = new MySqlDataAdapter(cmd3);
            MySqlDataAdapter daaa = new MySqlDataAdapter(cmd3);
            DataSet dsss = new DataSet();
            daaa1.Fill(dsss);
            daaa.Fill(dttt);

            foreach (DataRow dr in dttt.Rows)
            {
                
                dropfac.AddItem(dr["denumire"].ToString());
            }

            con.Close();
        }

        public int codfac;
        private void dropfac_onItemSelected(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conn);

            con.Open();
            MySqlCommand cmd2 = new MySqlCommand();

            cmd2.Connection = con;
            cmd2.Parameters.Clear();
            cmd2.CommandText = "select denumire , codfacultate from facultati where denumire=@coduniv";
            cmd2.Parameters.AddWithValue("@coduniv", dropfac.selectedValue);
            cmd2.ExecuteNonQuery();

            DataTable dtt = new DataTable();
            DataTable dtt1 = new DataTable();
            MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd2);
            MySqlDataAdapter daa = new MySqlDataAdapter(cmd2);
            DataSet dss = new DataSet();
            daa1.Fill(dss);
            daa.Fill(dtt);

            foreach (DataRow dr in dtt.Rows)
            {

                codfac = Convert.ToInt32(dr["codfacultate"].ToString());
            }

            MySqlCommand cmd3 = new MySqlCommand();

            cmd3.Connection = con;
            cmd3.Parameters.Clear();
            cmd3.CommandText = "select semestru, denumire , codprogramstudii from programestudii where codfacultate=@coduniv";
            cmd3.Parameters.AddWithValue("@coduniv", codfac);
            cmd3.ExecuteNonQuery();

            DataTable dttt = new DataTable();

            MySqlDataAdapter daaa1 = new MySqlDataAdapter(cmd3);
            MySqlDataAdapter daaa = new MySqlDataAdapter(cmd3);
            DataSet dsss = new DataSet();
            daaa1.Fill(dsss);
            daaa.Fill(dttt);

            foreach (DataRow dr in dttt.Rows)
            {

                dropprogram.AddItem(dr["denumire"].ToString());
                
            }
            con.Close();
        }

        private void dropprogram_onItemSelected(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conn);

            con.Open();
            MySqlCommand cmd3 = new MySqlCommand();

            cmd3.Connection = con;
            cmd3.Parameters.Clear();
            cmd3.CommandText = "select semestru, denumire , codprogramstudii from programestudii where codfacultate=@coduniv";
            cmd3.Parameters.AddWithValue("@coduniv", codfac);
            cmd3.ExecuteNonQuery();

            DataTable dttt = new DataTable();

            MySqlDataAdapter daaa1 = new MySqlDataAdapter(cmd3);
            MySqlDataAdapter daaa = new MySqlDataAdapter(cmd3);
            DataSet dsss = new DataSet();
            daaa1.Fill(dsss);
            daaa.Fill(dttt);

            foreach (DataRow dr in dttt.Rows)
            {

                dropprogram.AddItem(dr["denumire"].ToString());
                semestru.Text = dr["semestru"].ToString();
            }
            con.Close();

        }

        private void applicationpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adaugastud_Click(object sender, EventArgs e)
        {
            //MySqlConnection con = new MySqlConnection(conn);
            //MySqlCommand cmd = new MySqlCommand();
            //cmd.Parameters.Clear();
            //cmd.Connection = con;
            //cmd.CommandText = "insert into studenti (nume, prenume, telefon, email ,codevaluare, codinscriere) values (@nume, @prenume, @telefon, @email , (select codevaluare from evaluare where codinscriere=@cod), @codinscriere)";
            //cmd.Parameters.AddWithValue("@nume", nume);
            //cmd.Parameters.AddWithValue("@prenume", prenume);
            //cmd.Parameters.AddWithValue("@telefon", telefon.Text);
            //cmd.Parameters.AddWithValue("@email", email.Text);
            //cmd.Parameters.AddWithValue("@cod", id_cod);
            //cmd.Parameters.AddWithValue("@codinscriere", id_cod);



            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
    }
}
