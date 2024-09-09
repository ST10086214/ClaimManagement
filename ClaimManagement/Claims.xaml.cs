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
    /// Interaction logic for Claims.xaml
    /// </summary>
    public partial class Claims : Window
    {
        public Claims()
        {
            InitializeComponent();
            ClaimsDataGrid.ItemsSource = new[] {
                new {ClaimID = 1, Lecturers = "Matlhari Nyathi", Hours = 10, Status = "Pending"},
                new {ClaimID = 2, Lecturers = "Jane Green", Hours = 15, Status = "Approved" }
            };

        }
    }
}
