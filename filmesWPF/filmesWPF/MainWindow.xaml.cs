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

namespace IniciandoWpf
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataGrid.ItemsSource = ListaDeNomes;
        }

        List<string> ListaDeNomes = new List<string>
        {
            "O Justiceiro", 
            "Busca Implacável", 
            "O Virgem de 40 Anos", 
            "Em Ritmo de Fuga", 
            "Operação Invasão", 
            "Rota de Fuga",
            "Código de Conduta", 
            "Os Oito Odiados", 
        };
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = null;


            switch (cbxFiltro.SelectedIndex)
            {
                case 0:
                    OrdenarLista();
                    break;
                case 1:
                    FiltarPorLetras(tbxFiltro.Text);
                    break;
                case 2:
                    OrdenarMaiorParaMenor();
                    break;

            }

        }

        private void OrdenarLista()
        {
            DataGrid.ItemsSource = ListaDeNomes.OrderBy(x => x);
        }

        private void FiltarPorLetras(string parametro)
        {
            DataGrid.ItemsSource = ListaDeNomes.Where(x => x.Contains("a"));
        }

        private void OrdenarMaiorParaMenor()
        {
            DataGrid.ItemsSource = ListaDeNomes.OrderByDescending(x => x.Length);
        }

        private void CbxFiltro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
