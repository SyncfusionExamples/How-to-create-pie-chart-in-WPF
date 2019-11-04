using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieChart_CS
{
    public class ViewModel
    {
        public List<Person> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Person>()
            {
                new Person { Name = "David", Weight = 45 },
                new Person { Name = "Michael", Weight = 50 },
                new Person { Name = "Steve", Weight = 79 },
                new Person { Name = "Joel", Weight = 65 },
                new Person { Name = "Sam", Weight = 54 },
                new Person { Name = "Smith", Weight = 60 }
            };

        }
    }
}
