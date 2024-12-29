
 *                                                                   SAKARYA ÜNİVERSİTESİ 
 *                                                        BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 *                                                              BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ 
 *                                                             NESNEYE DAYALI PROGRAMLAMA DERSİ
 *                                                                 2020-2021 BAHAR DÖNEMİ 
 *                                                            
 *                                                            ÖDEV NUMARASI:1
 *                                                            ÖĞRENCİ ADI: FATMANUR YILDIZ
 *                                                            ÖĞRENCİ NUMARASI: G201210370
 *                                                            DERSİN ALINDIĞI GRUP: 2.ÖĞRETİM A GRUBU 
 *                                                            
  */

using System;

namespace Odev1_NDP
{
    class Program
    {
        static void Main(string[] args)
        {  //Sekiz satır ve sekiz sütun olması için string türünde dizi adında iki boyutlu bir dizi tanımladım. 
            //String türünde tanımladım çünkü sonradan K atabileyim diye. 
            string[,] dizi = new string[8, 8]{
            {"0","0","0","0","0","0","0","0"},
            { "0","0","0","0","0","0","0","0"},
            { "0","0","0","0","0","0","0","0"},
            { "0","0","0","0","0","0","0","0"},
            { "0","0","0","0","0","0","0","0"},
            { "0","0","0","0","0","0","0","0"},
            { "0","0","0","0","0","0","0","0"},
            { "0","0","0","0","0","0","0","0"},
        };
            Random rnd = new Random();
            //İlk kalemiz diğer kalelere bağlı olmayacak, ilk kale diğerleri tarafından yenme durumu olamaz.
            //Bu yüzden rastgele bir konum belirleyip buna ilk kaleyi atıyorum. 
            int x = rnd.Next(0, 8);
            //x düzlemimiz için (8 bölümümüz var) rastgele bir indeks belirliyoruz. 
            int y = rnd.Next(0, 8);
            //y düzlemimiz için (Gene sekiz bölümümüz var) rastgele bir indeks belirliyoruz.
            //Bu belirlediğimiz iki noktaya rastgele ilk kalemizi atayacağız. Sonrasında diğer kalelerimizi yerleştirirken sütun ve satır kontrolü yapacağız. 
            dizi[x, y] = "K";
            //Dizimizin rastgele seçtiğimiz koordinatlardaki noktaya ilk kalemizi yerleştiriyoruz.
            int sayac = 0;
            int sayac2 = 0;
            //İlk kalemizi yerleştirdikten sonra yazdırıyoruz. 
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(dizi[i, j] + " ");


                }
                Console.WriteLine();

            }
            Console.WriteLine("-------------------------------");

            //8x8'lik bir matriste 8 kale olabilir diye düşündüm maksimumum bu yüzden, 
            while (sayac2 <= 7)
            {
                //X ve y koordinatları için yeni iki tane rastgele sayı belirledim. 
                int x2 = rnd.Next(0, 8);
                int y2 = rnd.Next(0, 8);

                //Sütunum y3 değerim sabit kalırken z değişkeni 0'dan 8' e kadar satırları dönecek bir döngü tanımladım ve o satırda eğer K değeri görürse döngüyü kıracak. 
                //Çünkü satırı adım adım ararken bir K varsa eğer -else bloğunda- döngüyü kırmasını boşuna daha aramamasını söyledim. 
                for (int z = 0; z < 8; z++)
                {
                    if (dizi[z, y2] != "K")
                    {
                        //Eğer o satırda hiç K değeri yoksa sayac değerimiz 8 olacak.
                        sayac++;
                    }
                    else
                    { //Eğer bir tane bile K değeri varsa for döngüsünü kıralım.
                        break;
                    }

                }

                //Satır değerim x3 rastgele değeriyken sütunları dönmek için for tanımladım.
                for (int t = 0; t < 8; t++)
                {
                    if (dizi[x2, t] != "K")
                    {//Eğer t değeri dönerken o sütunun o indeksinde K değeri yoksa sayacımızı bir arttıracağım. Sütunun tamamında yoksa 8 olur maksimum zaten.
                        sayac++;
                    }
                    else
                    {
                        break;
                        //Eğer bir tane bile K değeri varsa for döngüsünü kıralım. 
                    }
                }

                //Eğer iki döngüde döndüklerinde sayaçlar 16 olursa yani her satırı ve sütunu taradıklarında o satırda ve sütunda Kale bulunmamışsa o noktaya kale atadım. 
                if (sayac == 16)

                {

                    //Eğer satır ve sütunda bulunmuyorsa K o noktaya atadık K'yı. 
                    dizi[x2, y2] = "K";
                    //Tahtayı yazdırmak için bir döngü kuruyorum. Eğer sayacım 16'ya eşitse yani her döngünün başında random sayı olarak ürettiğim x2, satırının koordinatı olduğu satırın hiçbir
                    //indeksinde ve aynı şekilde y2 sütunun indeksinde K değeri yoksa ekrana yazmasını sağladım. 
                    for (int z = 0; z < 8; z++)
                    {
                        for (int t = 0; t < 8; t++)

                        {
                            Console.Write(dizi[z, t] + " ");

                        }
                        Console.WriteLine();

                    }

                    Console.WriteLine("-------------------------------");

                    //Maksimumum 8 kale olacağı için her kale atadıktan sonra sayacı bir arttırdım ki while ile kontrolü sağlayabileyim.
                    sayac2++;

                }
                //Her düngü başlangıcında sayac değerini sıfırladım ki 16'yı zaten geçmiş olur -eğer satırda ve sütunda yoksa K- ikinci döngüde. 
                sayac = 0;

            }
