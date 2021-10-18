﻿using RegistroDetalleModificado.BLL;
using RegistroDetalleModificado.Entidades;
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

namespace RegistroDetalleModificado.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cRoles.xaml
    /// </summary>
    public partial class cRoles : Window
    {
        public cRoles()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Roles>();

            switch (FiltroComboBox.SelectedIndex)
            {
                case 0:
                    listado = RolesBLL.GetRoles();

                    break;
            }

            DatosDataGrid.ItemsSource = null;

            DatosDataGrid.ItemsSource = listado;
        }
    }
}
