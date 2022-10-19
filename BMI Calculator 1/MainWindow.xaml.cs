
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

namespace BMI_Calculator_1
{
    
    public partial class MainWindow : Window
    {
        public class Customer
        {
            public string lastName { get; set; }
            public string firstName { get; set; }
            public string phoneNumber { get; set; }
            public string heightInches { get; set; }
            public string weightLbs { get; set; }
            public string custBMI { get; set; }
            public string statusTitle { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        
       
        #region Part 1 of the Lab. ClearBtn & ExitBtn
        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            xPhoneNameBox.Text = "";
            xFirstNameBox.Text = "";
            xLastNameBox.Text = "";
            xHeightInchesBox.Text = "";
            xWeightLbsBox.Text = "";
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            Customer customer1 = new Customer();

            customer1.lastName = xLastNameBox.Text;
            customer1.firstName = xFirstNameBox.Text;
            customer1.phoneNumber = xPhoneNameBox.Text;
            

            int currentWeight = 0;
            int currentHeight = 0;
            Int32.TryParse(xWeightLbsBox.Text, out currentWeight);
            Int32.TryParse(xHeightInchesBox.Text, out currentHeight);
            customer1.weightLbs = currentWeight;
            customer1.heightInches = currentHeight;

            int bmi;
            bmi = 703 * customer1.weightLbs / (customer1.heightInches * customer1.heightInches);
            customer1.custBMI = bmi;

            string yourBMIStatus = "NA";
            customer1.statusTitle = yourBMIStatus;

            MessageBox.Show($"the CUstomer's name is {customer1.firstName} {customer1.lastName} and they can be reached at {customer1.phoneNumber}. They are {customer1.heightInches} inches tall. Their weight is {customer1.weightLbs}. Their BMI is {bmi}");
        }

        
    }
}
