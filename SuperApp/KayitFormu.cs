using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperApp
{
    public partial class KayitFormu : Form
    {
        private string connectionString = "Data Source=DESKTOP-F3LQC2T\\SQLEXPRESS; Initial Catalog=db_superapp; Integrated Security=TRUE";
        public KayitFormu()
        {
            InitializeComponent();
        }

        private void kayitbtn_Click(object sender, EventArgs e)
        {
            string username = txtKisim.Text;
            string surname = txtKSoy.Text;
            string password = txtKSifre.Text;
            string phone = txtKTel.Text;
            string kulname = txtKKulad.Text;
            string checkPassword = txtKSTekrar.Text;

            int minLenght = 8, maxLenght = 15;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(kulname) ||
                 string.IsNullOrWhiteSpace(checkPassword) || string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!");
                return;
            }
            if (password.Length < minLenght)
            {
                MessageBox.Show("Şifre 8 karakterden fazla olmalı!");
                return;
            }
            if (password.Length > maxLenght)
            {
                MessageBox.Show("Şifre 15 karakterden fazla olmamalı!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string insertQuery = "INSERT INTO SUPER_KULLANICILAR (kullanici_isim, kullanici_soyad, kullanici_sifre, kullanici_tel,kullanici_adi) " +
                   "VALUES (@username, @surname, @password, @phone,@kulname)";

                using (SqlCommand command = new SqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@kulname", kulname);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Kayıt Başarılı!");
                conn.Close();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFormu frm= new LoginFormu();
            frm.ShowDialog();
            this.Close();

        }
    }
}
