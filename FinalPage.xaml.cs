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

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для FinalPage.xaml
    /// </summary>
    public partial class FinalPage : Page
    {
        public FinalPage()
        {
            InitializeComponent();

        }



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            V1.Text = mainWindow.BiAorEiz();
            V2.Text = mainWindow.EAiIorIPiL();
            V3.Text = mainWindow.MorWFiF();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.EAiI = 0;
            mainWindow.IPiL = 0;
            mainWindow.M = 0;
            mainWindow.WFiF = 0;
            mainWindow.NavigateToNextPage();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.BiA = 0;
            mainWindow.EiZ = 0;
            mainWindow.M = 0;
            mainWindow.WFiF = 0;
            mainWindow.NavigateToNextPage();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.BiA = 0;
            mainWindow.EiZ = 0;
            mainWindow.EAiI = 0;
            mainWindow.IPiL = 0;
            mainWindow.NavigateToNextPage();
        }
    }
}
