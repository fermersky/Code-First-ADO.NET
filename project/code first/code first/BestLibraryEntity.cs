using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace code_first.Helpers
{
    class BestLibraryEntity : DbContext
    {
        public BestLibraryEntity() : base ("db")
        {
            Database.SetInitializer<BestLibraryEntity>(new CreateDatabaseIfNotExists<BestLibraryEntity>());
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BooksInLibrary> BooksInLibrary { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
    }
}
