namespace belge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double edb()
        {
            return Convert.ToDouble(textBoxEdebýyat.Text);
        }
        double mat()
        {
            return Convert.ToDouble(textBoxMat.Text);        
        }
        double ýng()
        {
            return Convert.ToDouble(textBoxIngýlýzce.Text);
        }
        double fýzýk()
        {
            return Convert.ToDouble(textBoxFýzýk.Text);
        }
        double kýmya()
        {
            return Convert.ToDouble(textBoxKýmya.Text);
        }
        double býyolcý()
        {
            return Convert.ToDouble(textBoxBýy.Text);
        }
        double tarýh()
        { 
            return  Convert.ToDouble(textBoxTar.Text);
        }
        double cograf()
        {
            return Convert.ToDouble(textBoxCograf.Text);
        }
        double dýnKulturu()
        {
            return Convert.ToDouble(textBoxDýnBýlgýs.Text);
        }double beden()
        {
            return Convert.ToDouble(textBoxBeden.Text);
        }double sanat()
        {
            return Convert.ToDouble(textBoxSanat.Text);
        }
        double temelDýn()
        {
            return Convert.ToDouble(textBoxSecmelýDýn.Text);
        }
        double uzay()
        {
            return Convert.ToDouble(textBoxUzay.Text);
        }
        double BTT()
        {
            return Convert.ToDouble(textBoxBýlýsýmTekno.Text);
        }
        double PT()
        {
            return Convert.ToDouble(textBoxProgramlamaTemellerý.Text);
        }
        double tasýrým()
        {
            return Convert.ToDouble(textBoxBýlgýsayTasarýmUy.Text);
        }

        double Mga()
        {
            return Convert.ToDouble(textBoxMeslekýGelýsým.Text);
        }
        double dýsýplýn()
        {
            return Convert.ToDouble(textBoxDýsýplýnMýktarý.Text);
        }
         
         


        private void buttonBelgeBulucu_click(object sender, EventArgs e)
        {

            double  çarpýmlarý = (edb()*5)+(mat()*5)+(ýng()*4)+(fýzýk()*2)+(kýmya()*2)+(býyolcý()*2)+(tarýh()*2)+(cograf()*2)+(dýnKulturu()*2)+(beden()*2)+(sanat()*2)+(temelDýn()*1)+(uzay()*2)+(BTT()*3)+(PT()*4)+( tasýrým()*2)+(Mga()*2)  ;
            double genelort = çarpýmlarý / 40;
            
            
            
            
            if (edb() > 100.0 || edb() < 0 || mat() > 100.0 || mat() < 0 || ýng() > 100.0 || ýng() < 0 || fýzýk() > 100.0 || fýzýk() < 0 || býyolcý() > 100.0 || býyolcý() < 0 || tarýh() > 100.0 || tarýh() < 0 || cograf() > 100.0 || cograf() < 0 || dýnKulturu() > 100.0 || dýnKulturu() < 0 || beden() > 100.0 || beden() < 0 || /*dýnKulturu() > 100.0 || dýnKulturu() < 0 ||*/ uzay() > 100.0 || uzay() < 0 || BTT() > 100.0 || BTT() < 0 || PT() > 100.0 || PT() < 0 || Mga() > 100.0 || Mga() < 0|| tasýrým() > 100.0||tasýrým()<0)
            {
                MessageBox.Show("Yanlýþ sayýsý giriþi yaptýnýz! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show( "yanlýþ sayý giriþi ","sayý hatasý ", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
            }

            if (edb() < 70)
            {
                labelSonucu.Text = "Edebiyat notu 70 altý olduðu için belge alamazsýnýz.";
                labelSonucu.Visible = true;
            }
            else if (dýsýplýn() > 0)
            {
                labelSonucu.Text = "Disiplin cezanýz olduðu için belge alamazsýnýz.";
                labelSonucu.Visible = true;
            }
            else if (genelort >= 85)
            {
                labelSonucu.Text = $"Ortalamanýz {genelort}: Takdir Belgesi Aldýnýz!";
                labelSonucu.Visible = true;
            }
            else if (genelort >= 70)
            {
                labelSonucu.Text = $"Ortalamanýz {genelort}: Teþekkür Belgesi Aldýnýz!";
                labelSonucu.Visible = true;
            }
            else
            {
                labelSonucu.Text = "Ortalamanýz belge almak için yetersiz.";
                labelSonucu.Visible = true;
            }

           
























            //else if (edb() < 70)
            //{
            //    labelSonucu.Text = "Edebiyat ortalamanýz 70 den küçük olduðu için belge alamazsýnýz ";
            //    labelSonucu.Visible = true;
            //}
            //else if (dýsýplýn() > 0)
            //{
            //    labelSonucu.Text = "Disiplin cezasý aldýðýný için belge alamazsýnýz  ";
            //    labelSonucu.Visible = true;
            //}
            //else if ( genelort<75.00 )
            //{
            //    labelSonucu.Text = $"Genel ortalamýnýz {genelort} olduðu için belge  alamadýnýz  ";
            //    labelSonucu.Visible = true;
            //}
            //else if (   genelort<85.00 )
            //{
            //    labelSonucu.Text = $"Genel ortalamýnýz {genelort} olduðu için Teþekkür belgesi aldýnýz ";
            //    labelSonucu.Visible = true;
            //}
            //else
            //{
            //    labelSonucu.Text = $"Genel ortalamýnýz {genelort} olduðu için  Takdir belgesi  belgesi aldýnýz ";
            //    labelSonucu.Visible = true;
            //}


        }
    }   
}
