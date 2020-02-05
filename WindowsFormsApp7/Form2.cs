using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        int PanelWidth;
       
        Color bluee = Color.FromArgb(0, 70, 161);

        Color blueC= Color.FromArgb(0, 70, 220);
        string reest = Restaurant.reV();
       //public static int reest;
        
        String  Nom,  Prenom, User, Pass, Adresse;
        string Credit;
        byte[] img;
        int iii;
        String Cre;
        UserControl1 admP = new UserControl1();
        commander commander;
        commander commander2;


        public Form2(int ii, String Nom,String Prenom,String User,String Pass,String Adresse,string Credit,byte[] img)
        {
            this.iii = ii;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.User = User;
            this.Pass = Pass;
            this.Adresse = Adresse;
            this.Credit = Credit;
            this.img = img;
            InitializeComponent();
           // UserN = nameE;
            PanelWidth = pnl_left.Width;
            // lbl_Nom.Text = nameE;
            // pnl.Controls.Add(userControl11);
            //userControl11.Show();
            // admP.Hide();

            //  pnl.Controls.Add(admP);
            if (iii == 1)
                button1.Visible = true;

            MemoryStream ms = new MemoryStream(img);
            // imge.Save(ms, ImageFormat.Jpeg);
            // pictureBox3.Image = Image.FromStream(ms);
            


        }

        
        private void Form2_Load(object sender, EventArgs e)
        {

            lbl_Nom.Text = User;
            if (lbl_Nom.Text == "tokismos")
            {
                lbl_Nom.Visible = false;
                lbl_Credit.Visible = false;
                label4.Visible = true ;
                label2.Visible = false;
                btn_Panier.Visible = false;
                pictureBox4.Visible = false;
                btn_Profil.Location=new Point(0, 244);
                pnl.Controls.Clear();
                pnl.Controls.Add(admP);
                button1.Visible = true;
                btn_Commande.Visible = false;
                btn_Historique.Visible = false;

            }
            else
            {
                commander = new commander();
                pnl.Controls.Clear();
                pnl.Controls.Add(commander);
            }
            
            MySqlConnection cnn = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");

            MySqlCommand cmd = new MySqlCommand("Select Credit from compte WHERE UserN ='"+User+"'", cnn);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        

        
        Color blueeC = new Color();

        private void btn_Commande_Click(object sender, EventArgs e)
        {

            btn_Commande.BackColor = blueC;
            button1.BackColor = bluee;
            btn_Historique.BackColor = bluee;
            btn_Profil.BackColor = bluee;
            commander = new commander();
            pnl.Controls.Clear();               
            pnl.Controls.Add(commander);        
             
        }
        
        private void btn_Acceuil_Click(object sender, EventArgs e)
        {
            admP.Visible = true;
            btn_Commande.BackColor = bluee;
            button1.BackColor = blueC;
            btn_Historique.BackColor = bluee;
            btn_Profil.BackColor = bluee;
            pnl.Controls.Clear();
            pnl.Controls.Add(admP);

        }

        Historique hist = new Historique();
        private void btn_Historique_Click(object sender, EventArgs e)
        {
            admP.Visible = false;
            btn_Commande.BackColor = bluee;
            button1.BackColor = bluee;
            btn_Historique.BackColor = blueC;
            btn_Profil.BackColor = bluee;
            pnl.Controls.Clear();
            pnl.Controls.Add(hist);
        }

        private void btn_Profil_Click(object sender, EventArgs e)
        {

            btn_Commande.BackColor = bluee;
            button1.BackColor = bluee;
            btn_Historique.BackColor = bluee;
            btn_Profil.BackColor = blueC;
            pnl.Controls.Clear();
            Profil profil = new Profil(Nom, Prenom, User, Pass, Adresse, Credit, img);
            pnl.Controls.Add(profil);
        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            commander = new commander();

            pnl.Controls.Add(commander);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            commander2 = new commander();
            pnl.Controls.Add(commander2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            Restaurant rest = new Restaurant();
            pnl.Controls.Add(rest);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment vous déconnecter?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
                Form1 fo = new Form1();
                fo.Show();
            }

        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btn_Panier_Click(object sender, EventArgs e)
        {
            float Creedit = float.Parse(Credit);
            Form3 form = new Form3(User,Creedit);
            form.ShowDialog();
            

            
            
        }

        private void commander1_Load(object sender, EventArgs e)
        {

        }
    }
}
