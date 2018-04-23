using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Program
    {
        /*public static void Main(string[] args)
        {
            
            /*ir iespējams izsaukt uzdevumu, neveidojot objektu, tikai tādas, kuras ir "static", 
             * paša objekta vērtības nav nepieciešamas. piem., "this" izmantot nevarētu, static izmanto tikai tad, ja tā ir palīgfunkcija*/

        // Uzdevums18.Trijsturis();


        public static void Piemeri()
        {
            int[] skaitluMasivs = new int[8];


            int skaitlis = 0;

            skaitluMasivs[0] = 1;
            skaitluMasivs[1] = 2;
            //...
            skaitluMasivs[7] = 8;
            skaitluMasivs[8] = 9; // šī rinda izmestu kļūdu


            int[] skaitluMasivs2 = {
            1, 3, 50, 100, 500
            };//otrs veids, kā definēt masīvu



            for (int i = 0; i < skaitluMasivs.Length; i++)
            {
                //paņem skaitli no masīva, kurša atrodas pozīcijā 'i'
                int skaitlisNoMasiva = skaitluMasivs[i];
                Console.WriteLine(skaitlisNoMasiva);
                Console.ReadLine();

                //nedefinēta vērtība
                /* int? skaitlisNoMasiva = skaitluMasivs[i];
                 if (skaitlisNoMasiva.HasValue)
                 {
                 Console.WriteLine(skaitlisNoMasiva);
                 }
                 else
                 {
                 Console.WriteLine("Nav vērtības");
                 }*/

            }

        }

        public static void Piemers2()
        {
            List<int> skaitluSaraksts = new List<int>();
            skaitluSaraksts.Add(5);
            skaitluSaraksts.Add(7);
            skaitluSaraksts.Add(20);

            List<int> skaitluSaraksts2 = new List<int>()
            {
                5,7,20
            };
            skaitluSaraksts2.Add(100);
            skaitluSaraksts2.AddRange(new[] { 45, 2090, 20 });
            skaitluSaraksts2 = skaitluSaraksts2
                .Where(s => s != 100)//funkcija, ar kuru atlasīsim vērtības, pasakam nosacījumu - visas vērtības, kas nav vienāds 100
                .OrderBy(s => s)// sakārto augošā secībā// OrderByDescending - sakārto dilsošā secībā
                .ToList();// izpilda darbības

            //saīsināts for cikla pieraksts (iziet cauri visiem elementiem, kas ir iekšā)
            foreach (int skaitlis in skaitluSaraksts2)
            {
                Console.WriteLine(skaitlis);
            }
        }
        

    }

 }


//int nosklusētā vērtība ir nulle
//BlackJack, Acīte
//nepiec.Card, Dealer, Player, Deck(kāršu kava - masīvs), Game(spēles loģika)
                               