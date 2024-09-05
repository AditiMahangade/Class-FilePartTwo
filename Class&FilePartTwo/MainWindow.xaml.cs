using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Class_FilePartTwo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string[] pieces)
        {
            InitializeComponent();


            string[] linesofFile = File.ReadAllLines("SalesJan2009");

            foreach (var line in linesofFile)
            {
                var pieces = line.Split(",");

                Payment p = new Payment();

                p.Price = Double.Parse(pieces[0]);
                p.PaymentType = pieces[1];
                p.Name = pieces[2];
                p.Country = pieces[3];
               

                MasterCardLB.Items.Add(p);
                VisaLB.Items.Add(p);
                DinersLB.Items.Add(p);
                AmexLB.Items.Add(p);

            }
        }
    }
}