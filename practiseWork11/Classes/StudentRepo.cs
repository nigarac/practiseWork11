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
        public void AddName(string FIO)
        {
            _students.Add(FIO);
        }
        public void RemoveName(string FIO)
        {
            _students.Remove(FIO);
        }
        public void Clear(List<string> Students)
        {
            _students.Clear();
        }
        public void GetNames(ListBox listBox)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                listBox.Items.Add(_students[i]);
            }

        }
        public void Count(TextBlock printResult)
        {

            printResult.Text = $"{_students.Count()}";
        }
        public string PrintNames()
        {
            string PrintNames = "";
            for (int i = 0; i < _students.Count; i++)
            {
                PrintNames += $"{(_students[i].Trim())} ";
            }
            return PrintNames;
        }
        public string PrintNames(string separator = ",")
        {
            string PrintNames = "";
            for (int i = 0; i < _students.Count; i++)
            {
                PrintNames += $"{(_students[i].Trim())}"+separator;
            }
            return PrintNames;
        }
        public string PrintNames(char separator = ',')
        {
            string PrintNames = "";
            for (int i = 0; i < _students.Count; i++)
            {
                PrintNames += $"{(_students[i].Trim())}" + separator;
            }
            separator = ',';
            return PrintNames;
        }
        public string PrintNames(bool sort,string separator = ",")
        {
            string PrintNames = "";

            _students.Sort();
            for (int i = 0; i < _students.Count; i++)
            {
                PrintNames += $"{(_students[i].Trim())}" + separator;
            }
            separator = ",";

            return PrintNames;
        }               
        public string PrintNames(bool sort, bool reverse, string separator = ",")
        {
            string PrintNames = "";
            _students.Sort();
            _students.Reverse();
            for (int i = 0; i < _students.Count; i++)
            {
                PrintNames += $"{(_students[i].Trim())}" + separator;
            }
            separator = ",";

            return PrintNames;
        }
        public string PrintNames(int MaxCount, string separator = ",")
        {

            string PrintNames = "";
            for (int i = 0; i < MaxCount; i++)
            {
                PrintNames += $"{(_students[i].Trim())}" + separator;
            }

            return PrintNames;
        }
    }
}
