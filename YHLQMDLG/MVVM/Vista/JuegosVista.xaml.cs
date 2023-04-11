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

namespace YHLQMDLG.MVVM.Vista
{
    /// <summary>
    /// Lógica de interacción para JuegosVista.xaml
    /// </summary>
    /// juan
    public partial class JuegosVista : UserControl
    {
        public JuegosVista()
        {
            InitializeComponent();
        }

        private void OnBuyButtonClick(object sender, RoutedEventArgs e)
        {

        }


        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            var border = (Border)sender;
            var button = (Button)border.Child;
            button.Visibility = Visibility.Visible;
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            var border = (Border)sender;
            var button = (Button)border.Child;
            button.Visibility = Visibility.Collapsed;
        }

    }
}
