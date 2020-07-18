using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesAgi
{
    class VeriOkuma
    {
        public List<Kriterler> elemanlarListesi(string dosya_yolu)
        {
            List<Kriterler> elemanlar = new List<Kriterler>();
            List<string> credit_history = new List<string>();
            List<string> purpose = new List<string>();
            List<string> employment = new List<string>();
            List<string> personal_status = new List<string>();
            List<string> property_Magnitude = new List<string>();
            List<string> housing = new List<string>();
            List<string> job = new List<string>();
            List<string> own_Telephone = new List<string>();
            List<string> sinif = new List<string>();
            StreamReader oku = new StreamReader(""+ dosya_yolu);
            string[] okunanlar = oku.ReadToEnd().Split('\r', '\n', ',');

            int i = 10;
            do
            {
                if (i % 10 == 0)
                {

                    credit_history.Add(okunanlar[i]);

                }
                else if (i % 10 == 1)
                {

                    purpose.Add(okunanlar[i]);
                }
                else if (i % 10 == 2)
                {
                    employment.Add(okunanlar[i]);

                }
                else if (i % 10 == 3)
                {

                    personal_status.Add(okunanlar[i]);

                }
                else if (i % 10 == 4)
                {
                    property_Magnitude.Add(okunanlar[i]);

                }
                else if (i % 10 == 5)
                {

                    housing.Add(okunanlar[i]);

                }
                else if (i % 10 == 6)
                {

                    job.Add(okunanlar[i]);

                }
                else if (i % 10 == 7)
                {

                    own_Telephone.Add(okunanlar[i]);

                }
                else if (i % 10 == 8)
                {

                    sinif.Add(okunanlar[i]);

                }

                //i=8 olmamasının sebebi 8.satırda surekli boşluk oldugndan dolayı onu es geçtik.
                i++;
            } while (i < okunanlar.Length - 1);
            for (int j = 0; j < credit_history.Count; j++)
            {
                elemanlar.Add(new Kriterler(credit_history[j], purpose[j], employment[j], personal_status[j], property_Magnitude[j], housing[j], job[j], own_Telephone[j], sinif[j]));
            }


            OlasilikHesaplari git = new OlasilikHesaplari();
            git.KriterlerSayilari(elemanlar);
            return elemanlar;
        }
    }
}
