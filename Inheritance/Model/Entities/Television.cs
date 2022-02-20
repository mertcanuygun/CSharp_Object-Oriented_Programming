using Inheritance.Model.Base_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model.Entities
{
    public class Television:BaseProduct
    {
        public int Screen_Size { get; set; }
        public string Resolution { get; set; }

    }
}
