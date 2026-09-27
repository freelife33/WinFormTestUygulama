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
    public partial class FrmUpdate : Form
    {
        int _id; //Yerel değişkenler parametre değişkenle karışmasın diye genel kabul gören kullanım _ ile başlamaktır.
        string _ad;
        string _soyad;
        string _numara;
        string _sinifi;
        string _telefon;
        public FrmUpdate(int id, string ad, string soyad, string numara, string sinif, string telefon)// Buradaki parametrelere direkt olarak ulaşamayz, onun için yerel bir değişkene aktarmamız gerek.
        {

            _id = id;
            _ad = ad;
            _soyad = soyad;
            _numara = numara;
            _sinifi = sinif;
            _telefon = telefon;


            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            lblID.Text = _id.ToString();
            txtAd.Text = _ad;
            txtSoyad.Text = _soyad;
            txtNumarasi.Text = _numara;
            txtSinifi.Text = _sinifi;
            txtTelefonu.Text = _telefon;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Bağlantı ve SqlCümlesine ihtiyacımız var
            MySqlConnection conn = new MySqlConnection("Server=localhost; Database=okul; Uid='root'; Pwd=''");

            string sqlText = "Update Ogrenciler Set ad=@ad, soyad=@soyad, numara=@numara, sinif=@sinif, telefon=@telefon where id=@id";

            MySqlCommand cmd = new MySqlCommand(sqlText, conn);

            cmd.Parameters.AddWithValue("id", _id);
            cmd.Parameters.AddWithValue("ad", txtAd.Text);
            cmd.Parameters.AddWithValue("soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("numara", txtNumarasi.Text);
            cmd.Parameters.AddWithValue("sinif", txtSinifi.Text);// parametrelerin aynı olması gerekiyor. yanlış yazmışım.
            cmd.Parameters.AddWithValue("telefon", txtTelefonu.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show(_id.ToString() + " Kayıt numaralı kayıt başarıyla güncellendi.");

            txtAd.Clear();
            txtSoyad.Clear();
            txtNumarasi.Clear();
            txtSinifi.Clear();
            txtTelefonu.Clear();
            // TextBoxları temizledik.

        }
    }
}

//bu forma veri taşımak için formu parametre alan bir form haline getirmeliyiz.
//Evet gönderdiğimiz veriyi yakaladık. şimdi gerçek veriyi gönderelim.
// gerçek verilerimizi de çektik, artkı değitirmeye geldi sıra...
// Kaydı güncelledik ama listeyi güncellemediğimiz için eski kaydı görüyorduk. Önce textboxların içini boşaltalım sonra listeyi yenileme işini yapalım.

