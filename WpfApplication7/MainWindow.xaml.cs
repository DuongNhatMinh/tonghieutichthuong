using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, RoutedEventArgs e)
        {
            double a = Double.Parse(txta.Text);
            double b = Double.Parse(txtb.Text);
             txtDapan.Text = tong(a, b).ToString();
         }
            public double tong(double a, double b) 
            {
             return a + b;
            }

            private void btnHieu_Click_1(object sender, RoutedEventArgs e)
            {
                double a = Double.Parse(txta.Text);
                double b = Double.Parse(txtb.Text);
                txtDapan.Text = hieu(a, b).ToString();
            }
                public double hieu(double a, double b) 
                {
                  return a - b;
                }

                private void btnTich_Click(object sender, RoutedEventArgs e)
                {
                     double a = Double.Parse(txta.Text);
                     double b = Double.Parse(txtb.Text);
                     txtDapan.Text = tich(a, b).ToString();
                     }
                    public double tich (double a, double b) 
                    {
                        return a * b;
                    }

                    private void btnThuong_Click(object sender, RoutedEventArgs e)
                    {
                        double a = Double.Parse(txta.Text);
                        double b = Double.Parse(txtb.Text);
                        txtDapan.Text = thuong(a, b).ToString();
                     }
                        public double thuong(double a, double b) 
                        {
                         return a / b;
                        }

                        private void btnThoat_Click(object sender, RoutedEventArgs e)
                        {
                            this.Close();
                        }
        }}
            
     

        




    

     
