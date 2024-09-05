using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Class_FilePartTwo
{
    internal class Payment
    {
        public DateTime TransactionDate { get; set; }
        public double Price { get; set; }
        public string PaymentType { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        private double Sale { get; set; }
    }
    public string Sale()
    {
        return $"{Payment.ToUpper()[0]}{Name}{Price}";
        MessageBox.Show(country);
    }
}
