using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        MySqlCommand cmd;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection cnn = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");

            MySqlDataAdapter sda = new MySqlDataAdapter("select * from compte where UserN='"+txt_User.Text+"' AND PassN='"+txt_Pass.Text+"'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                string User = dt.Rows[0]["UserN"].ToString();
                string Pass = dt.Rows[0]["PassN"].ToString();
                string Nom = dt.Rows[0]["Nom"].ToString();
                string Prenom = dt.Rows[0]["Prenom"].ToString();
                string Adresse = dt.Rows[0]["Adresse"].ToString();
                string Credit = dt.Rows[0]["Credit"].ToString();
                byte[] img =(byte[]) dt.Rows[0]["Image"];

                // MessageBox.Show(img);
                Form2 form2;
                if (User=="tokismos")
                    form2 = new Form2(1, Nom, Prenom, User, Pass, Adresse, Credit, img);
                else
                form2 = new Form2(0,Nom,Prenom,User,Pass,Adresse,Credit,img);
                this.Hide();
                form2.ShowDialog();
            }
            else
                pnl_Erreur.Visible = true;

            /*

            if (txt_User.Text.Equals("admin") && txtPass.Text.Equals("admin"))
            {
                Form2 form2 = new Form2(txt_User.Text);
                this.Hide();
                form2.ShowDialog();
            }
            else {

                pnl_Erreur.Visible = true;
            }
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
