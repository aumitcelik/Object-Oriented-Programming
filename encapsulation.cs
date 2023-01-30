namespace encapsulation
{
    public class Kitap
    {
        private int sayfaSayisi;
        private String kitapAdi, yazar;


        public Kitap(String kitapAdi, int sayfaSayisi, String yazar)
        {
            this.kitapAdi = kitapAdi;
            this.yazar = yazar;
            if (sayfaSayisi < 1)
            {
                this.sayfaSayisi = 10;
            }
            else
            {
                this.sayfaSayisi = sayfaSayisi;
            }
        }


        public int getSayfaSayisi()
        {
            return this.sayfaSayisi;
        }


        public void setSayfaSayisi(int sayfaSayisi)
        {
            if (sayfaSayisi < 1)
            {
                this.sayfaSayisi = 10;
            }
            else
            {
                this.sayfaSayisi = sayfaSayisi;
            }
        }
    }
}