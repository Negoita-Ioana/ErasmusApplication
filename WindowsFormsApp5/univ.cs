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
    public partial class univ : UserControl
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public univ()
        {
            LstUniv = new List<int>();
            LstFacultate = new List<int>();
            InitializeComponent();
            Grid();
       
        }

        List<int> LstUniv;

        private void adaugaunivbtn_Click(object sender, EventArgs e)
        {

            adaugaunivpanel.Visible = true;
            adaugaunivpanel.BringToFront();

            try
            {
                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "select denumire , coduniversitate from universitati";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    LstUniv.Add(Convert.ToInt32(dr["coduniversitate"]));
                    bunifuDropdown1.AddItem(dr["denumire"].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

//----- afisare universitati si facultati in grid 

        private void Grid()
        {
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            MySqlDataAdapter gr = new MySqlDataAdapter();

            string cmd = "select  universitati.denumire as universitate, facultati.denumire as facultate, " +
                "facultati.codfacultate as cod, oras, tara from universitati" +
                " inner join facultati on facultati.coduniversitate = universitati.coduniversitate ";

            gr.SelectCommand = new MySqlCommand(cmd, con);
            DataTable universitati = new DataTable();
            gr.Fill(universitati);
            BindingSource bs = new BindingSource();
            bs.DataSource = universitati;
            griduniv.DataSource = bs;
            con.Close();

        }

//----- selectare universitate si afisare

        public int id_univ;
        private void griduniv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_univ = Convert.ToInt32(griduniv.Rows[e.RowIndex].Cells["cod"].Value.ToString());
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "select  universitati.denumire as universitate, facultati.denumire as facultate, " +
                "facultati.codfacultate as cod, facultati.email as email, facultati.fax as fax, facultati.telefon as telefon, oras, tara from universitati" +
                " inner join facultati on facultati.coduniversitate = universitati.coduniversitate  where codfacultate=" + id_univ + "";
            
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
                afisare1.Text = dr["universitate"].ToString();
                afisare2.Text = dr["facultate"].ToString();
                afisare3.Text = dr["email"].ToString();
                afisare4.Text = dr["telefon"].ToString();
                afisare5.Text = dr["fax"].ToString();
                afisare6.Text = dr["tara"].ToString();
                afisare7.Text = dr["oras"].ToString();
            }

            vizulaizarepanel.Visible = true;
            universitatipanel.Visible = false;
            vizulaizarepanel.BringToFront();
        }

        List<int> LstFacultate;

 //----- afisare facultate

        private void adaugauniv_Click(object sender, EventArgs e)
        {
            adaugaunivpanel.Visible = false;
            universitatipanel.Visible = false;
            addprogram.Visible = true;

            try
            {
                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "select denumire , codfacultate from facultati";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    LstFacultate.Add(Convert.ToInt32(dr["codfacultate"]));
                    dropdownfacultate.AddItem(dr["denumire"].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
   
 //---- adauga facultate

        private void button4_Click(object sender, EventArgs e)
        {
            int coduniv = LstUniv[bunifuDropdown1.selectedIndex];
                    MySqlConnection con = new MySqlConnection(conn);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    
                    cmd.CommandText = "insert into facultati (denumire, email, telefon, fax , coduniversitate) " +
                "values (@denumire, @email, @telefon, @fax , @coduniversitate)";
                    cmd.Parameters.AddWithValue("@denumire", bunifuMaterialTextbox1.Text);
                    cmd.Parameters.AddWithValue("@email", bunifuMaterialTextbox6.Text);
                    cmd.Parameters.AddWithValue("@telefon", bunifuMaterialTextbox8.Text);
                    cmd.Parameters.AddWithValue("@fax", bunifuMaterialTextbox7.Text);
                    cmd.Parameters.AddWithValue("coduniversitate", coduniv);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
            labeladdfac.Visible = true; timer1.Start();

        }

 //---- adauga universitate

        private void univbtnn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "insert into universitati (denumire, tara, oras) values (@denumire, @tara, @oras)";
            cmd.Parameters.AddWithValue("@denumire", bunifuMaterialTextbox9.Text);
            cmd.Parameters.AddWithValue("@tara", bunifuMaterialTextbox10.Text);
            cmd.Parameters.AddWithValue("@oras", bunifuMaterialTextbox3.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            labeladdun.Visible = true; timer1.Start();

        }

        private void canceladd_Click(object sender, EventArgs e)
        {
            adaugaunivpanel.Visible = false;
            universitatipanel.Visible = true;
            universitatipanel.BringToFront();

        }

  //---- functie inserare cursuri

        public void Cursuri(string denumire, string credit)

        {
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.Clear();
            cmd.Connection = con;

            cmd.CommandText = "insert into cursuri (denumire, punctecredit) values (@denumire, @punctecredit)";
            cmd.Parameters.AddWithValue("@denumire", denumire);
            cmd.Parameters.AddWithValue("@punctecredit", credit);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Insert_CursuriPorgrame();
        }

//------ inserarea  

        public void Insert_CursuriPorgrame()
        {
            try
            {
                int codprogramstudii, codcurs;

                MySqlConnection con = new MySqlConnection(conn);
                con.Open();
                MySqlDataAdapter gr = new MySqlDataAdapter();
                string sql = "select MAX(codprogramstudii) as codprogramstudii from programestudii";
                gr.SelectCommand = new MySqlCommand(sql, con);
                DataTable dt = new DataTable();
                gr.Fill(dt);
                //if (dt.Rows.Count > 0)
                codprogramstudii = Convert.ToInt32(dt.Rows[0]["codprogramstudii"]);

                sql = "select MAX(codcurs) as codcurs from cursuri";
                gr.SelectCommand = new MySqlCommand(sql, con);
                dt = new DataTable();
                gr.Fill(dt);
                //if (dt.Rows.Count > 0)
                codcurs = Convert.ToInt32(dt.Rows[0]["codcurs"]);
                con.Close();


                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "insert into cursuriprograme (codcurs, codprogramstudii) values (@curs, @program)";
                cmd.Parameters.AddWithValue("@curs", codcurs);
                cmd.Parameters.AddWithValue("@program", codprogramstudii);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            { }

        }

        int counterseccondforvalidateerror;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counterseccondforvalidateerror = counterseccondforvalidateerror + 100;
            if (counterseccondforvalidateerror == 2000)
            {
               
                labeladdfac.Visible = false;
                labeladdun.Visible = false;
                timer1.Stop();
                counterseccondforvalidateerror = 0;
            }
            else
                return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codfacul = LstFacultate[dropdownfacultate.selectedIndex];
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "insert into programestudii (denumire, semestru, anstudiu, codfacultate) " +
                "values (@denumire, @semestru, @anstudiu, @codfacultate)";

            cmd.Parameters.AddWithValue("@denumire", bunifuMaterialTextbox36.Text);
            cmd.Parameters.AddWithValue("@semestru", bunifuMaterialTextbox4.Text);
            cmd.Parameters.AddWithValue("@anstudiu", bunifuMaterialTextbox5.Text);
            cmd.Parameters.AddWithValue("@codfacultate", codfacul);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Cursuri(bunifuMaterialTextbox30.Text, bunifuMaterialTextbox24.Text);
            Cursuri(bunifuMaterialTextbox33.Text, bunifuMaterialTextbox25.Text);
            Cursuri(bunifuMaterialTextbox31.Text, bunifuMaterialTextbox23.Text);
            Cursuri(bunifuMaterialTextbox28.Text, bunifuMaterialTextbox22.Text);
            Cursuri(bunifuMaterialTextbox26.Text, bunifuMaterialTextbox21.Text);
            Cursuri(bunifuMaterialTextbox30.Text, bunifuMaterialTextbox24.Text);

            adaugaunivpanel.Visible = false;
            universitatipanel.Visible = true;
            universitatipanel.BringToFront();

        }

    }
}


