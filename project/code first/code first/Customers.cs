using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first.Helpers
{
    public class Customers
    {
        public Customers()
        {
                
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDebtor { get; set; }

        public ICollection<BooksInLibrary> BooksInLibrary { get; set; }
    }
}
