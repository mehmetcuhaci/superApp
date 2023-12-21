using System.Data.SqlClient;

namespace SuperApp
{
    public partial class LoginFormu : Form
    {

        private string connectionString = "Data Source=DESKTOP-F3LQC2T\\SQLEXPRESS; Initial Catalog=db_superapp; Integrated Security=TRUE";

        public LoginFormu()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                string query = "SELECT kullanici_adi FROM SUPER_KULLANICILAR WHERE kullanici_adi = @username AND kullanici_sifre = @password;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Giriþ Baþarýlý!");
                                this.Hide();
                                FeedForm frm = new FeedForm();
                                frm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Hatalý!");
                            }
                        }
                    }
                }



            }
            catch (Exception ex)
            {




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitFormu frm = new KayitFormu();
            frm.ShowDialog();
            this.Close();

        }
    }
}


