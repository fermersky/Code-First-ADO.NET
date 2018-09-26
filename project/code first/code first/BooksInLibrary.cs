using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace code_first.Helpers
{
    public class BooksInLibrary
    {
        public BooksInLibrary()
        {

        }

        public int Id { get; set; }
        public int Id_Book { get; set; }
        public int Id_Author { get; set; }
        public int Id_Customer { get; set; }

        public virtual Books Book { get; set; }
        public virtual Authors Author { get; set; }
        public virtual Customers Customer { get; set; }
    }
}
