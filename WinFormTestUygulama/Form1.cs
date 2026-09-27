using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormTestUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Baglanti();

        }

        public MySqlConnection Baglanti() //Bu þekilde metodumuzun bir baðlantý döndürmesini saðladýk. Mesaj vermeye gerek yok, kaldýrýyorum.
        {
            // Kullanýcý adý default root password yok.
            MySqlConnection conn = new MySqlConnection("Server=localhost; Database=okul; Uid='root'; Pwd=''");

            //conn.Open(); // Doðru kullaným if bloðuyla kontrol etmek.

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open(); // Hatta try catch e sokmak daha doðru olur.

                    // MessageBox.Show("Baðlantý Baþarýlý. Baðlantý: " + conn.State);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);// Hata mesajý kalabilir.
            }

            return conn;
        }

        private void btnFrmOgrenci_Click(object sender, EventArgs e)
        {
            FrmAddStudent frm = new FrmAddStudent();
            frm.ShowDialog();
            dgwOgrenciListesi.DataSource = OgrenciListesi();// Dialog form kapandýðýnda öðrenci listesini otomatik yenileyecek.
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            dgwOgrenciListesi.DataSource = OgrenciListesi();


        }

        public DataTable OgrenciListesi() // Öðrenci Listesini çekip data tableye aktaran metod
        {
            // Yine baðlantýya ve sql cümlesine ihtiyacýmýz var.
            //Daha modüler kullanmak için baðlantý kodlarýmýzý bir metot haline getiriyorum.

            DataTable dt = new DataTable(); // bir tana sanal data table oluþturduk.

            using (Baglanti()) //Metodu çaðýrdýk.
            {
                string sqlCumlesi = "Select * from Ogrenciler";

                using (MySqlDataAdapter da = new MySqlDataAdapter(sqlCumlesi, Baglanti())) // veriyi doldurmal için bir data adapter
                {
                    da.Fill(dt); // ve burada data tableye çektiðimiz veriyi doldurduk.
                }
            }
            // ekranda göstermek için dgwOgrenciLÝstesi datagridview e yükleyeceðiz.
            return dt;
        }

        private void btnFrmUpdate_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(dgwOgrenciListesi.CurrentRow.Cells["id"].Value);
            string ad = dgwOgrenciListesi.CurrentRow.Cells["ad"].Value.ToString()!; // Boþ olabileceðini söylüyor. Çok önemli deðil ama sonuna bir ! koyarsak verinin boþ olmayacaðýna garanti vermiþ oluruz.
            string soyad = dgwOgrenciListesi.CurrentRow.Cells["soyad"].Value.ToString()!;
            string numara = dgwOgrenciListesi.CurrentRow.Cells["numara"].Value.ToString()!;
            string sinif = dgwOgrenciListesi.CurrentRow.Cells["sinif"].Value.ToString()!;
            string telefonu = dgwOgrenciListesi.CurrentRow.Cells["telefon"].Value.ToString()!;


            FrmUpdate frm = new FrmUpdate(secilenId, ad, soyad, numara, sinif, telefonu); // Açmak istediðimiz formun parametre istediðini bizim parametre göndermediðimz için kýzýyor.
            frm.ShowDialog();

            dgwOgrenciListesi.DataSource = OgrenciListesi(); // Güncelleme iþlemi bitip formu kapattýðýmýzda kod çalýþacak ve listeyi yenileyecek.
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //DataGridView e verileri yüklemek için ayný kodu tekrar yazmamak için ilgili kodu da metod  haline getirelim.

            dgwOgrenciListesi.DataSource = OgrenciListesi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(dgwOgrenciListesi.CurrentRow.Cells["id"].Value);

            DialogResult onay = MessageBox.Show($"Seçilen {secilenId} numaralý kaydý silmek istediðinizden emin misiniz?", 
                " Silinecek Kayýt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay==DialogResult.Yes)
            {
            string sqlText = "Delete From Ogrenciler where id=@id";
            MySqlCommand cmd = new MySqlCommand(sqlText, Baglanti());
            cmd.Parameters.AddWithValue("id", secilenId);

            cmd.ExecuteNonQuery();
            Baglanti().Close();

                MessageBox.Show("Kayýt silinmiþtir.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);


                dgwOgrenciListesi.DataSource = OgrenciListesi();//Listeyi otomatik yenilenmesi için bu kodu burada tekrar çalýþtýrdýk.
            }
           

        }
    }
}

//Öðrenci listesini ana sayfada gösterelim.
// Öðrenciyi ekledik, ana sayfada listeledik, þimdi güncelleyelim.
// Güncellemek için yeni bir form oluþturuyoruz.
// Ekleme de kullandýðýmýz ayný kontroller olacaðý için ekle formundan kontrolleri kopyalýyorum
// Þimdi Gridview de seçtiðimiz öðrenciyi güncelle formunu göndermemiz lazým. Önce veriyi alalým.
// Silme iþlemi ...
// Silme Ýþlemi için onay sorusu yapalým.
// sonra da liste otomatil olarak yenilensin.
// Listenin otomatik yenilenmesini kayýt ekleme ve güncellemeden sonra da yapalým.
// Veri tabanýný kullanýcý adý þifre için ayarlamadýk ama statik bir kullanýcý adý ve þifreyle bir de kullanýcý giriþ paneli yapalým.
// Kullanýcý adý admin, þifre 12345 olsun
// önce formu yapalým.