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
    public partial class Profil : UserControl
    {
        String Nom, Prenom, User, Pass, Adresse, Cre;
        string Credit;

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            lbl_nom.Visible = false;
            lbl_prenom.Visible = false;

            lbl_adresse.Visible = false;

            txt_Name.Text = lbl_nom.Text;
            btn_import.Visible = true;
            txt_Prenom.Text = lbl_prenom.Text;
            txt_Adresse.Text = lbl_adresse.Text;
            txt_Name.Visible = true;
            txt_Prenom.Visible = true;
            txt_Adresse.Visible = true;
            btn_Modifier.Visible = false;
            btn_enregistrer.Visible = true;
            btn_Annuler.Visible = true;



        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            lbl_nom.Visible = true;
            lbl_prenom.Visible = true;

            lbl_adresse.Visible = true;
            lbl_nom.Text = txt_Name.Text;
            lbl_prenom.Text = txt_Prenom.Text;
            lbl_adresse.Text = txt_Adresse.Text;
            btn_import.Visible = false;
            txt_Name.Visible = false;
            txt_Prenom.Visible = false;
            txt_Adresse.Visible = false;
            btn_Modifier.Visible = true;
            btn_enregistrer.Visible = false;
            btn_Annuler.Visible = false;
            MemoryStream ms = new MemoryStream();
            picture_profil.Image.Save(ms, picture_profil.Image.RawFormat);
            byte[] imge = ms.ToArray();
            MySqlConnection cnn = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");

            MySqlCommand cmd = new MySqlCommand("UPDATE compte SET Nom= @nom,Prenom= @prenom,Adresse= @adresse,Image=@imge WHERE UserN = @user", cnn);
            cmd.Parameters.AddWithValue("@nom", txt_Name.Text);
            cmd.Parameters.AddWithValue("@prenom", txt_Prenom.Text);
            cmd.Parameters.AddWithValue("@adresse", txt_Adresse.Text);
            cmd.Parameters.AddWithValue("@user", User);
            cmd.Parameters.AddWithValue("@imge", imge);

            

            cnn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modification reussie");
            cnn.Close();
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            lbl_nom.Visible = true;
            lbl_prenom.Visible = true;

            lbl_adresse.Visible = true;
            txt_Name.Visible = false;
            btn_import.Visible = false;
            txt_Prenom.Visible = false;
            txt_Adresse.Visible = false;
            btn_Modifier.Visible = true;
            btn_enregistrer.Visible = false;
            btn_Annuler.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");
            MySqlCommand cmd = new MySqlCommand("Select Credit from compte WHERE UserN ='" + User + "'", cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                String Cred = dt.Rows[0]["Credit"].ToString();
                Cre = Cred;
            }
            lbl_Credit.Text = Cre.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "choose image(*.JPG;*.PNG;)|*.jpg;*.png;";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picture_profil.Image = Image.FromFile(opf.FileName);

            }
        }

        byte[] img;
        public Profil(String Nom, String Prenom, String User, String Pass, String Adresse, string Credit, Byte[] img)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.User = User;
            this.Pass = Pass;
            this.Adresse = Adresse;
            this.Credit = Credit;
            this.img = img;
            InitializeComponent();

        }

        private void Profil_Load(object sender, EventArgs e)
        {
            lbl_nom.Text = Nom;
            lbl_prenom.Text = Prenom;
            lbl_adresse.Text = Adresse;
            lbl_Credit.Text = Credit.ToString();
            MemoryStream ms = new MemoryStream(img);
            picture_profil.Image = Image.FromStream(ms);

            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
