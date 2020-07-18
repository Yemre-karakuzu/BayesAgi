using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesAgi
{
    class OlasilikHesaplari
    {
        public void KriterlerSayilari(List<Kriterler> eleman)
        {
            List<string> credit_history_Variables = new List<string>();
            List<int> credit_history_True = new List<int>();
            List<int> credit_history_False = new List<int>();
            List<int> credit_history_Count = new List<int>();
            List<string> purpose_Variables = new List<string>();
            List<int> purpose_True = new List<int>();
            List<int> purpose_False = new List<int>();
            List<int> purpose_Count = new List<int>();
            List<string> employment_Variables = new List<string>();
            List<int> employment_Count = new List<int>();
            List<int> employment_True = new List<int>();
            List<int> employment_False = new List<int>();
            List<string> personal_status_Variables = new List<string>();
            List<int> personal_status_True = new List<int>();
            List<int> personal_status_False = new List<int>();
            List<int> personal_status_Count = new List<int>();
            List<string> property_Magnitude_Variables = new List<string>();
            List<int> property_Magnitude_True = new List<int>();
            List<int> property_Magnitude_False = new List<int>();
            List<int> property_Magnitude_Count = new List<int>();
            List<string> housing_Variables = new List<string>();
            List<int> housing_True = new List<int>();
            List<int> housing_False = new List<int>();
            List<int> housing_Count = new List<int>();
            List<string> job_Variables = new List<string>();
            List<int> job_True = new List<int>();
            List<int> job_False = new List<int>();
            List<int> job_Count = new List<int>();
            List<string> own_Telephone_Variables = new List<string>();
            List<int> own_Telephone_True = new List<int>();
            List<int> own_Telephone_False = new List<int>();
            List<int> own_Telephone_Count = new List<int>();
            List<string> sinif_Variables = new List<string>();
            List<int> sinif_Count = new List<int>();

            //her bir kriterden kaç tane oldugunu bulunuyor
            for (int i = 0; i < eleman.Count; i++)
            {
                if (!credit_history_Variables.Contains(eleman[i].Credit_history))
                {                  
                    credit_history_Variables.Add(eleman[i].Credit_history);
                    int index = credit_history_Variables.IndexOf(eleman[i].Credit_history);
                    credit_history_Count.Add(1);
                    credit_history_True.Add(0);
                    credit_history_False.Add(0);
                    //her bir kriterin elemanın sınıf etiketlerine bakarak true veya false(bad,good) sayılarını tutuyor.
                    if (eleman[i].Sinif == "bad")
                    {
                        credit_history_True[index]++;
                    }
                    else credit_history_False[index]++;
                }
                else
                {
                    int index = credit_history_Variables.IndexOf(eleman[i].Credit_history);
                    credit_history_Count[index]++;

                    if (eleman[i].Sinif == "bad")
                    {
                        credit_history_True[index]++;
                    }
                    else credit_history_False[index]++;

                }


                if (!purpose_Variables.Contains(eleman[i].Purpose))
                {
                    purpose_Variables.Add(eleman[i].Purpose);
                    int index = purpose_Variables.IndexOf(eleman[i].Purpose);
                    purpose_Count.Add(1);
                    purpose_False.Add(0);
                    purpose_True.Add(0);
                    if (eleman[i].Sinif == "bad")
                    {
                        purpose_True[index]++;
                    }
                    else purpose_False[index]++;

                }
                else
                {
                    int index = purpose_Variables.IndexOf(eleman[i].Purpose);
                    purpose_Count[index]++;

                    if (eleman[i].Sinif == "bad")
                    {
                        purpose_True[index]++;
                    }
                    else purpose_False[index]++;


                }


                if (!employment_Variables.Contains(eleman[i].Employment))
                {
                    employment_Variables.Add(eleman[i].Employment);
                    int index = employment_Variables.IndexOf(eleman[i].Employment);
                    employment_Count.Add(1);
                    employment_True.Add(0);
                    employment_False.Add(0);
                    if (eleman[i].Sinif == "bad")
                    {
                        employment_True[index]++;
                    }
                    else employment_False[index]++;
                }
                else
                {
                    int index = employment_Variables.IndexOf(eleman[i].Employment);
                    employment_Count[index]++;
                    if (eleman[i].Sinif == "bad")
                    {
                        employment_True[index]++;
                    }

                    else employment_False[index]++;

                }



                if (!personal_status_Variables.Contains(eleman[i].Personal_Status))
                {
                    personal_status_Variables.Add(eleman[i].Personal_Status);
                    int index = personal_status_Variables.IndexOf(eleman[i].Personal_Status);
                    personal_status_Count.Add(1);
                    personal_status_True.Add(0);
                    personal_status_False.Add(0);
                    if (eleman[i].Sinif == "bad")
                    {
                        personal_status_True[index]++;
                    }
                    else personal_status_False[index]++;
                }
                else
                {
                    int index = personal_status_Variables.IndexOf(eleman[i].Personal_Status);
                    personal_status_Count[index]++;
                    if (eleman[i].Sinif == "bad")
                    {
                        personal_status_True[index]++;
                    }

                    else personal_status_False[index]++;

                }



                if (!property_Magnitude_Variables.Contains(eleman[i].Property_Magnitude))
                {
                    property_Magnitude_Variables.Add(eleman[i].Property_Magnitude);
                    int index = property_Magnitude_Variables.IndexOf(eleman[i].Property_Magnitude);
                    property_Magnitude_Count.Add(1);
                    property_Magnitude_True.Add(0);
                    property_Magnitude_False.Add(0);
                    if (eleman[i].Sinif == "bad")
                    {
                        property_Magnitude_True[index]++;
                    }
                    else property_Magnitude_False[index]++;
                }
                else
                {
                    int index = property_Magnitude_Variables.IndexOf(eleman[i].Property_Magnitude);
                    property_Magnitude_Count[index]++;

                    if (eleman[i].Sinif == "bad")
                    {
                        property_Magnitude_True[index]++;
                    }

                    else property_Magnitude_False[index]++;

                }



                if (!housing_Variables.Contains(eleman[i].Housing))
                {
                    housing_Variables.Add(eleman[i].Housing);
                    int index = housing_Variables.IndexOf(eleman[i].Housing);
                    housing_Count.Add(1);
                    housing_True.Add(0);
                    housing_False.Add(0);
                    if (eleman[i].Sinif == "bad")
                    {
                        housing_True[index]++;
                    }
                    else housing_False[index]++;
                }
                else
                {
                    int index = housing_Variables.IndexOf(eleman[i].Housing);
                    housing_Count[index]++;

                    if (eleman[i].Sinif == "bad")
                    {
                        housing_True[index]++;
                    }
                    else housing_False[index]++;
                }

                if (!job_Variables.Contains(eleman[i].Job))
                {
                    job_Variables.Add(eleman[i].Job);
                    int index = job_Variables.IndexOf(eleman[i].Job);
                    job_Count.Add(1);
                    job_True.Add(0);
                    job_False.Add(0);
                    if (eleman[i].Sinif == "bad")
                    {
                        job_True[index]++;
                    }
                    else job_False[index]++;
                }
                else
                {
                    int index = job_Variables.IndexOf(eleman[i].Job);
                    job_Count[index]++;

                    if (eleman[i].Sinif == "bad")
                    {
                        job_True[index]++;
                    }

                    else job_False[index]++;

                }

                if (!own_Telephone_Variables.Contains(eleman[i].Own_Telephone))
                {
                    own_Telephone_Variables.Add(eleman[i].Own_Telephone);
                    int index = own_Telephone_Variables.IndexOf(eleman[i].Own_Telephone);
                    own_Telephone_Count.Add(1);
                    own_Telephone_True.Add(0);
                    own_Telephone_False.Add(0);
                    if (eleman[i].Sinif == "bad")
                    {
                        own_Telephone_True[index]++;
                    }
                    else own_Telephone_False[index]++;
                }
                else
                {
                    int index = own_Telephone_Variables.IndexOf(eleman[i].Own_Telephone);
                    own_Telephone_Count[index]++;

                    if (eleman[i].Sinif == "bad")
                    {
                        own_Telephone_True[index]++;
                    }

                    else own_Telephone_False[index]++;


                }

                if (!sinif_Variables.Contains(eleman[i].Sinif))
                {
                    sinif_Variables.Add(eleman[i].Sinif);
                    sinif_Count.Add(1);
                }
                else
                {
                    int index = sinif_Variables.IndexOf(eleman[i].Sinif);
                    sinif_Count[index]++;
                }
            }
        }
        public void ikili_Siniflandirma()
        {

        }
    }
}
