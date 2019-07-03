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
    public partial class membrii : UserControl

    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public membrii()
        {
            InitializeComponent();
            Grid();
            if (app.roll == "rector" || app.roll == "admin")
            {
                button1.Visible = true;
                uppdate.Visible = true;
                deteletemembriibtn.Visible = true;
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            adaugamembriipanel.Visible=true;
            membriipanel.Visible = false;
            adaugamembriipanel.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox9.Text != bunifuMaterialTextbox10.Text)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "insert into utilizatori (nume, prenume, telefon, email, username, parola, rol) values (@nume, @prenume, @telefon, @email, @username, @parola, @rol)";
                cmd.Parameters.AddWithValue("@nume", bunifuMaterialTextbox4.Text);
                cmd.Parameters.AddWithValue("@prenume", bunifuMaterialTextbox5.Text);
                cmd.Parameters.AddWithValue("@telefon", bunifuMaterialTextbox6.Text);
                cmd.Parameters.AddWithValue("@email", bunifuMaterialTextbox7.Text);
                cmd.Parameters.AddWithValue("@username", bunifuMaterialTextbox8.Text);
                cmd.Parameters.AddWithValue("@parola", bunifuMaterialTextbox9.Text);
                cmd.Parameters.AddWithValue("@rol", comboBox1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                adaugamembriipanel.Visible = false;
                membriipanel.Visible = true;
                membriipanel.BringToFront();
            }

        }

        private void Grid()
        {
            MySqlConnection con = new MySqlConnection(conn);

            con.Open();
            MySqlDataAdapter gr = new MySqlDataAdapter();
            string cmd = "select codutilizator, nume, prenume, telefon, email, username, rol from utilizatori ";
            gr.SelectCommand = new MySqlCommand(cmd, con);
            DataTable utilizatori = new DataTable();
            gr.Fill(utilizatori);
            BindingSource bs = new BindingSource();
            bs.DataSource = utilizatori;
            bunifuCustomDataGrid2.DataSource = bs;
            con.Close();


        }

        public int id_utilz;
        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            id_utilz = Convert.ToInt32(bunifuCustomDataGrid2.Rows[e.RowIndex].Cells["codutilizator"].Value.ToString());
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            con.Open();


            cmd.Connection = con;
            cmd.CommandText = "select * from utilizatori where codutilizator=" + id_utilz + "";
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
                afisare1.Text = dr["nume"].ToString();
                afisare2.Text = dr["prenume"].ToString();
                afisare3.Text = dr["telefon"].ToString();
                afisare4.Text = dr["email"].ToString();
                afisare5.Text = dr["username"].ToString();
                afisare6.Text = dr["rol"].ToString();
                afisare1.Text = dr["nume"].ToString();
            }

            viewmembrii.Visible = true;
            membriipanel.Visible = false;
            adaugamembriipanel.Visible = false;
            viewmembrii.BringToFront();
        }


                private void cancelbtnmem_Click(object sender, EventArgs e)
        {
            adaugamembriipanel.Visible = false;
            viewmembrii.Visible = false;
            membriipanel.Visible = true;
            membriipanel.BringToFront();
        }

   

        private void viewbtn_Click(object sender, EventArgs e)
        {
            adaugamembriipanel.Visible = false;
            viewmembrii.Visible = false;
            membriipanel.Visible = true;
        }
        
        private void deteletemembriibtn_Click(object sender, EventArgs e)
        {
           
            if (id_utilz != 0)
            {
                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM utilizatori WHERE utilizatori.codutilizator =" + id_utilz + "";
                con.Open();
               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Utilizatorul a fost sters.");
                adaugamembriipanel.Visible = false;
                viewmembrii.Visible = false;
                membriipanel.Visible = true;
                membriipanel.BringToFront();

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }


        }

        private void uppdate_Click(object sender, EventArgs e)
        {
            

            if (afisare1.Text != "" )
            {

                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update  utilizatori set nume=@nume ,  prenume=@prenume, telefon=@telefon, email=@email, username=@username, rol=@rol where codutilizator=" + id_utilz + "";
                con.Open();

   
                cmd.Parameters.AddWithValue("@nume", afisare1.Text);
                cmd.Parameters.AddWithValue("@prenume", afisare2.Text);
                cmd.Parameters.AddWithValue("@telefon", afisare3.Text);
                cmd.Parameters.AddWithValue("@email", afisare4.Text);
                cmd.Parameters.AddWithValue("@username", afisare5.Text);
                cmd.Parameters.AddWithValue("@rol", afisare6.Text);
                cmd.ExecuteNonQuery();
                con.Close();
             
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
    }

}
