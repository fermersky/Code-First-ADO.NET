using code_first.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace code_first
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BestLibraryEntity db = new BestLibraryEntity())
            {
                Authors aut = new Authors()
                {
                    FirstName = "Lev",
                    LastName = "Tolstoi"
                };

                db.Authors.Add(aut);
                db.SaveChanges();

                foreach (var item in db.Authors)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }
            }
        }
    }
}
