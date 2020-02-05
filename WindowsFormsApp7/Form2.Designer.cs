namespace WindowsFormsApp7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnl_left = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelA = new System.Windows.Forms.Panel();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Credit = new System.Windows.Forms.Label();
            this.btn_Profil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Historique = new System.Windows.Forms.Button();
            this.btn_Commande = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.commander1 = new WindowsFormsApp7.commander();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Panier = new System.Windows.Forms.Button();
            this.pnl_left.SuspendLayout();
            this.panelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(161)))));
            this.pnl_left.Controls.Add(this.label3);
            this.pnl_left.Controls.Add(this.panelA);
            this.pnl_left.Controls.Add(this.btn_Profil);
            this.pnl_left.Controls.Add(this.button1);
            this.pnl_left.Controls.Add(this.btn_Historique);
            this.pnl_left.Controls.Add(this.btn_Commande);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(186, 600);
            this.pnl_left.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Se déconnecter";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.panelA.Controls.Add(this.lbl_Nom);
            this.panelA.Controls.Add(this.pictureBox4);
            this.panelA.Controls.Add(this.label2);
            this.panelA.Controls.Add(this.label1);
            this.panelA.Controls.Add(this.pictureBox1);
            this.panelA.Controls.Add(this.label4);
            this.panelA.Controls.Add(this.lbl_Credit);
            this.panelA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelA.Location = new System.Drawing.Point(0, 0);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(186, 180);
            this.panelA.TabIndex = 0;
            this.panelA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelA_Paint);
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(170)))));
            this.lbl_Nom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nom.ForeColor = System.Drawing.Color.White;
            this.lbl_Nom.Location = new System.Drawing.Point(48, 103);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(69, 23);
            this.lbl_Nom.TabIndex = 2;
            this.lbl_Nom.Text = "label4";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(170)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(106, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vous avez:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connecté en tant que:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(170)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "-ADMIN-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // lbl_Credit
            // 
            this.lbl_Credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(170)))));
            this.lbl_Credit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Credit.ForeColor = System.Drawing.Color.White;
            this.lbl_Credit.Location = new System.Drawing.Point(47, 152);
            this.lbl_Credit.Name = "lbl_Credit";
            this.lbl_Credit.Size = new System.Drawing.Size(64, 28);
            this.lbl_Credit.TabIndex = 2;
            this.lbl_Credit.Text = "50.00";
            this.lbl_Credit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Profil
            // 
            this.btn_Profil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profil.FlatAppearance.BorderSize = 0;
            this.btn_Profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profil.ForeColor = System.Drawing.Color.White;
            this.btn_Profil.Image = ((System.Drawing.Image)(resources.GetObject("btn_Profil.Image")));
            this.btn_Profil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profil.Location = new System.Drawing.Point(0, 302);
            this.btn_Profil.Name = "btn_Profil";
            this.btn_Profil.Size = new System.Drawing.Size(200, 52);
            this.btn_Profil.TabIndex = 1;
            this.btn_Profil.Text = "   Mon profil";
            this.btn_Profil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Profil.UseVisualStyleBackColor = true;
            this.btn_Profil.Click += new System.EventHandler(this.btn_Profil_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "    Accueil";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btn_Acceuil_Click);
            // 
            // btn_Historique
            // 
            this.btn_Historique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Historique.FlatAppearance.BorderSize = 0;
            this.btn_Historique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Historique.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Historique.ForeColor = System.Drawing.Color.White;
            this.btn_Historique.Image = ((System.Drawing.Image)(resources.GetObject("btn_Historique.Image")));
            this.btn_Historique.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Historique.Location = new System.Drawing.Point(0, 244);
            this.btn_Historique.Name = "btn_Historique";
            this.btn_Historique.Size = new System.Drawing.Size(200, 52);
            this.btn_Historique.TabIndex = 1;
            this.btn_Historique.Text = "    Historique";
            this.btn_Historique.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Historique.UseVisualStyleBackColor = true;
            this.btn_Historique.Click += new System.EventHandler(this.btn_Historique_Click);
            // 
            // btn_Commande
            // 
            this.btn_Commande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Commande.FlatAppearance.BorderSize = 0;
            this.btn_Commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Commande.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Commande.ForeColor = System.Drawing.Color.White;
            this.btn_Commande.Image = ((System.Drawing.Image)(resources.GetObject("btn_Commande.Image")));
            this.btn_Commande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Commande.Location = new System.Drawing.Point(0, 186);
            this.btn_Commande.Name = "btn_Commande";
            this.btn_Commande.Size = new System.Drawing.Size(200, 52);
            this.btn_Commande.TabIndex = 1;
            this.btn_Commande.Text = "    Commandes";
            this.btn_Commande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Commande.UseVisualStyleBackColor = true;
            this.btn_Commande.Click += new System.EventHandler(this.btn_Commande_Click);
            // 
            // pnl
            // 
            this.pnl.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pnl.Controls.Add(this.commander1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(186, 53);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(971, 547);
            this.pnl.TabIndex = 1;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint);
            // 
            // commander1
            // 
            this.commander1.BackColor = System.Drawing.SystemColors.Control;
            this.commander1.Location = new System.Drawing.Point(73, 62);
            this.commander1.Name = "commander1";
            this.commander1.Size = new System.Drawing.Size(971, 560);
            this.commander1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(927, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.btn_Panier);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(186, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 53);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_Panier
            // 
            this.btn_Panier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Panier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Panier.Image = ((System.Drawing.Image)(resources.GetObject("btn_Panier.Image")));
            this.btn_Panier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Panier.Location = new System.Drawing.Point(460, -8);
            this.btn_Panier.Name = "btn_Panier";
            this.btn_Panier.Size = new System.Drawing.Size(57, 61);
            this.btn_Panier.TabIndex = 3;
            this.btn_Panier.UseVisualStyleBackColor = true;
            this.btn_Panier.Click += new System.EventHandler(this.btn_Panier_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 600);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Label lbl_Credit;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Profil;
        private System.Windows.Forms.Button btn_Historique;
        private System.Windows.Forms.Button btn_Commande;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Panier;
        private commander commander1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}