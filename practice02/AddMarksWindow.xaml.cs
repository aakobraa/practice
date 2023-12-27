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

namespace practice02
{
    /// <summary>
    /// Логика взаимодействия для AddMarksWindow.xaml
    /// </summary>
    public partial class AddMarksWindow : Window
    {

        public AddMarksWindow()
        {
            InitializeComponent();
        }

        Student student1 = new();
        Student student2 = new();
        Student student3 = new();

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (item1 == cbStudent.SelectedItem)
            {
                int selectedMark = Convert.ToInt32(tbMark.Text);
                DateTime selectedDate = (DateTime)dpDate.SelectedDate;
                int selected = selectedDate.Day;
                student1.AddMark(selectedMark);
                student1.AddDates(selected);
            }
            else if (item2 == cbStudent.SelectedItem)
            {
                int selectedMark = Convert.ToInt32(tbMark.Text);
                DateTime selectedDate = (DateTime)dpDate.SelectedDate;
                int selected = selectedDate.Day;
                student2.AddMark(selectedMark);
                student2.AddDates(selected);
            }
            else if (item3== cbStudent.SelectedItem)
            {
                int selectedMark = Convert.ToInt32(tbMark.Text);
                DateTime selectedDate = (DateTime)dpDate.SelectedDate;
                int selected = selectedDate.Day;
                student3.AddMark(selectedMark);
                student3.AddDates(selected);
            }
            this.Close();
        }
    }
}
