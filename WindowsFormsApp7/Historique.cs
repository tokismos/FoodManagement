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

namespace WindowsFormsApp7
{
    public partial class Historique : UserControl
    {
        MySqlConnection cnn = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");
        MySqlCommand cmd;
        public ListViewItem item;
        public Historique()
        {
            InitializeComponent();
        }

        private void Historique_Load(object sender, EventArgs e)
        {
            histo();
            this.listView1.Refresh();
        }

        public  void histo()
        {
            cnn.Open();

            cmd = new MySqlCommand("select Nom,Quantite,Prix,Date from historique", cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                 item = new ListViewItem(dr["Nom"].ToString());
                item.SubItems.Add(dr["Quantite"].ToString());
                item.SubItems.Add(dr["Prix"].ToString());
                item.SubItems.Add(dr["Date"].ToString());


                listView1.Items.Add(item);

               
            }
            cnn.Close();

        
        }

        private void btn_Actualiser_Click(object sender, EventArgs e)
        {
            
            listView1.Items.Clear();
            histo();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }
    }
}
