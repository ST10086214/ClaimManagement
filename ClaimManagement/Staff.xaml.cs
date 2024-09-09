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
    /// Interaction logic for Staff.xaml
    /// </summary>
    public partial class Staff : Window
    {
        public Staff()
        {
            InitializeComponent();
            PendingClaimsDataGrid = new[] {
                new {ClaimID = 1, Lecturer = "John Doe", Hours = 10, Status = "Pending"}
            };
        }

        public object PendingClaimsDataGrid { get; private set; }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Claim Approved!");
        }
        private void RejectClaim_Click(object obj, RoutedEventArgs e) {
            MessageBox.Show("Claim Rejected");
        }
    }
}
