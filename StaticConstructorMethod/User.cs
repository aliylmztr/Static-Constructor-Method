using System;

namespace StaticConstructorMethod
{
    class User
    {
        private int id;
        private string isim;
        private string soyisim;
        private static int maas;

        static User()
        {
            maas = 2500;
        }

        public User(int id, string isim, string soyisim)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("Kullanıcı Bilgileri");
            Console.WriteLine("Id: " + id);
            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Maaş: " + maas);
        }

        public void zamYap(int zam)
        {
            Console.WriteLine("Kullanıcıya zam yapılıyor...");
            Console.WriteLine("Yeni maaşı: " + (maas + zam));
        }
    }
}
