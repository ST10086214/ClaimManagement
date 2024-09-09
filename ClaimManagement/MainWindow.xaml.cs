using System.Windows;

namespace ClaimManagement
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
        //buttons for each window
        
        //home btn
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            ShowHome();
        }
        //staff btn
        private void Staff_Click(object sender, RoutedEventArgs e)
        {
            ShowStaff();
        }
        //claims btn
        private void Claims_Click(object sender, RoutedEventArgs e)
        {
            ShowClaims();
        }

        //lecturer btn
        private void Lecturer_Click(object sender, RoutedEventArgs e)
        {
            ShowLecturers();
        }

        private void ShowHome()
        {
            MainWindow showHome = new MainWindow();
        }

        private void ShowLecturers()
        {
            Lecturers showLecturers = new Lecturers();
        }

        private void ShowClaims()
        {
            Claims showClaims = new Claims();
        }

        private void ShowStaff()
        {
            Staff showStaff = new Staff();
        }
    }


}
