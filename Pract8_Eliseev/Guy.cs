using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract8_Eliseev
{
    class Guy: IHuman , IComparable, ICloneable
    {
        private string _name;
        private string _lastName;
        private int _age;

        public Guy(string Name, string LastName, int Age)
        {
            _name = Name;
            _lastName = LastName;
            _age = Age;
        }
        public string Name { get { return _name; } }
        public string LastName { get { return _lastName; } }
        public int Age { get { return _age; } }

        public int CompareTo(object obj)
        {
            Guy temp = (Guy)obj;
            return this.LastName.CompareTo(temp.LastName);
        }

        public Guy ShallowClone()
        {
            return (Guy)this.MemberwiseClone();
        }

        public string Greetings(IHuman human)
        {
            return $"Здарова {human.Name}";
        }

        public override string ToString()
        {
            return $" {Name}, {LastName}, {Age}";
        }
    }
}
