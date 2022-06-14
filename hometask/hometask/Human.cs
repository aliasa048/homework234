using System;
using System.Collections.Generic;
using System.Text;

namespace hometask
{
    class Human
    {
        public int Age;
        public string Surname;
        public Human(byte age,string surname=null)
        {
            this.Age = age;
            Surname = surname;
        }
    }
}
