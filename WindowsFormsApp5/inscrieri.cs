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
    public partial class inscrieri : UserControl

    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public inscrieri()
        {
            InitializeComponent();
            LstNote = new List<int>();
            Grid();
            Gridd();

        }

        private void btt_Click(object sender, EventArgs e)
        {
            notepanel.Visible = true;
            applicationpanel.Visible = false;
        }

        private void Grid()
        {
            MySqlConnection con = new MySqlConnection(conn);

            con.Open();
            MySqlDataAdapter gr = new MySqlDataAdapter();
            string cmd = "select codinscriere, dataa, nume, prenume, medie, email, telefon from inscrieri ";
            gr.SelectCommand = new MySqlCommand(cmd, con);
            DataTable utilizatori = new DataTable();
            gr.Fill(utilizatori);
            BindingSource bs = new BindingSource();
            bs.DataSource = utilizatori;
            bunifuCustomDataGrid2.DataSource = bs;
            con.Close();
            bunifuCustomDataGrid2.FirstDisplayedScrollingRowIndex = bunifuCustomDataGrid2.RowCount - 1;

        }


      
        public int id_inscrieri;
        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_inscrieri = Convert.ToInt32(bunifuCustomDataGrid2.Rows[e.RowIndex].Cells["codinscriere"].Value.ToString());
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            con.Open();


            cmd.Connection = con;
            cmd.Parameters.Clear();
            
            cmd.CommandText = "select CONCAT(nume,' ',prenume) as NUME, medie,validare  from inscrieri where codinscriere=@cod";
            cmd.Parameters.AddWithValue("@cod", id_inscrieri);
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
                afisare1.Text = dr["NUME"].ToString();
                afisare2.Text = dr["medie"].ToString();

                if(Convert.ToInt32(dr["validare"].ToString())  == 0)
                {
                    adauganotebtt.Visible = true;
                    notepanel.Visible = true;
                    applicationpanel.Visible = false;
                    notepanel.BringToFront();

                }

                else
                {
                    MessageBox.Show("Pentru acest student notele au fost introduse");
                }


            }


        }

        
        List<int> LstNote;
        double media;
        private void adauganotebtt_Click(object sender, EventArgs e)
        {
            
               if (id_inscrieri != 0)
                 {

                if(bunifuMaterialTextbox19.Text != "" & bunifuMaterialTextbox20.Text != "")
                {
                    media = (Convert.ToDouble(bunifuMaterialTextbox19.Text) + Convert.ToDouble(bunifuMaterialTextbox20.Text) + Convert.ToDouble(afisare2.Text)) / 3;
                    label4.Text = Convert.ToString(media);

                }

                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand cmd2 = new MySqlCommand();

                cmd.Parameters.Clear();
                cmd.Connection = con;

                

                cmd.CommandText = "insert into evaluare (notaengleza, notainterviu, datarez, notastudii,medie,codinscriere) values (@notaengleza, @notainterviu, @datarez , @notastudii,@medie,@codinscriere)";
                cmd.Parameters.AddWithValue("@notaengleza", bunifuMaterialTextbox19.Text);
                
                cmd.Parameters.AddWithValue("@notainterviu", bunifuMaterialTextbox20.Text);
                cmd.Parameters.AddWithValue("@datarez", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@notastudii", Convert.ToDouble(afisare2.Text));
                cmd.Parameters.AddWithValue("@medie", Convert.ToDouble(label4.Text));
                cmd.Parameters.AddWithValue("@codinscriere", id_inscrieri);



                cmd2.Parameters.Clear();
                cmd2.Connection = con;



                cmd2.CommandText = "update inscrieri set validare=1 where codinscriere=@cod";
                cmd2.Parameters.AddWithValue("@cod", id_inscrieri);

             

                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                MessageBox.Show("");
            }

            notepanel.Visible = false;
            applicationpanel.Visible = true;
            applicationpanel.BringToFront();

        }

       

        private void bunifuMaterialTextbox20_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox19.Text != "")
            {
                label4.Visible = true;

                media = (Convert.ToDouble(bunifuMaterialTextbox19.Text) + Convert.ToDouble(bunifuMaterialTextbox20.Text) + Convert.ToDouble(afisare2.Text)) / 3;
                //label4.Text = string.Format(Convert.ToString(media), "{0:0.00}");
                label4.Text = string.Format("{0:0.00}", media);

                if (media > 8)
                {
                    admis.Visible = true;
                }
                else
                {
                    respins.Visible = true;
                }
            }

        }

        private void Gridd()
        {
            MySqlConnection con = new MySqlConnection(conn);

            con.Open();
            MySqlDataAdapter gr = new MySqlDataAdapter();
            string cmd = "select  inscrieri.nume as nume, inscrieri.prenume as prenume, evaluare.notaengleza as nota, evaluare.notainterviu as notaa, evaluare.medie as medie  from inscrieri" +
                " inner join evaluare on evaluare.codinscriere = inscrieri.codinscriere order by evaluare.medie desc ";
            gr.SelectCommand = new MySqlCommand(cmd, con);
            DataTable inscrieri = new DataTable();
            gr.Fill(inscrieri);
            BindingSource bs = new BindingSource();
            bs.DataSource = inscrieri;
            rezultategrid.DataSource = bs;
            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            notepanel.Visible = false;
            applicationpanel.Visible = false;

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            notepanel.Visible = false;
            applicationpanel.Visible = true;
            applicationpanel.BringToFront();
        }
    }



    }



