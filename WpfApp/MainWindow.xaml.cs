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
using Interface;
using Model;
using Repository;

namespace WpfApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private AdapterRepository repository { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            repository = new AdapterRepository();
            cbEventos.ItemsSource = repository.listaDeDados;
        }

        private void cbEventos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var item = cbEventos.SelectedItem as AdapterInterface;
                txtDetalhes.Text = item.getDetalhes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
