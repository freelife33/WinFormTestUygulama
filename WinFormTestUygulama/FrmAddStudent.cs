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

namespace WinFormTestUygulama
{
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Kayıt iç,n bize bir bağlantı ve bir de çalıştıracak sql cümlşesine ihtiyacımız var.
            // Bağlantı vümlesini form1 de yazmıştık, oradan alabiliriz. kopyalayarak

            MySqlConnection conn = new MySqlConnection("Server=localhost; Database=okul; Uid='root'; Pwd=''");

            //Kontrollü kullanacağımız için try ve if bloğuna sokmuyorum. 
            // Şimdi Sql Cümlesini yazacağı. Insert komutunu

            string sqlCumlesi = "Insert into Ogrenciler (ad, soyad, numara, sinif, telefon) Values(@ad, @soyad, @numara, @sinif, @telefon)";
            //@ad, @soyad, @numara, @sinif, @telefon bunlar bizim parametrelerimiz.

            MySqlCommand komut = new MySqlCommand(sqlCumlesi, conn);
            //parametrelerimizi atayalım.
            komut.Parameters.AddWithValue("@ad", txtAd.Text); //Name mi txtAd olan kontrolün text özelliğini aldık.
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@numara", txtNumarasi.Text);
            komut.Parameters.AddWithValue("@sinif", txtSinifi.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefonu.Text);

            //parametreleri atadık şimdi bu komutu çalıştıracağız ama önce bağlantıyı açacağız.

            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();

            //bağlantıyla işimiz bittikten sonra mutlaka bağlantıyı kapatmalıyız.

            MessageBox.Show("Kayıt başarıyla eklendi.");

            txtAd.Clear();
            txtSoyad.Clear();
            txtNumarasi.Clear();
            txtSinifi.Clear();
            txtTelefonu.Clear();


        }
    }
}
