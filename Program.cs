using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n 20 adet sayı giriniz : ");
            ArrayList ArrayList = new ArrayList();
            ArrayList maxArrayList = new ArrayList();
            ArrayList minArrayList = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                ArrayList.Add(Convert.ToInt32(Console.ReadLine()));

            }

            int totalPositiveArr = 0;
            ArrayList.Sort();
            for (int i = 0; i < 3; i++)
            {
                minArrayList.Add(ArrayList[i]);
                totalPositiveArr = totalPositiveArr + Convert.ToInt32(ArrayList[i]);
            }
            int avarageOfMinPosArr = totalPositiveArr / 3;
            Console.WriteLine("Dizi elemanlarının ortalaması : " + avarageOfMinPosArr);

            int totalMaxArr = 0;
            ArrayList.Reverse();
            for (int i = 0; i < 3; i++)
            {
                maxArrayList.Add(ArrayList[i]);
                totalMaxArr = totalMaxArr + Convert.ToInt32(ArrayList[i]);
            }
            int avarageOfMaxPosArr = totalMaxArr / 3;
            Console.WriteLine("Dizi elemanlarının ortalaması : " + avarageOfMaxPosArr);

            Console.WriteLine("Ortalama toplamları : " + (avarageOfMinPosArr + avarageOfMaxPosArr));

        }
    }
}
