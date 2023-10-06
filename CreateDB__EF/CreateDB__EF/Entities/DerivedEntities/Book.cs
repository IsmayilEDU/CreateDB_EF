
using CreateDB__EF.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDB__EF.Entities.DerivedEntities
{
    public class Book : IId, IName
    {
        public Book(string name, int pagesCount)
        {
            Name = name;
            PagesCount = pagesCount;
        }

        public string Name { get; set; }

        public int PagesCount { get; set; }
        public int Id { get ; set ; }

        public Student student { get; set; }
        public Author author { get; set; }
    }
}
