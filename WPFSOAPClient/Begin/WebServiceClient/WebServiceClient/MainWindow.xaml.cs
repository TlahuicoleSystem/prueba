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

namespace WebServiceClient
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e) 
        {
            double dato1 = Convert.ToDouble(txtInput1.Text);
            double dato2 = Convert.ToDouble(txtInput2.Text);
            ServiceReference1.MyWebServiceSoapClient client = new ServiceReference1.MyWebServiceSoapClient();
            double result = client.sumar(dato1, dato2);
            txtOutput.Text = "" + result;
        }
        private void restaCalculate_Click(object sender, RoutedEventArgs e)
        {
            double dato1 = Convert.ToDouble(txtInput1.Text);
            double dato2 = Convert.ToDouble(txtInput2.Text);
            ServiceReference1.MyWebServiceSoapClient client = new ServiceReference1.MyWebServiceSoapClient();
            double result = client.restar(dato1, dato2);
            txtOutput.Text = "" + result;
        }
        private void mulCalculate_Click(object sender, RoutedEventArgs e)
        {
            double dato1 = Convert.ToDouble(txtInput1.Text);
            double dato2 = Convert.ToDouble(txtInput2.Text);
            ServiceReference1.MyWebServiceSoapClient client = new ServiceReference1.MyWebServiceSoapClient();
            double result = client.mul(dato1, dato2);
            txtOutput.Text = "" + result;
        }

        private void divCalculate_Click(object sender, RoutedEventArgs e)
        {
            double dato1 = Convert.ToDouble(txtInput1.Text);
            double dato2 = Convert.ToDouble(txtInput2.Text);
            ServiceReference1.MyWebServiceSoapClient client = new ServiceReference1.MyWebServiceSoapClient();
            double result = client.div(dato1, dato2);
            txtOutput.Text = "" + result;
        }
        private void POWCalculate_Click(object sender, RoutedEventArgs e)
        {
            double dato1 = Convert.ToDouble(txtInput1.Text);
            double dato2 = Convert.ToDouble(txtInput2.Text);
            ServiceReference1.MyWebServiceSoapClient client = new ServiceReference1.MyWebServiceSoapClient();
            double result = client.potencia(dato1, dato2);
            txtOutput.Text = "" + result;
        }
        private void SQRT_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput2.Text!=""){
                txtInput2.Text = "";
            }
            
                double value1 = Convert.ToDouble(txtInput1.Text);
                ServiceReference1.MyWebServiceSoapClient client = new ServiceReference1.MyWebServiceSoapClient();
                double result = client.raiz(value1);
                txtOutput.Text = "" + result;
            
            
        }
    }
}
