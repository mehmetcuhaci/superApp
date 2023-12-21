namespace SuperApp
{
    partial class KayitFormu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtKisim = new TextBox();
            txtKSoy = new TextBox();
            txtKTel = new TextBox();
            txtKKulad = new TextBox();
            txtKSifre = new TextBox();
            kayitbtn = new Button();
            label6 = new Label();
            txtKSTekrar = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 51);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "İsim :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 112);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Soyisim :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(78, 185);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Telefon :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(97, 293);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 3;
            label4.Text = "Şifre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(46, 240);
            label5.Name = "label5";
            label5.Size = new Size(124, 21);
            label5.TabIndex = 4;
            label5.Text = "Kullanıcı Adı :";
            // 
            // txtKisim
            // 
            txtKisim.Location = new Point(170, 49);
            txtKisim.Name = "txtKisim";
            txtKisim.Size = new Size(125, 27);
            txtKisim.TabIndex = 5;
            // 
            // txtKSoy
            // 
            txtKSoy.Location = new Point(170, 117);
            txtKSoy.Name = "txtKSoy";
            txtKSoy.Size = new Size(125, 27);
            txtKSoy.TabIndex = 6;
            // 
            // txtKTel
            // 
            txtKTel.Location = new Point(170, 183);
            txtKTel.Name = "txtKTel";
            txtKTel.Size = new Size(125, 27);
            txtKTel.TabIndex = 7;
            // 
            // txtKKulad
            // 
            txtKKulad.Location = new Point(170, 245);
            txtKKulad.Name = "txtKKulad";
            txtKKulad.Size = new Size(125, 27);
            txtKKulad.TabIndex = 8;
            // 
            // txtKSifre
            // 
            txtKSifre.Location = new Point(170, 298);
            txtKSifre.Name = "txtKSifre";
            txtKSifre.Size = new Size(125, 27);
            txtKSifre.TabIndex = 9;
            // 
            // kayitbtn
            // 
            kayitbtn.FlatStyle = FlatStyle.Flat;
            kayitbtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            kayitbtn.Location = new Point(170, 465);
            kayitbtn.Name = "kayitbtn";
            kayitbtn.Size = new Size(94, 29);
            kayitbtn.TabIndex = 10;
            kayitbtn.Text = "Kayıt ";
            kayitbtn.UseVisualStyleBackColor = true;
            kayitbtn.Click += kayitbtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(53, 356);
            label6.Name = "label6";
            label6.Size = new Size(111, 21);
            label6.TabIndex = 11;
            label6.Text = "Şifre Tekrar :";
            // 
            // txtKSTekrar
            // 
            txtKSTekrar.Location = new Point(168, 354);
            txtKSTekrar.Name = "txtKSTekrar";
            txtKSTekrar.Size = new Size(125, 27);
            txtKSTekrar.TabIndex = 12;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(343, 465);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KayitFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 549);
            Controls.Add(button1);
            Controls.Add(txtKSTekrar);
            Controls.Add(label6);
            Controls.Add(kayitbtn);
            Controls.Add(txtKSifre);
            Controls.Add(txtKKulad);
            Controls.Add(txtKTel);
            Controls.Add(txtKSoy);
            Controls.Add(txtKisim);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KayitFormu";
            Text = "KayitFormu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtKisim;
        private TextBox txtKSoy;
        private TextBox txtKTel;
        private TextBox txtKKulad;
        private TextBox txtKSifre;
        private Button kayitbtn;
        private Label label6;
        private TextBox txtKSTekrar;
        private Button button1;
    }
}