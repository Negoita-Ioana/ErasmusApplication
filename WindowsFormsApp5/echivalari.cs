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
    public partial class echivalari : UserControl

    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public echivalari()

        {
            InitializeComponent();
            LstPstudd = new List<int>();
            Grid();
            Gridd();

        }

        List<int> LstPstudd;

        private void adaugabtn_Click(object sender, EventArgs e)
        {
            applicationpanel.Visible = false;
            addnotepanel.Visible = false;
            catalog.Visible = true;


            //try
            //{
            //    MySqlConnection con = new MySqlConnection(conn);
            //    MySqlCommand cmd = new MySqlCommand();
            //    con.Open();
            //    cmd.Connection = con;

            //    cmd.CommandText = "select denumire , codprogramstudii from programestudii";
            //    cmd.ExecuteNonQuery();
            //    DataTable dt = new DataTable();
            //    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //    da.Fill(dt);

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Grid()
        {
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            MySqlDataAdapter gr = new MySqlDataAdapter();
            string cmd = "select * from studenti ";
            gr.SelectCommand = new MySqlCommand(cmd, con);
            DataTable utilizatori = new DataTable();
            gr.Fill(utilizatori);
            BindingSource bs = new BindingSource();
            bs.DataSource = utilizatori;
            echivalarigrid.DataSource = bs;
            con.Close();


        }

        private void Gridd()
        {
            MySqlConnection con = new MySqlConnection(conn);

            con.Open();
            MySqlDataAdapter gr = new MySqlDataAdapter();
            string cmd = "select * from studenti ";
            gr.SelectCommand = new MySqlCommand(cmd, con);
            DataTable utilizatori = new DataTable();
            gr.Fill(utilizatori);
            BindingSource bs = new BindingSource();
            bs.DataSource = utilizatori;
          
            cataloggrid.DataSource = bs;
            con.Close();


        }

        public int id_cod;

        private void echivalarigrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            id_cod = Convert.ToInt32(echivalarigrid.Rows[e.RowIndex].Cells["codstudent"].Value.ToString());
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd2 = new MySqlCommand();

            con.Open();


            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.CommandText = "select studenti.codstudent,CONCAT(studenti.nume,' ',studenti.prenume) AS NUME, " +
                "programestudii.denumire as 'Program', cursuri.denumire as 'Cursuri'," +
                "cursuri.punctecredit,plecari.codprogramstudii from studenti " +
                "inner join plecari on plecari.codstudent = studenti.codstudent " +
                "inner join programestudii on plecari.codprogramstudii = programestudii.codprogramstudii " +
                "inner join cursuriprograme on programestudii.codprogramstudii = cursuriprograme.codprogramstudii " +
                "inner join cursuri on cursuri.codcurs = cursuriprograme.codcurs where studenti.codstudent = @cod";

            cmd.Parameters.AddWithValue("@cod", id_cod);
            cmd.ExecuteNonQuery();


            cmd2.Connection = con;
            cmd2.Parameters.Clear();
            cmd2.CommandText = "select studenti.codstudent,CONCAT(studenti.nume,' ',studenti.prenume) AS NUME," +
                " programestudii.denumire as 'Program', cursuri.denumire as 'Cursuri'," +
                "cursuri.punctecredit,plecari.codprogramstudii from studenti " +
                "inner join plecari on plecari.codstudent = studenti.codstudent " +
                "inner join programestudii on plecari.codprogramstudii = programestudii.codprogramstudii " +
                "inner join cursuriprograme on programestudii.codprogramstudii = cursuriprograme.codprogramstudii " +
                "inner join cursuri on cursuri.codcurs = cursuriprograme.codcurs where studenti.codstudent = @cod";

            cmd2.Parameters.AddWithValue("@cod", id_cod);
            cmd2.ExecuteNonQuery();


            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);
           

            MySqlDataReader sqlReader = cmd.ExecuteReader();

            student.Text = dt.Rows[0]["NUME"].ToString();
            program.Text = dt.Rows[0]["Program"].ToString();
            Control[] arr = { curs1, curs2, curs3, curs4, curs5, curs6 };
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                //student.Text = dr["NUME"].ToString();
                //program.Text = dr["Program"].ToString();
                arr[i++].Text = dr["Cursuri"].ToString();
            }

            //while (sqlReader.Read())
            //{
               
            //    curs1.Text = sqlReader.GetValue(3).ToString();
                
            //    curs2.Text = sqlReader.GetValue(3).ToString();
               
            //    curs3.Text = sqlReader.GetValue(3).ToString();

                
            //    curs4.Text = sqlReader.GetValue(3).ToString();
               
            //    curs5.Text = sqlReader.GetValue(3).ToString();
               
            //    curs6.Text = sqlReader.GetValue(3).ToString();

                
            //}
            //sqlReader.Close();

            //MySqlDataReader sqlReader2 = cmd2.ExecuteReader();


            //while (sqlReader2.Read())
            //{
            //    credit1.Text = sqlReader2.GetValue(4).ToString();
            //    sqlReader2.Read();
            //    credit2.Text = sqlReader2.GetValue(4).ToString();
            //    sqlReader2.Read();
            //    credit3.Text = sqlReader2.GetValue(4).ToString();

            //    sqlReader2.Read();
            //    credit4.Text = sqlReader2.GetValue(4).ToString();
            //    sqlReader2.Read();
            //    credit5.Text = sqlReader2.GetValue(4).ToString();
            //    sqlReader2.Read();
            //    credit6.Text = sqlReader2.GetValue(4).ToString();
            //}
            //sqlReader2.Close();

            con.Close();
            addnotepanel.Visible = true;
            addnotepanel.BringToFront();

        } 

        private void applicationpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        int status,status2,status3,status4,status5,status6;
        private void button1_Click(object sender, EventArgs e)
        {

            if(radioButton1.Checked == true) { status = 1; }
            else if (radioButton2.Checked == true) { status = 0; }
            if (radioButton3.Checked == true) { status2 = 1; }
            else if (radioButton4.Checked == true) { status2 = 0; }
            if (radioButton5.Checked == true) { status3 = 1; }
            else if (radioButton6.Checked == true) { status3 = 0; }
            if (radioButton7.Checked == true) { status4 = 1; }
            else if (radioButton8.Checked == true) { status4 = 0; }
            if (radioButton9.Checked == true) { status5 = 1; }
            else if (radioButton10.Checked == true) { status5 = 0; }
            if (radioButton11.Checked == true) { status6 = 1; }
            else if (radioButton12.Checked == true) { status6 = 0; }


            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "insert into echivalari (nota, codstudent, codprogramstudii, codcurs,statusechivalare) " +
                "values (@nota, @codstudent, (select codprogramstudii from programestudii where denumire=@denumirep), " +
                "(select codcurs from cursuri where denumire=@denumirec), @status)";

            cmd.Parameters.AddWithValue("@nota", nota.Text);
            cmd.Parameters.AddWithValue("@codstudent", id_cod);
            cmd.Parameters.AddWithValue("@denumirep", program.Text);
            cmd.Parameters.AddWithValue("@denumirec", curs1.Text);
            cmd.Parameters.AddWithValue("@status", status);


            //2
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Parameters.Clear();
            cmd2.Connection = con;
            cmd2.CommandText = "insert into echivalari (nota, codstudent, codprogramstudii, codcurs,statusechivalare) " +
                "values (@nota, @codstudent, (select codprogramstudii from programestudii where denumire=@denumirep), " +
                "(select codcurs from cursuri where denumire=@denumirec), @status)";

            cmd2.Parameters.AddWithValue("@nota", nota2.Text);
            cmd2.Parameters.AddWithValue("@codstudent", id_cod);
            cmd2.Parameters.AddWithValue("@denumirep", program.Text);

            cmd2.Parameters.AddWithValue("@denumirec", curs2.Text);
            cmd2.Parameters.AddWithValue("@status", status2);
            //3
            MySqlCommand cmd3= new MySqlCommand();
            cmd3.Parameters.Clear();
            cmd3.Connection = con;
            cmd3.CommandText = "insert into echivalari (nota, codstudent, codprogramstudii, codcurs,statusechivalare) " +
                "values (@nota, @codstudent, (select codprogramstudii from programestudii where denumire=@denumirep), " +
                "(select codcurs from cursuri where denumire=@denumirec), @status)";

            cmd3.Parameters.AddWithValue("@nota", nota3.Text);
            cmd3.Parameters.AddWithValue("@codstudent", id_cod);
            cmd3.Parameters.AddWithValue("@denumirep", program.Text);
            cmd3.Parameters.AddWithValue("@denumirec", curs3.Text);
            cmd3.Parameters.AddWithValue("@status", status3);

            //4
            MySqlCommand cmd4 = new MySqlCommand();
            cmd4.Parameters.Clear();
            cmd4.Connection = con;
            cmd4.CommandText = "insert into echivalari (nota, codstudent, codprogramstudii, codcurs,statusechivalare)" +
                " values (@nota, @codstudent, (select codprogramstudii from programestudii where denumire=@denumirep), " +
                "(select codcurs from cursuri where denumire=@denumirec), @status)";

            cmd4.Parameters.AddWithValue("@nota", nota4.Text);
            cmd4.Parameters.AddWithValue("@codstudent", id_cod);
            cmd4.Parameters.AddWithValue("@denumirep", program.Text);
            cmd4.Parameters.AddWithValue("@denumirec", curs4.Text);
            cmd4.Parameters.AddWithValue("@status", status4);
            //5
            MySqlCommand cmd5 = new MySqlCommand();
            cmd5.Parameters.Clear();
            cmd5.Connection = con;
            cmd5.CommandText = "insert into echivalari (nota, codstudent, codprogramstudii, codcurs,statusechivalare)" +
                " values (@nota, @codstudent, (select codprogramstudii from programestudii where denumire=@denumirep), " +
                "(select codcurs from cursuri where denumire=@denumirec), @status)";

            cmd5.Parameters.AddWithValue("@nota", nota5.Text);
            cmd5.Parameters.AddWithValue("@codstudent", id_cod);
            cmd5.Parameters.AddWithValue("@denumirep", program.Text);
            cmd5.Parameters.AddWithValue("@denumirec", curs5.Text);
            cmd5.Parameters.AddWithValue("@status", status5);
            //6
            MySqlCommand cmd6 = new MySqlCommand();
            cmd6.Parameters.Clear();
            cmd6.Connection = con;
            cmd6.CommandText = "insert into echivalari (nota, codstudent, codprogramstudii, codcurs,statusechivalare)" +
                " values (@nota, @codstudent, (select codprogramstudii from programestudii where denumire=@denumirep), " +
                "(select codcurs from cursuri where denumire=@denumirec), @status)";

            cmd6.Parameters.AddWithValue("@nota", nota6.Text);
            cmd6.Parameters.AddWithValue("@codstudent", id_cod);
            cmd6.Parameters.AddWithValue("@denumirep", program.Text);
            cmd6.Parameters.AddWithValue("@denumirec", curs6.Text);
            cmd6.Parameters.AddWithValue("@status", status6);

            con.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            cmd6.ExecuteNonQuery();

            con.Close();

            addnotepanel.Visible = false;
        }

        private void cataloggrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            id_cod = Convert.ToInt32(cataloggrid.Rows[e.RowIndex].Cells["codstudent"].Value.ToString());
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd2 = new MySqlCommand();
            MySqlCommand cmd3 = new MySqlCommand();

            con.Open();


            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.CommandText = "select studenti.codstudent,CONCAT(studenti.nume,' ',studenti.prenume) AS NUME, " +
                "programestudii.denumire as 'Program', cursuri.denumire as 'Cursuri',cursuri.punctecredit," +
                "plecari.codprogramstudii from studenti " +
                "inner join plecari on plecari.codstudent = studenti.codstudent " +
                "inner join programestudii on plecari.codprogramstudii = programestudii.codprogramstudii " +
                "inner join cursuriprograme on programestudii.codprogramstudii = cursuriprograme.codprogramstudii " +
                "inner join cursuri on cursuri.codcurs = cursuriprograme.codcurs where studenti.codstudent = @cod";

            cmd.Parameters.AddWithValue("@cod", id_cod);
            cmd.ExecuteNonQuery();


            cmd2.Connection = con;
            cmd2.Parameters.Clear();
            cmd2.CommandText = "select studenti.codstudent,CONCAT(studenti.nume,' ',studenti.prenume) AS NUME, " +
                "programestudii.denumire as 'Program', cursuri.denumire as 'Cursuri',cursuri.punctecredit," +
                "plecari.codprogramstudii from studenti " +
                "inner join plecari on plecari.codstudent = studenti.codstudent" +
                " inner join programestudii on plecari.codprogramstudii = programestudii.codprogramstudii " +
                "inner join cursuriprograme on programestudii.codprogramstudii = cursuriprograme.codprogramstudii" +
                " inner join cursuri on cursuri.codcurs = cursuriprograme.codcurs where studenti.codstudent = @cod";

            cmd2.Parameters.AddWithValue("@cod", id_cod);
            cmd2.ExecuteNonQuery();

            cmd3.Connection = con;
            cmd3.Parameters.Clear();
            

            cmd3.CommandText = "Select echivalari.nota, studenti.codstudent, cursuri.codcurs from studenti " +
                "inner join echivalari on echivalari.codstudent= studenti.codstudent " +
                "inner join cursuri on  cursuri.codcurs = echivalari.codcurs where studenti.codstudent = @cod";
             
            cmd3.Parameters.AddWithValue("@cod", id_cod);
            cmd3.ExecuteNonQuery();


            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);


            MySqlDataReader sqlReader = cmd.ExecuteReader();




            foreach (DataRow dr in dt.Rows)
            {
                catalogstud.Text = dr["NUME"].ToString();
                catalogprogram.Text = dr["Program"].ToString();


            }

            sqlReader.Read();
            catalogcurs1.Text = sqlReader.GetValue(3).ToString();
            sqlReader.Read();
            catalogcurs2.Text = sqlReader.GetValue(3).ToString();
            sqlReader.Read();
            catalogcurs3.Text = sqlReader.GetValue(3).ToString();

            sqlReader.Read();
            catalogcurs4.Text = sqlReader.GetValue(3).ToString();
            sqlReader.Read();
            catalogcurs5.Text = sqlReader.GetValue(3).ToString();
            sqlReader.Read();
            catalogcurs6.Text = sqlReader.GetValue(3).ToString();

            sqlReader.Close();

            MySqlDataReader sqlReader2 = cmd2.ExecuteReader();


            sqlReader2.Read();
            catalogcredit1.Text = sqlReader2.GetValue(4).ToString();
            sqlReader2.Read();
            catalogcredit2.Text = sqlReader2.GetValue(4).ToString();
            sqlReader2.Read();
            catalogcredit3.Text = sqlReader2.GetValue(4).ToString();

            sqlReader2.Read();
            catalogcredit4.Text = sqlReader2.GetValue(4).ToString();
            sqlReader2.Read();
            catalogcredit5.Text = sqlReader2.GetValue(4).ToString();
            sqlReader2.Read();
            catalogcredit6.Text = sqlReader2.GetValue(4).ToString();

            sqlReader2.Close();

            MySqlDataReader sqlReader3 = cmd3.ExecuteReader();


            sqlReader3.Read();
            catalognota1.Text = sqlReader3.GetValue(0).ToString();
            sqlReader3.Read();
            catalognota2.Text = sqlReader3.GetValue(0).ToString();
            sqlReader3.Read();
            catalognota3.Text = sqlReader3.GetValue(0).ToString();
            catalognota4.Text = sqlReader3.GetValue(0).ToString();
            sqlReader3.Read();
            catalognota5.Text = sqlReader3.GetValue(0).ToString();
            sqlReader3.Read();
            catalognota6.Text = sqlReader3.GetValue(0).ToString();


            con.Close();
            catalognote.Visible = true;
            catalognote.BringToFront();

        }

    }
}
