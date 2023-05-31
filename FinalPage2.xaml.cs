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
    /// Логика взаимодействия для FinalPage2.xaml
    /// </summary>
    public partial class FinalPage2 : Page
    {
        public FinalPage2()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow.BiA + mainWindow.EiZ != 0 && mainWindow.EAiI + mainWindow.IPiL + mainWindow.M + mainWindow.WFiF == 0)
            {
                last.Text = mainWindow.BiAorEizdesc();
            }
            if (mainWindow.EAiI + mainWindow.IPiL != 0 && mainWindow.BiA + mainWindow.EiZ + mainWindow.M + mainWindow.WFiF == 0)
            {
                last.Text = mainWindow.EAiIorIPiLdesc();
            }
            if (mainWindow.M + mainWindow.WFiF != 0 && mainWindow.EAiI + mainWindow.IPiL + mainWindow.BiA + mainWindow.EiZ == 0)
            {
                last.Text = mainWindow.MorWFiFdesc();
            }

        }
    }
}
