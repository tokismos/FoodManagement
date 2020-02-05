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
    public partial class Panier : UserControl
    {

        MySqlConnection cnn = new MySqlConnection("Server=localhost;DATABASE=food;Uid=admin;Password=123;");
        MySqlCommand cmd;
        public Panier()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panier_Load(object sender, EventArgs e)
        {
            cnn.Open();
            int Prix = 0;
            cmd = new MySqlCommand("select nom,prix,id from panier", cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["nom"].ToString());
                item.SubItems.Add(dr["prix"].ToString());
                item.SubItems.Add(dr["id"].ToString());

                listView1.Items.Add(item);

                Prix += int.Parse(dr["prix"].ToString());
            }

            label1.Text = Prix.ToString();
            cnn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //   label1.Text = Prix.ToString();
    } 
    }

