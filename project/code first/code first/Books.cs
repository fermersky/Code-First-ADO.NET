using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first.Helpers
{
    public class Books
    {
        public Books()
        {

        }
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<BooksInLibrary> BooksInLibrary { get; set; }
    }
}
