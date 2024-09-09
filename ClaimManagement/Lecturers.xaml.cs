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
using System.Windows.Shapes;

namespace ClaimManagement
{
    /// <summary>
    /// Interaction logic for Lecturers.xaml
    /// </summary>
    public partial class Lecturers : Window
    {
        public Lecturers()
        {
            InitializeComponent();
        }
        private void SubmitClaim_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Claim has been submitted!");
        }
        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            // Logic to upload the document
            MessageBox.Show("Document Uploaded Successfully!");
        }
    }
}
