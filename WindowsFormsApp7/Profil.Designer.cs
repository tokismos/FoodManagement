namespace WindowsFormsApp7
{
    partial class Profil
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Adresse = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Credit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picture_profil = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_adresse = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Annuler);
            this.panel1.Controls.Add(this.btn_enregistrer);
            this.panel1.Controls.Add(this.btn_Modifier);
            this.panel1.Controls.Add(this.btn_import);
            this.panel1.Controls.Add(this.txt_Adresse);
            this.panel1.Controls.Add(this.txt_Prenom);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.lbl_Credit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.picture_profil);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_adresse);
            this.panel1.Controls.Add(this.lbl_prenom);
            this.panel1.Controls.Add(this.lbl_nom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(182, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 449);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic);
            this.txt_Adresse.Location = new System.Drawing.Point(269, 282);
            this.txt_Adresse.Multiline = true;
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(190, 49);
            this.txt_Adresse.TabIndex = 6;
            this.txt_Adresse.Visible = false;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic);
            this.txt_Prenom.Location = new System.Drawing.Point(269, 244);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(100, 23);
            this.txt_Prenom.TabIndex = 6;
            this.txt_Prenom.Visible = false;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(269, 201);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 23);
            this.txt_Name.TabIndex = 6;
            this.txt_Name.Visible = false;
            // 
            // lbl_Credit
            // 
            this.lbl_Credit.AutoSize = true;
            this.lbl_Credit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Credit.Location = new System.Drawing.Point(280, 348);
            this.lbl_Credit.Name = "lbl_Credit";
            this.lbl_Credit.Size = new System.Drawing.Size(60, 20);
            this.lbl_Credit.TabIndex = 4;
            this.lbl_Credit.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(167, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Credit:";
            // 
            // picture_profil
            // 
            this.picture_profil.Image = ((System.Drawing.Image)(resources.GetObject("picture_profil.Image")));
            this.picture_profil.Location = new System.Drawing.Point(194, 3);
            this.picture_profil.Name = "picture_profil";
            this.picture_profil.Size = new System.Drawing.Size(163, 153);
            this.picture_profil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_profil.TabIndex = 2;
            this.picture_profil.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(67, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adresse de livraison:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(158, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom:";
            // 
            // lbl_adresse
            // 
            this.lbl_adresse.AutoSize = true;
            this.lbl_adresse.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_adresse.Location = new System.Drawing.Point(280, 282);
            this.lbl_adresse.Name = "lbl_adresse";
            this.lbl_adresse.Size = new System.Drawing.Size(47, 20);
            this.lbl_adresse.TabIndex = 0;
            this.lbl_adresse.Text = "Nom:";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_prenom.Location = new System.Drawing.Point(280, 244);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(47, 20);
            this.lbl_prenom.TabIndex = 0;
            this.lbl_prenom.Text = "Nom:";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_nom.Location = new System.Drawing.Point(280, 198);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(47, 20);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "Nom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.White;
            this.btn_import.Location = new System.Drawing.Point(218, 156);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(119, 29);
            this.btn_import.TabIndex = 11;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Visible = false;
            this.btn_import.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modifier.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier.ForeColor = System.Drawing.Color.White;
            this.btn_Modifier.Location = new System.Drawing.Point(434, -2);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(151, 29);
            this.btn_Modifier.TabIndex = 11;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = false;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enregistrer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.ForeColor = System.Drawing.Color.White;
            this.btn_enregistrer.Location = new System.Drawing.Point(156, 391);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(151, 29);
            this.btn_enregistrer.TabIndex = 11;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = false;
            this.btn_enregistrer.Visible = false;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Annuler.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Annuler.ForeColor = System.Drawing.Color.White;
            this.btn_Annuler.Location = new System.Drawing.Point(365, 391);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(151, 29);
            this.btn_Annuler.TabIndex = 11;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = false;
            this.btn_Annuler.Visible = false;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Profil";
            this.Size = new System.Drawing.Size(971, 560);
            this.Load += new System.EventHandler(this.Profil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_profil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_profil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Credit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_adresse;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txt_Adresse;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_Modifier;
    }
}
