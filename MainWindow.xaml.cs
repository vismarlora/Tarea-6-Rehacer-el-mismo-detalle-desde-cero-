using RegistroDetalleModificado.UI.Consultas;
using RegistroDetalleModificado.UI.Registros;
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

namespace RegistroDetalleModificado
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

        private void RegistroRolesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rRoles rol = new rRoles();
            rol.Show();
        }

        private void ConsultaRolesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cRoles rol = new cRoles();
            rol.Show();
        }
    }
}
