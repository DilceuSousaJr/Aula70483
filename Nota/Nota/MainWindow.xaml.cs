using Nota.Model;
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

namespace Nota
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Aluno> Alunos = new List<Aluno>();

        private void Cadastrar_Click(object sender, RoutedEventArgs e)
        {
            Alunos.Add(new Aluno()
            {
                Nome = tbxNome.Text,
                Nota1 = int.Parse(tbxNota1.Text),
                Nota2 = int.Parse(tbxNota2.Text),
                Nota3 = int.Parse(tbxNota3.Text),
            });

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Alunos;
        }
    }
}
