using System.Collections.Generic;
using System.Windows;
using practiseWork11.Classes;

namespace practiseWork11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {            
        List<string> listStudents = new List<string>();
        StudentRepo object1;
        public MainWindow()
        {
            InitializeComponent();
            object1 = new StudentRepo(listStudents);
        }



        private void addClick(object sender, RoutedEventArgs e)
        {
            object1.AddName($"{FIO.Text}");
        }

        private void clearList_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
