using ListaAlunos.Classes;
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

namespace ListaAlunos
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataGrid.ItemsSource = Alunos;
        }

        List<Aluno> Alunos = new List<Aluno>
        {
            new Aluno
            {
                Materia = "Matematica",
                NotaMateria = (decimal) 7.5,
            },
            new Aluno
            {
                Materia = "Portugues",
                NotaMateria = (decimal) 9.0,
            },
            new Aluno
            {
                Materia = "Historia",
                NotaMateria = (decimal)10,
            },
            new Aluno
            {
                Materia = "Geografia",
                NotaMateria = (decimal)8.0,
            },
            new Aluno
            {
                Materia = "Educaçao Fisica",
                NotaMateria = (decimal)10,
            },
            new Aluno
            {
                Materia = "Ingles",
                NotaMateria = (decimal)7.0,
            },
            new Aluno
            {
                Materia = "Ciencias",
                NotaMateria = (decimal)10,
            }
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Nota " + (Alunos.Average(x => x.NotaMateria) > 7? "APROVADO":"REPROVADO"));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
