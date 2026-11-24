using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Documents;


namespace practiseWork11.Classes
{
    public class StudentRepo
    {
        private List<string> _students = new List<string>();
        public StudentRepo(List<string> students)
        {
            _students = students;
        }
        public void AddName(List<string> Students, string FIO)
        {
            Students.Add(FIO);
        }
        public void RemoveName(List<string> Students, string FIO)
        {
            Students.Remove(FIO);
        }
        public void Clear(List<string> Students)
        {
            Students.Clear();
        }
        public void GetNames(ListBox listBox, List<string> Students)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                listBox.Items.Add(_students[i]);
            }

        }
        public void Count(List<string> Students, TextBlock printResult)
        {

            printResult.Text = $"{Students.Count()}";
        }
    }
}
