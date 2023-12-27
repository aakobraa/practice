using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace practice02
{
    public class Person
    {
        string _name;
        string? _patronymic;
        string _lastName;
        

        public string LastName
        {
            set { if (_lastName == null) _lastName = value; }
            get { return _lastName; }
        }

        public string Name
        {
            set { if (_name == null) _name = value; }
            get { return _name; }
        }

        public string Patronymic
        {
            set { if (_patronymic == null) _patronymic = value; }
            get { return _patronymic; }
        }
    }
}
