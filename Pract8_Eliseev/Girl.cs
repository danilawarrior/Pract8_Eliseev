using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract8_Eliseev
{
    class Girl : IHuman
    {
        private string _name;
        private string _lastName;
        private int _age;

        public Girl(string name, string lastName, int age)
        {
            _name = name;
            _lastName = lastName;
            _age = age;
        }
        public string Name { get { return _name; } }
        public string LastName { get { return _lastName; } }    
        public int Age { get { return _age; } }

        public string Greetings(IHuman human)
        {
            return $"Приветики {human.Name}";
        }

        public override string ToString()
        {
            return $" {Name}, {LastName}, {Age}";
        }


    }
}
