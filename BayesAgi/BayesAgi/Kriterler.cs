using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesAgi
{
    class Kriterler
    {
        private string credit_history;
        private string purpose;
        private string employment;
        private string personal_Status;
        private string property_Magnitude;
        private string housing;
        private string job;
        private string own_Telephone;
        private string sinif;
        public Kriterler(string credit_history, string purpose, string employment, string personal_Status, string property_Magnitude, string housing, string job, string own_Telephone, string sinif)
        {
            Credit_history = credit_history;
            Purpose = purpose;
            Employment = employment;
            Personal_Status = personal_Status;
            Property_Magnitude = property_Magnitude;
            Housing = housing;
            Job= job;
            Own_Telephone= own_Telephone;
            Sinif = sinif;
        }

        public string Credit_history { get => credit_history; set => credit_history = value; }
        public string Purpose { get => purpose; set => purpose = value; }
        public string Employment { get => employment; set => employment = value; }
        public string Personal_Status { get => personal_Status; set => personal_Status = value; }
        public string Property_Magnitude { get => property_Magnitude; set => property_Magnitude = value; }
        public string Housing { get => housing; set => housing = value; }
        public string Job { get => job; set => job = value; }
        public string Own_Telephone { get => own_Telephone; set => own_Telephone = value; }
        public string Sinif { get => sinif; set => sinif = value; }
    }
}
