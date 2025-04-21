using Dolgozó_nyilvántartó.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.Infrastructure
{
    internal interface IController
    {
        List<Worker> ListAll();
        Guid AddOne(Worker worker);
    }
}
