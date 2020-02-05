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
    public partial class UserControl1 : UserControl
    {
        MySqlConnection cnn = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");
        MySqlCommand command, cmd;
        public UserControl1()
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
            dataGridView1.ColumnHeadersHeight = 23;
            FillDGV("");
        }

        private void UserControl1_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cnn = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");
            command = new MySqlCommand("select * from mcdonald", cnn);
            cnn.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //  comboBox1.Items.Add(reader["nom"].ToString());

            }




            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "choose image(*.JPG;*.PNG;)|*.jpg;*.png;";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);

            }

        }

        

       
        private void dataGridView1_CellContentClick (object sender, EventArgs e) { }

        private void btn_Insert_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `mcdonald`(`Nom`, `Description`, `Prix`, `image`) VALUES (@nom,@description,@prix,@img)", cnn);
            cmd.Parameters.AddWithValue("@nom", txt_Name.Text);
            cmd.Parameters.AddWithValue("@description", txt_Description.Text);
            cmd.Parameters.AddWithValue("@prix", txt_prix.Text);
            cmd.Parameters.AddWithValue("@img", img);
            cnn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertion reussie");
            FillDGV("");
            txt_prix.Text = "";
            txt_Name.Text = "";
            txt_Description.Text = "";
            txt_id.Text = "";

            cnn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand cmd = new MySqlCommand("UPDATE mcdonald SET Nom= @nom,Description= @description,Prix= @prix,image= @img WHERE id = @id", cnn);
            cmd.Parameters.AddWithValue("@nom", txt_Name.Text);
            cmd.Parameters.AddWithValue("@description", txt_Description.Text);
            cmd.Parameters.AddWithValue("@prix", txt_prix.Text);
            cmd.Parameters.AddWithValue("@img", img);
            cmd.Parameters.AddWithValue("@id", txt_id.Text);

            cnn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modification reussie");
            FillDGV("");
            txt_prix.Text = "";
            txt_Name.Text = "";
            txt_Description.Text = "";
            txt_id.Text = "";
            cnn.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `mcdonald` WHERE id=@id", cnn);
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Suppression reussie");
            FillDGV("");
            txt_prix.Text = "";
            txt_Name.Text = "";
            txt_Description.Text = "";
            txt_id.Text = "";
            cnn.Close();
        }

        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {
            cnn.Open();
            FillDGV(txt_chercher.Text);
            cnn.Close();
        }

        private void txt_Description_TextChanged(object sender, EventArgs e)
        {
            cnn.Open();
            FillDGV(txt_chercher.Text);
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cnn.Open();
            byte[] imge = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(imge);
            // imge.Save(ms, ImageFormat.Jpeg);
            pictureBox1.Image = Image.FromStream(ms);
            txt_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Description.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_prix.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            cnn.Close();
        }
    }
}
