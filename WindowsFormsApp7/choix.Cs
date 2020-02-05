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
    public partial class choix : Form
    {
        MySqlConnection cnn = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");
        MySqlCommand cmd;
        String nom;
        String description;
        String prix;
        Image img;
        int quantite;
        public choix(String nom,String description,String Prix,Image img)
        {

            this.nom = nom;
            this.description = description;
            this.prix = Prix;
            this.img = img;
            
            InitializeComponent();
            lbl_name.Text = nom;
            lbl_description.Text = description;
            lbl_prix.Text = Prix;
            pictureBox1.Image = img;

        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            
        
            
                cnn.Open();
               
            quantite = int.Parse(lbl_quantite.Text);
                cmd = new MySqlCommand("INSERT INTO panier( nom,prix, description,img,quantite) VALUES(@nom,@prix,@description,@img,@quantite)",cnn);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@prix", int.Parse(prix)*quantite);
                cmd.Parameters.AddWithValue("@img", img);
            cmd.Parameters.AddWithValue("@quantite", quantite);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Commande Ajoutée au panier!");
            this.Dispose();
            cnn.Close();
        }

        private void choix_Load(object sender, EventArgs e)
        {


        }

        private void lbl_quantite_TextChanged(object sender, EventArgs e)
        {
            int a;
            a=int.Parse(prix) * int.Parse(lbl_quantite.Text);
            lbl_prix.Text = a.ToString();
        }

        private void lbl_quantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            { }

            else
                e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbl_quantite.Text);
            a++;
            if (a >= 10)
                lbl_quantite.Text = "10";
            else
                lbl_quantite.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbl_quantite.Text);
            a--;
            if(a<=1)
            lbl_quantite.Text = "1";
            else
                lbl_quantite.Text = a.ToString();
        }
    }
}
