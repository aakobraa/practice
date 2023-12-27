using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practice02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Student student1 = new();
        Student student2 = new();
        Student student3 = new();
        Teacher teacher = new();


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Users.userRole = string.Empty;
            Autorization autoriz = new();
            autoriz.Owner = this;
            autoriz.ShowDialog();
            canvas.Children.Clear();

            student1.marks.Add(5);
            student1.marks.Add(4);
            student1.dates.Add(1);
            student1.dates.Add(27);

            student2.marks.Add(2);
            student2.marks.Add(3);
            student2.marks.Add(3);
            student2.dates.Add(1);
            student2.dates.Add(10);
            student2.dates.Add(20);


            student3.marks.Add(2);
            student3.marks.Add(5);
            student3.dates.Add(1);
            student3.dates.Add(15);


            student1.LastName = "Михайлова";
            student1.Name = "Софья";
            student1.Patronymic = "Ильинична";

            student2.LastName = "Шуваев";
            student2.Name = "Максим";
            student2.Patronymic = "Романович";

            student3.LastName = "Кулаков";
            student3.Name = "Дмитрий";
            student3.Patronymic = "Александрович";

            if (Users.userRole == "student1")
            {
                btnAddMarks.IsEnabled = false;
                this.Title = student1.LastName + " " + student1.Name + " " + student1.Patronymic;
            }
            else if (Users.userRole == "student2")
            {
                btnAddMarks.IsEnabled = false;
                this.Title = student2.LastName + " " + student2.Name + " " + student2.Patronymic;
            }
            else if (Users.userRole == "student3")
            {
                btnAddMarks.IsEnabled = false;
                this.Title = student3.LastName + " " + student3.Name + " " + student3.Patronymic;
            }
            else if (Users.userRole == "teacher")
            {
                btnAddMarks.IsEnabled = true;
                teacher.LastName = "Афанасьев";
                teacher.Name = "Дмитрий";
                teacher.Patronymic = "Александрович";
                this.Title = teacher.LastName + " " + teacher.Name + " " + teacher.Patronymic;
                btnBuildGraphic.Content = "Построить графики всех студентов";

            }
        }

        private void BuildGraphic_Click(object sender, RoutedEventArgs e)
        {
            string role;
            //начальная точка 1-0 40-410
            //шаг 25-69
            //5 - 65
            //4 - 132
            //3 - 201
            //2 - 270

            Polyline polyline = new();
            Polyline polyline1 = new();
            Polyline polyline2 = new();
            Polyline polyline3 = new();
            if (Users.userRole == "student1")
            {
                polyline = Student.BuildGraphic(student1, "student1");
                canvas.Children.Add(polyline);
            }
            else if (Users.userRole == "student2")
            {
                polyline = Student.BuildGraphic(student2, "student2");
                canvas.Children.Add(polyline);
            }
            else if (Users.userRole == "student3")
            {
                polyline = Student.BuildGraphic(student3, "student3");
                canvas.Children.Add(polyline);
            }
            else if (Users.userRole == "teacher")
            {
                polyline1 = Student.BuildGraphic(student1, "student1");
                polyline2 = Student.BuildGraphic(student2, "student2");
                polyline3 = Student.BuildGraphic(student3, "student3");
                canvas.Children.Add(polyline1);
                canvas.Children.Add(polyline2);
                canvas.Children.Add(polyline3);
            }
        }

        private void AddMarks_Click(object sender, RoutedEventArgs e)
        {
            AddMarksWindow addMarksWindow = new AddMarksWindow();
            addMarksWindow.Owner = this;
            addMarksWindow.ShowDialog();
        }

        private void ChangeUser_Click(object sender, RoutedEventArgs e)
        {
            Users.userRole = string.Empty;
            Window_Loaded(sender, e);
        }

        private void BestStudent_Click(object sender, RoutedEventArgs e)
        {
            double avg1 = Student.AvgStudent(student1);
            double avg2 = Student.AvgStudent(student2);
            double avg3 = Student.AvgStudent(student3);

            string res;

            if (avg1 > avg2 && avg1 > avg3)
            {
                res = "Лучший студент: " + student1.LastName + " " + student1.Name + " " + student1.Patronymic;
            }
            else if (avg2 > avg3)
            {
                res = "Лучший студент: " + student2.LastName + " " + student2.Name + " " + student2.Patronymic;
            }
            else
            {
                res = "Лучший студент: " + student3.LastName + " " + student3.Name + " " + student3.Patronymic;
            }
            MessageBox.Show(res);
        }

        private void WorseStudent_Click(object sender, RoutedEventArgs e)
        {
            double avg1 = Student.AvgStudent(student1);
            double avg2 = Student.AvgStudent(student2);
            double avg3 = Student.AvgStudent(student3);

            string res;

            if (avg1 < avg2 && avg1 < avg3)
            {
                res = "Худший студент: " + student1.LastName + " " + student1.Name + " " + student1.Patronymic;
            }
            else if (avg2 < avg3)
            {
                res = "Худший студент: " + student2.LastName + " " + student2.Name + " " + student2.Patronymic;
            }
            else
            {
                res = "Хучший студент: " + student3.LastName + " " + student3.Name + " " + student3.Patronymic;
            }
            MessageBox.Show(res);
        }
    }
}
