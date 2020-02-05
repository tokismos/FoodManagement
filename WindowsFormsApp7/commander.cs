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

namespace WindowsFormsApp7
{
    public partial class commander : UserControl
    {
        int rest;
        string nom;
        string description;
        string quantite;

        MySqlConnection cnn = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");
        MySqlCommand command;
        int flag;

        public commander()
        {
           
            InitializeComponent();
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 71, 160);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.rest = rest;
            FillDGV("");
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void FillDGV(String valueToSearch)
        {
            MySqlCommand cmd = new MySqlCommand("select id,Nom,Description,Prix,Image  from mcdonald where CONCAT(nom,description)  LIKE '%" + valueToSearch + "%'", cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.RowTemplate.Height = 65;
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)dataGridView1.Columns[4];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns[0].Visible = false;



        }
        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {
            cnn.Open();
            FillDGV(txt_chercher.Text);
            cnn.Close();
        }
        private void commander_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            byte[] imge = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(imge);
            // imge.Save(ms, ImageFormat.Jpeg);
            pictureBox1.Image = Image.FromStream(ms);
            lbl_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lbl_desc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lbl_prix.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Prix.Visible = true;
            pictureBox1.Visible = true;
            // txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] imge = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(imge);
            // imge.Save(ms, ImageFormat.Jpeg);
            
            choix choix = new choix(lbl_Name.Text, lbl_desc.Text, lbl_prix.Text, pictureBox1.Image);
            choix.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
             //Form2.button1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, EventArgs e)
        {
            byte[] imge = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(imge);
            // imge.Save(ms, ImageFormat.Jpeg);

            choix choix = new choix(lbl_Name.Text, lbl_desc.Text, lbl_prix.Text, pictureBox1.Image);
            choix.ShowDialog();
        }
    }
}
