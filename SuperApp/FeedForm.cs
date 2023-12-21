using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperApp
{
    public partial class FeedForm : Form
    {
        private List<Post> posts = new List<Post>();

        public FeedForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = "Kullanici";
            string metin = textBox1.Text;

            Post yeniPost = new Post { KullaniciAdi = kullaniciAdi, Metin = metin, Tarih = DateTime.Now };

            posts.Add(yeniPost);

            uptadeFeed();
        }

        private void uptadeFeed()
        {
            listBox1.Items.Clear();
            foreach (var post in posts) {
                
                listBox1.Items.Add($"{post.KullaniciAdi} ({post.Tarih}): {post.Metin}");
               

            }
        }


    }



    public class Post
    {
        public string KullaniciAdi { get; set; }
        public string Metin { get; set; }
        public DateTime Tarih { get; set; }
    }
}
