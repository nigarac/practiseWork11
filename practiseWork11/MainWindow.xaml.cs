using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
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

        bool sort = false;
        bool reversee = false;

        private void addClick(object sender, RoutedEventArgs e)
        {
            object1.AddName($"{FIO.Text}");
        }

        private void clearList_Click(object sender, RoutedEventArgs e)
        {
            object1.Clear(listStudents);
            maxCount.Text = "";
            razdelitel.Text = "";
        }

        private void clearStudentButton(object sender, RoutedEventArgs e)
        {
            object1.RemoveName(FIO.Text);
        }

        private void printList_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            if(sortOnFIO.IsChecked==true)
                sort = true;
            if(reverse.IsChecked==true)
                reversee = true;
            string razdelitell = razdelitel.Text;
            string result = "";
            if (int.TryParse(maxCount.Text, out int maxCount2) && maxCount2 > 0 && razdelitell != "")
            {
                result = object1.PrintNames(maxCount2, razdelitell);
            }
            else if (int.TryParse(maxCount.Text, out int maxCount3) && maxCount3 > 0 && razdelitell == "")
            { result = object1.PrintNames(maxCount3); razdelitell = ",";}
            else if (reversee && sort)
            { result = object1.PrintNames(sort, reversee, razdelitell); }
            else if (reversee == false && sort == true)
            { result = object1.PrintNames(sort, razdelitell); }
            else if (razdelitel.Text != "")
            { result = object1.PrintNames(razdelitell); }
            else if (razdelitel.Text == "")
            {
                razdelitell = ",";
                result = object1.PrintNames(razdelitell);

            }
            printResult.Text = result;
            string[] studentsForListBox= result.Split(razdelitell.ToCharArray());
            for (int i = 0; i < studentsForListBox.Length; i++)
            {
                listBox.Items.Add(studentsForListBox[i]);
            }

        }

        private void comboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem is ComboBoxItem selectedItem && comboBox.SelectedIndex > 0)
            {
                razdelitel.Text = selectedItem.Content.ToString();
            }
        }

        private void sortOnFIO_Checked(object sender, RoutedEventArgs e)
        {
            sort = true ;
        }

        private void reverse_Checked(object sender, RoutedEventArgs e)
        {
            reversee = true;
        }
    }
}
