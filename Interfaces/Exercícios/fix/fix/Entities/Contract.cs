using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace fix.Entities {
    class Contract {

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public override string ToString() {
            string s = "";

            for (int i = 0; i < Installments.Count; i++) {
                s += Installments[i].DueDate.ToString("dd/MM/yyyy") + " - " + Installments[i].Amount.ToString("F2", CultureInfo.InvariantCulture) + "\n";
            }

            return s;
        }
    }
}
