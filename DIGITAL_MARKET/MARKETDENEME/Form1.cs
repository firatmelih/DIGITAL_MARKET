


/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 03
**				ÖĞRENCİ ADI............: MELIH FIRAT
**				ÖĞRENCİ NUMARASI.......: G191210380
**              DERSİN ALINDIĞI GRUP...: 2C
****************************************************************************/


using System;
using System.Windows.Forms;
namespace MARKETDENEME
{

    public partial class Form1 : Form
    {
        
        class Urunler
        {
            
            private string ad, marka, model, ozellik;
            private int hamfiyat, secilenadet;            
            public int stokadedi;

            

            public string AD
            {
                get { return ad; }
                set { ad = value; }  
            }
            public string MARKA
            {
                get { return marka; }
                set { marka = value; }
            }
            public string MODEL
            {
                get { return model; }
                set { model = value; }
            }
            public string OZELLIK
            {
                get { return ozellik; }
                set { ozellik = value; }
            }

            public int HAMFIYAT
            {
                get { return hamfiyat; }
                set { hamfiyat = value; }
            }
            public int SECILENADET
            {
                get { return secilenadet; }
                set { secilenadet = value; }
            }
        }

        class BUZDOLABI : Urunler 
        {
           private int ichacim;
           private string enerjisinifi;
            public int ICHACIM
            {
                get { return ichacim; } 
                set { ichacim = value; }
            }
            public string ENERJISINIFI
            {
                get { return enerjisinifi; }
                set { enerjisinifi = value; }
            }

        }
        class TV : Urunler
        {
            private int ekranboyutu;
            private string ekrancozunurlugu;
            public int EKRANBOYUTU
            {
                get { return ekranboyutu; }
                set { ekranboyutu = value; }
            }
            public string EKRANCOZUNURLUGU
            {
                get { return ekrancozunurlugu; }
                set { ekrancozunurlugu = value; }
            }

        }

        class TELEFON : Urunler
        {
            private string dahilihafiza,ramkapasitesi,pilgucu;
   
            public string DAHILIHAFIZA
            {
                get { return dahilihafiza; }
                set { dahilihafiza = value; }
            }
            public string RAMKAPASITESI
            {
                get { return ramkapasitesi; }
                set { ramkapasitesi = value; }
            }
            public string PILGUCU
            {
                get { return pilgucu; }
                set { pilgucu = value; }
            }
        }
        class LAPTOP : Urunler
        {
            private string dahilihafiza, ramkapasitesi, pilgucu;
            private int ekranboyutu;
            private string ekrancozunurlugu;
            public string DAHILIHAFIZA
            {
                get { return dahilihafiza; }
                set { dahilihafiza = value; }
            }
            public string RAMKAPASITESI
            {
                get { return ramkapasitesi; }
                set { ramkapasitesi = value; }
            }
            public string PILGUCU
            {
                get { return pilgucu; }
                set { pilgucu = value; }
            }

            public int EKRANBOYUTU
            {
                get { return ekranboyutu; }
                set { ekranboyutu = value; }
            }
            public string EKRANCOZUNURLUGU
            {
                get { return ekrancozunurlugu; }
                set { ekrancozunurlugu = value; }
            }
        }


        TV samsung = new TV();
        BUZDOLABI vestel = new BUZDOLABI();
        TELEFON iphone = new TELEFON();
        LAPTOP casper = new LAPTOP();

        Random rastgele = new Random();
        int randomtv,randomtelefon,randomlaptop,randombuzdolabi;
        double kdvtutaritv,kdvtutaritelefon,kdvtutarilaptop,kdvtutaribuzdolabi;
        int countertv,countertelefon,counterlaptop,counterbuzdolabi = 0;
        double sepet = 0;
        string stokyazitv,stokyazitelefon,stokyazilaptop,stokyazibuzdolabi;
        int adettv,adettelefon,adetlaptop,adetbuzdolabi;
        double kdvlitv, kdvlitelefon, kdvlilaptop, kdvlibuzdolabi=0;
        public Form1()
        {


            InitializeComponent();
            kdvlitv = kdvtutaritv + (samsung.HAMFIYAT * adettv);
            kdvlibuzdolabi = kdvtutaribuzdolabi + (vestel.HAMFIYAT * adetbuzdolabi);
            kdvlitelefon = kdvtutaritelefon + (iphone.HAMFIYAT * adettelefon);
            kdvlilaptop = kdvtutarilaptop + (casper.HAMFIYAT * adetlaptop);
            

            randomtv = rastgele.Next(1, 100);
            randombuzdolabi = rastgele.Next(1, 100);
            randomtelefon = rastgele.Next(1, 100);
            randomlaptop = rastgele.Next(1, 100);
            

            samsung.stokadedi = randomtv;
            vestel.stokadedi = randombuzdolabi;
            iphone.stokadedi = randomtelefon;
            casper.stokadedi = randomlaptop;

            adettv = 0;
            adetlaptop = 0;
            adetbuzdolabi = 0;
            adettelefon = 0;


            samsung.HAMFIYAT = 1000;
            vestel.HAMFIYAT = 2000;
            iphone.HAMFIYAT = 3000;
            casper.HAMFIYAT = 4000;
            
          
            string stokyazitv = samsung.stokadedi.ToString();
            string fiyatyazitv = samsung.HAMFIYAT.ToString();
            string stokyazibuzdolabi = vestel.stokadedi.ToString();
            string fiyatyazibuzdolabi = vestel.HAMFIYAT.ToString();
            string stokyazitelefon = iphone.stokadedi.ToString();
            string fiyatyazitelefon = iphone.HAMFIYAT.ToString();
            string stokyazilaptop = casper.stokadedi.ToString();
            string fiyatyazilaptop = casper.HAMFIYAT.ToString();


            TV_STOK_GOSTERGE.Text = stokyazitv;
            TV_FIYAT_GOSTERGE.Text = fiyatyazitv;
            BUZDOLABI_STOK_GOSTERGE.Text = stokyazibuzdolabi;
            BUZDOLABI_FIYAT_GOSTERGE.Text = fiyatyazibuzdolabi;
            TELEFON_STOK_GOSTERGE.Text = stokyazitelefon;
            TELEFON_FIYAT_GOSTERGE.Text = fiyatyazitelefon;
            LAPTOP_STOK_GOSTERGE.Text = stokyazilaptop;
            LAPTOP_FIYAT_GOSTERGE.Text = fiyatyazilaptop;

        }

        private void Form1_Load(object sender, EventArgs e)
        {      
        }

        private void START_BUTTON_Click(object sender, EventArgs e)
        {
            
            samsung.stokadedi = randomtv;
            vestel.stokadedi = randombuzdolabi;
            iphone.stokadedi = randomtelefon;
            casper.stokadedi = randomlaptop;


            samsung.HAMFIYAT = 1000;
            vestel.HAMFIYAT = 2000;
            iphone.HAMFIYAT = 3000;
            casper.HAMFIYAT = 4000;


            string stokyazitv = samsung.stokadedi.ToString();
            string stokyazibuzdolabi = vestel.stokadedi.ToString();
            string stokyazitelefon = iphone.stokadedi.ToString();
            string stokyazilaptop = casper.stokadedi.ToString();

            
            string fiyatyazitv = samsung.HAMFIYAT.ToString();          
            string fiyatyazibuzdolabi = vestel.HAMFIYAT.ToString();           
            string fiyatyazitelefon = iphone.HAMFIYAT.ToString();            
            string fiyatyazilaptop = casper.HAMFIYAT.ToString();


            TV_STOK_GOSTERGE.Text = stokyazitv;
            BUZDOLABI_STOK_GOSTERGE.Text = stokyazibuzdolabi;
            TELEFON_STOK_GOSTERGE.Text = stokyazitelefon;
            LAPTOP_STOK_GOSTERGE.Text = stokyazilaptop;


            TV_FIYAT_GOSTERGE.Text = fiyatyazitv;
            BUZDOLABI_FIYAT_GOSTERGE.Text = fiyatyazibuzdolabi;
            TELEFON_FIYAT_GOSTERGE.Text = fiyatyazitelefon;           
            LAPTOP_FIYAT_GOSTERGE.Text = fiyatyazilaptop;


            adettv = Convert.ToInt32(TV_NUMERIC.Value);
            adetbuzdolabi = Convert.ToInt32(FRIDGE_NUMERIC.Value);
            adettelefon = Convert.ToInt32(TELEFON_NUMERIC.Value);
            adetlaptop = Convert.ToInt32(LAPTOP_NUMERIC.Value);
         

            randomtv = randomtv - adettv;
            randombuzdolabi = randombuzdolabi - adetbuzdolabi;
            randomtelefon = randomtelefon - adettelefon;
            randomlaptop = randomlaptop - adetlaptop;


            stokyazitv = randomtv.ToString();
            stokyazibuzdolabi = randombuzdolabi.ToString();
            stokyazitelefon = randomtelefon.ToString();
            stokyazilaptop = randomlaptop.ToString();



            TV_STOK_GOSTERGE.Text = stokyazitv;           
            BUZDOLABI_STOK_GOSTERGE.Text = stokyazibuzdolabi;           
            TELEFON_STOK_GOSTERGE.Text = stokyazitelefon;          
            LAPTOP_STOK_GOSTERGE.Text = stokyazilaptop;


            kdvtutaritv = samsung.HAMFIYAT * 0.18 * adettv;
            kdvtutaribuzdolabi = vestel.HAMFIYAT * 0.18 * adetbuzdolabi;
            kdvtutaritelefon = iphone.HAMFIYAT * 0.18 * adettelefon;
            kdvtutarilaptop = casper.HAMFIYAT * 0.18 * adetlaptop;

            sepet += kdvtutaritv+(samsung.HAMFIYAT*adettv);
            sepet += kdvtutaribuzdolabi + (vestel.HAMFIYAT * adetbuzdolabi);
            sepet += kdvtutaritelefon + (iphone.HAMFIYAT * adettelefon);
            sepet += kdvtutarilaptop + (casper.HAMFIYAT * adetlaptop);


            kdvlitv += kdvtutaritv + (samsung.HAMFIYAT * adettv);
            kdvlibuzdolabi += kdvtutaribuzdolabi + (vestel.HAMFIYAT * adetbuzdolabi);
            kdvlitelefon += kdvtutaritelefon + (iphone.HAMFIYAT * adettelefon);
            kdvlilaptop += kdvtutarilaptop + (casper.HAMFIYAT * adetlaptop);


            FIYAT_SONUC.Text = sepet.ToString();


            countertv += 1 * adettv;
            counterbuzdolabi += 1 * adetbuzdolabi;
            countertelefon += 1 * adettelefon;
            counterlaptop += 1 * adetlaptop;


            SIPARIS_ADET_TEXT.Text = countertv.ToString() + "\n" + counterbuzdolabi.ToString()+"\n" + countertelefon.ToString() + "\n" + counterlaptop.ToString();
            SIPARIS_URUN_TEXT.Text = "TELEVIZYON" + "\n" + "BUZDOLABI" + "\n" + "TELEFON" + "\n" + "LAPTOP";
            SIPARIS_FIYAT_TEXT.Text = kdvlitv.ToString() +"\n" + kdvlibuzdolabi.ToString() +"\n" + kdvlitelefon.ToString() +"\n" + kdvlilaptop.ToString();
           
            
            if(sepet!=0)
            { 
            START_BUTTON.Enabled = false;
            }
        }

        private void RESET_BUTTON_Click(object sender, EventArgs e)
        {
            START_BUTTON.Enabled = true;


            randomtv += countertv;
            randombuzdolabi += counterbuzdolabi;
            randomtelefon += countertelefon;
            randomlaptop += counterlaptop;


            countertv = 0;
            counterbuzdolabi = 0;
            countertelefon = 0;
            counterlaptop = 0;


            stokyazitv = randomtv.ToString();
            stokyazibuzdolabi = randombuzdolabi.ToString();
            stokyazitelefon = randomtelefon.ToString();
            stokyazilaptop = randomlaptop.ToString();


            sepet = 0;


            FIYAT_SONUC.Text = "0";


            TV_STOK_GOSTERGE.Text = stokyazitv;
            BUZDOLABI_STOK_GOSTERGE.Text = stokyazibuzdolabi;
            TELEFON_STOK_GOSTERGE.Text = stokyazitelefon;
            LAPTOP_STOK_GOSTERGE.Text = stokyazilaptop;


            LAPTOP_NUMERIC.Value = 0;
            TV_NUMERIC.Value = 0;
            FRIDGE_NUMERIC.Value = 0;
            TELEFON_NUMERIC.Value = 0;


            SIPARIS_ADET_TEXT.Clear();
            SIPARIS_FIYAT_TEXT.Clear();
            SIPARIS_URUN_TEXT.Clear();


            kdvlitv = 0;
            kdvlitelefon = 0;
            kdvlilaptop = 0;
            kdvlibuzdolabi = 0;

        }
    }
}
