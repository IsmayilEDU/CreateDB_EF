
using CreateDB__EF.Entities.Interfaces;

namespace CreateDB__EF.Entities.DerivedEntities
{
    public class Author : IId, IFullname
    {
        public int Id { get ; set; }
        public string Firstname { get ; set ; }
        public string Lastname { get ; set ; }
        public ICollection<Book> Books { get; set; }
    }
}
