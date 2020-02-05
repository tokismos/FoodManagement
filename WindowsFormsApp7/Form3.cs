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
    public partial class Form3 : Form
    {
        float Credit;
        String UserName;
        String Cre;
        public Form3(String UserName, float Credit)
        {
            this.Credit = Credit;
            this.UserName = UserName;
            InitializeComponent();
        }
        MySqlConnection cnn3 = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");

        MySqlConnection cnn2 = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");

        MySqlConnection cnn = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");
        MySqlCommand cmd;




        private void Form3_Load(object sender, EventArgs e)
        {
            load();
        }
        public void Fill()
        {
            cnn.Open();
            int Prix = 0;
            cmd = new MySqlCommand("select nom,prix,quantite from panier", cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["nom"].ToString());
                item.SubItems.Add(dr["prix"].ToString());
                item.SubItems.Add(dr["quantite"].ToString());

                listView1.Items.Add(item);

                Prix += int.Parse(dr["prix"].ToString());
            }

            label1.Text = Prix.ToString();
            cnn.Close();
        }
        public void load()
        {
            Fill();
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn3.Open();
            if (int.Parse(label1.Text) != 0)
            {
                cmd = new MySqlCommand("Select Credit from compte WHERE UserN ='" + UserName + "'", cnn3);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    String Cred = dt.Rows[0]["Credit"].ToString();
                    Cre = Cred;
                }

                if (float.Parse(Cre) < float.Parse(label1.Text.ToString()))
                {
                    MessageBox.Show("Achat impossible,Veuillez recharger votre compte!");
                }
                else
                {
                    if (MessageBox.Show("Voullez vous vraiment effectuer le payement?", "Confirmation", MessageBoxButtons.YesNo
                        ) == System.Windows.Forms.DialogResult.Yes)
                    {



                        MySqlCommand cmd = new MySqlCommand("UPDATE compte SET Credit= @credit WHERE UserN = @user", cnn3);
                        cmd.Parameters.AddWithValue("@credit", float.Parse(Cre) - float.Parse(label1.Text.ToString()));
                        cmd.Parameters.AddWithValue("@user", UserName);


                        Time.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
                        cnn.Open();
                        MySqlCommand cmd1 = new MySqlCommand("select nom,prix,quantite from panier", cnn);
                        MySqlDataReader dr = cmd1.ExecuteReader();
                        while (dr.Read())
                        {
                            MySqlCommand cmd2 = new MySqlCommand("INSERT INTO `historique`(`Nom`, `Quantite`, `Prix`, `Date`) VALUES (@nom,@quantite,@prix,@date)", cnn2);
                            cmd2.Parameters.AddWithValue("@nom", dr["nom"].ToString());
                            cmd2.Parameters.AddWithValue("@quantite", dr["quantite"].ToString());
                            cmd2.Parameters.AddWithValue("@prix", dr["prix"].ToString());
                            cmd2.Parameters.AddWithValue("@date", Time.Text);
                            cnn2.Open();
                            cmd2.ExecuteNonQuery();
                            cnn2.Close();


                            cmd.ExecuteNonQuery();


                        }
                        cnn2.Open();
                        MySqlCommand cmd4 = new MySqlCommand("Delete from panier", cnn2);
                        cmd4.ExecuteNonQuery();

                        listView1.Items.Clear();

                        MessageBox.Show("Achat Effectué!!");

                        cnn2.Close();
                        cnn3.Close();
                        cnn.Close();

                        load();
                        cnn3.Close();
                    }
                    else { }

                }
            }
            else
            {
                MessageBox.Show("Votre Panier est Vide!");
                cnn3.Close();
            }
            cnn3.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            label4.Text = listView1.SelectedItems[0].Text.ToString();

        }

        private void btn_Anuler_Click(object sender, EventArgs e)
        {
            if (label4.Text != "")
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `panier` WHERE nom=@id", cnn);
                cmd.Parameters.AddWithValue("@id", label4.Text);
                cnn.Open();
                cmd.ExecuteNonQuery();

                cnn.Close();
                listView1.Items.Clear();
                label4.Text = "";
                Fill();
                MessageBox.Show("Suppression reussie");

                
            }
            else
            {
                MessageBox.Show("Veuillez selectionner l'item à supprimer!");
             
            }

            }
    }   

      
    
}
