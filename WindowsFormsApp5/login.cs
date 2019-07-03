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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        private void loginbtt_Click(object sender, EventArgs e)
        {

            // MySqlConnection con = new MySqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Veve\Desktop\WindowsFormsApp5\WindowsFormsApp5\db\bz.mdf;Integrated Security=True;Connect Timeout=30;");
            MySqlConnection con = new MySqlConnection(conn);
            MySqlDataAdapter sda = new MySqlDataAdapter("Select Count(*) From utilizatori where username='" + usernametxt.Text  +"' and parola = '" + passtxt.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                nume = usernametxt.Text;
                app frm = new app();
                frm.Show();
                this.Hide();
            }
            else
            {
                timer1.Start();
                label3.Visible = true;

            }

        }

        private int _ticks;
        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 10)
            {
                label3.Visible = false;
                timer1.Stop();
                _ticks = 0;
            }

        }
        public static string nume;
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

    }

}
