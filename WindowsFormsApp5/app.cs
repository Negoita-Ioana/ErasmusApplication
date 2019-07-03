using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace WindowsFormsApp5
{
    public partial class app : Form
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public app()
        {

            InitializeComponent();
            //---------------comp de initializare-----
            timerTime.Start();
            Rol();


             //--------------------prima chestie-------
           
            PanelMeniu.Visible = true;
            //----------------------------------------
        }

        private void closebtn_Click(object sender, EventArgs e) //close button
        {
            Application.Exit();
        }
            
        private void addpagestopanel (Control c) //--------------functie pt umplere panel
        {
            c.Dock = DockStyle.Fill;
            PanelMeniu.Controls.Clear();
            PanelMeniu.Controls.Add(c);
        }

        

//------------ meniu button
        private void label9_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label19.Visible = false;
            label2.Visible = false;
            label5.Visible = false;

            label10.Left = ((Control)sender).Left;
            label10.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(label10);
           
            univ univ = new univ();
            addpagestopanel(univ);

        }



        private void label12_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label19.Visible = false;
            label2.Visible = false;
            label5.Visible = false;

            label11.Left = ((Control)sender).Left;
            label11.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(label11);

           

           membrii mem = new membrii();
            addpagestopanel(mem);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label19.Visible = false;
            label2.Visible = false;
            label5.Visible = false;

            label13.Left = ((Control)sender).Left;
            label13.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(label13);

            inscrieri ins = new inscrieri();
            addpagestopanel(ins);
        
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label19.Visible = false;
            label2.Visible = false;
            label5.Visible = false;

            label15.Left = ((Control)sender).Left;
            label15.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(label15);

            statistici st = new statistici();
            addpagestopanel(st);


        }

        private void label18_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label19.Visible = false;
            label2.Visible = false;
            label5.Visible = false;

            label17.Left = ((Control)sender).Left;
            label17.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(label17);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label19.Visible = false;
            label2.Visible = false;
            label5.Visible = false;

            label19.Left = ((Control)sender).Left;
            label19.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(label19);


            outgoing outtstud = new outgoing();
            addpagestopanel(outtstud);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            label19.Visible = false;
            label2.Visible = false;
            label5.Visible = false;

            label2.Left = ((Control)sender).Left;
            label2.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(label2);

            echivalari echiv = new echivalari();
            addpagestopanel(echiv);

        }

        private void label18_Click_1(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label19.Visible = false;
            label15.Visible = false;
            label2.Visible = false;
            label17.Visible = false;
            label5.Visible = false;

            label17.Left = ((Control)sender).Left;
            label17.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(label17);
            rezultate rez = new rezultate();
            addpagestopanel(rez);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            label19.Visible = false;
            label15.Visible = false;
            label2.Visible = false;
            label17.Visible = false;
            label5.Visible = false;

            label5.Left = ((Control)sender).Left;
            label5.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(label5);
            rapoarte rapoarte = new rapoarte();
            addpagestopanel(rapoarte);
        }


        //--------------------------


        private void timerTime_Tick(object sender, EventArgs e)
        {
            
            string currenttime = DateTime.Now.ToLongTimeString();
            string currentdate = DateTime.Now.ToShortDateString();
            labelTime.Text = currenttime + " - " + currentdate;

        }

        //------------------------------
        private void Rol ()
        {
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "Select* from utilizatori where username = @numee";
            cmd.Parameters.AddWithValue("@numee", login.nume);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            sda.Fill(dt);
            foreach(DataRow tr in dt.Rows )
            {
                Usernamelabel.Text = tr["username"].ToString();
                Functialabel.Text = tr["rol"].ToString();

            }
            roll = Functialabel.Text;

        }

        public static  string roll = "";

        private void minibtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            PanelMeniu.Visible = true;
            PanelMeniu.BringToFront();
            PanelMeniu.Controls.Clear();

        }

       
    }
}
