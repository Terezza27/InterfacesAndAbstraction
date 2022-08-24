using System;
using System.Collections.Generic;
using System.Text;

namespace T04.BorderControl
{
    public class Pet : IBirthdateable
    {
        public Pet(string name, string birthdate)
        {
            this.name = name;
            Birthdate = birthdate;
        }

        public string name { get; set; }
        public string Birthdate { get; set; }
    }
}
