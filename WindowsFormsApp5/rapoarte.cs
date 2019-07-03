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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace WindowsFormsApp5
{
    public partial class rapoarte : UserControl
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public rapoarte()
        {
            InitializeComponent();
            
        }

        DateTime PrintTime = DateTime.Now;

        public void exportgridpdf(DataGridView dd, string filename)
        {

            
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dd.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;


            //header
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
            string imageURL = @"C:\Users\Veve\Desktop\licenta\imagine.jpg";
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);
            jpg.Alignment = Element.ALIGN_RIGHT;
            foreach (DataGridViewColumn col in dd.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);


            }
            foreach (DataGridViewRow row in dd.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A3, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();

                }
            }


        }

        //-----


        //----



        private void rapoarte_Load(object sender, EventArgs e)
        {

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
            gridraport1.DataSource = bs;
            con.Close();

        }

        private void Grid2()
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
            gridraport1.DataSource = bs;
            con.Close();

        }


        private void Grid3()
        {
            MySqlConnection con = new MySqlConnection(conn);

            con.Open();
            MySqlDataAdapter gr = new MySqlDataAdapter();
            string cmd = "  select universitati.denumire as universitate, facultati.denumire as facultate, " +
                "facultati.codfacultate as cod, oras, tara from universitati" +
                " inner join facultati on facultati.coduniversitate = universitati.coduniversitate ";
            gr.SelectCommand = new MySqlCommand(cmd, con);
            DataTable studenti = new DataTable();
            gr.Fill(studenti);
            BindingSource bs = new BindingSource();
            bs.DataSource = studenti;
            gridraport1.DataSource = bs;
            con.Close();

        }

        private void noteengraport_Click(object sender, EventArgs e)
        {
            Grid();
            exportgridpdf(gridraport1,"Note Engleza");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grid2();
            exportgridpdf(gridraport1, "Note Engleza");
        }

        private void raport3_Click(object sender, EventArgs e)
        {
            Grid3();
            exportgridpdf(gridraport1, "Universitati");
          
        }
    }
}
