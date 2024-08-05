using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PatikaHesaplama
{
    public class GeometrikŞekil//En genel class
    {
        int _yükseklik;
        int _kenarUzunluğu;
        public int Yukseklik {  get; set; }
        public int KenarUuzunluğu {  get; set; }
        public virtual void VeriGirme(int Yukseklik , int KenarUzunluğu)// Genel metot verileri topluyoruz
        {
            Console.WriteLine("Yükseklik ve kenar uzunluğu girildi");
        }
        
    }   
    public class Kare:GeometrikŞekil
    {
        public override void VeriGirme(int Yukseklik, int KenarUzunluğu)// metotu çağırarak özelleştiriyoruz
        {
            base.VeriGirme(Yukseklik, KenarUzunluğu);
            double Alan = Yukseklik * KenarUzunluğu;
            Console.WriteLine("Karenin alanı " + Alan);// kare alanı hesaplamak için işelmeler
        }

    }
    public class Dikdörtgen : GeometrikŞekil
    {
        public override void VeriGirme(int Yukseklik, int KenarUzunluğu)
        {
            base.VeriGirme(Yukseklik, KenarUzunluğu);
            double Alan = Yukseklik * KenarUzunluğu;//dikdörtgenin alanı hesaplama 
            Console.WriteLine("Dikdörtgen alanı" +Alan);

        }
    }
    public class Üçgen : GeometrikŞekil
    {
        public override void VeriGirme(int Yukseklik, int KenarUzunluğu)
        {
            base.VeriGirme(Yukseklik, KenarUzunluğu);
            double Çarpım = Yukseklik * KenarUzunluğu;
            double Alan = Çarpım / 2;//bölme işlemi olduğu için double kullandım
            Console.WriteLine("Üçgenin alanı" +Alan);
        }
    }
}
