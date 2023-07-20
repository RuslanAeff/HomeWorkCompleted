using demo_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkv2.Models
{    
        public class Teacher : BaseEntity
        {
            private static int counter = 0;

            public Teacher(string name, string surname, DateTime birthDay)
            {
                Name = name;
                Surname = surname;              
                Birthday = birthDay;

                Id = counter;
                counter++;
            }

            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime Birthday { get; set; }
        }
    
}
