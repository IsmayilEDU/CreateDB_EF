using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDB__EF.Entities.Interfaces
{
    internal interface IFullname
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
