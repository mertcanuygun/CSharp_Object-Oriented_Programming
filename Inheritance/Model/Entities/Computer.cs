using Inheritance.Model.Base_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model.Entities
{
    public class Computer:BaseProduct
    {
        public int Memory { get; set; }
        public int Storage { get; set; }
    }
}
