using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Department
    {
        public string Nome { get; set; }
        public Department()
        {

        }

        public Department(string nome)
        {
            Nome = nome;
        }
    }
}
