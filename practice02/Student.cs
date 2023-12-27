using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;

namespace practice02
{
    public class Student : Person
    {

        public List<int> dates = new List<int>();
        public List<int> marks = new List<int>(); 
       

        public List<int> AddMark(int mark)
        {
            marks.Add(mark);
            return marks;
        }

        public List<int> AddDates(int date)
        {
            dates.Add(date);
            return dates;
        }

        static public double AvgStudent(Student student)
        {
            double avg = student.marks.Average();
            return avg;
        }

        public static Polyline BuildGraphic(Student student, string role)
        {
            int firstCoordinate;
            int secondCoordinate = 65;
            Polyline polyline = new();
            polyline.StrokeThickness = 3;
            if (role == "student1")
            {
                polyline.Stroke = new SolidColorBrush(Colors.Red);
            }
            else if (role == "student2")
            {
                polyline.Stroke = new SolidColorBrush(Colors.Blue);
            }
            else if (role == "student3")
            {
                polyline.Stroke = new SolidColorBrush(Colors.Green);
            }
            for (int i = 0; i < student.marks.Count; i++)
            {
                int firstMark = student.marks[i];
                switch (firstMark)
                {
                    case 2:
                        secondCoordinate = 270;
                        break;
                    case 3:
                        secondCoordinate = 201;
                        break;
                    case 4:
                        secondCoordinate = 132;
                        break;
                    case 5:
                        secondCoordinate = 65;
                        break;
                }
                int firstDate = student.dates[i];
                firstCoordinate = 40 + (firstDate - 1) * 24;
                polyline.Points.Add(new Point(firstCoordinate, secondCoordinate));
            }
            return polyline;
        }
    }
}
