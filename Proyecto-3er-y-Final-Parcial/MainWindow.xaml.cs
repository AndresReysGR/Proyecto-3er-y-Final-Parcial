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
using System.Collections.ObjectModel;

namespace Proyecto_3er_y_Final_Parcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        ObservableCollection<CaracteristicasPeliculas> CaracterP = new ObservableCollection<CaracteristicasPeliculas>();
        public MainWindow()
        {
            InitializeComponent();
            CaracterP.Add
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grdAgregar.Children.Clear();
            grdAgregar.Children.Add(new SerieyPelicula());
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LstSeriesPeliculas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
