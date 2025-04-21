using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.DTO
{
    internal record class Worker
    {
        internal string Name { get; set; }
        internal string Email { get; set; }
        internal int Age { get; set; }
        internal decimal Salary { get; set; }

        public string this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.Name;
                    case 1:
                        return this.Email;
                    case 2:
                        return this.Age.ToString();
                    case 3:
                        return this.Salary.ToString();
                    default:
                        throw new IndexOutOfRangeException("Invalid index");
                }
            }
        }
    }
}
