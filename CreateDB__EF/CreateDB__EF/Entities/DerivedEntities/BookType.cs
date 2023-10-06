using CreateDB__EF.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDB__EF.Entities.DerivedEntities
{
    public class BookType : IId, IName
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
    }
}
