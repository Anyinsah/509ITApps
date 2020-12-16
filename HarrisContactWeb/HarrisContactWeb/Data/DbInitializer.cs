using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactWeb.Data
{

    /*
     *  This class initalises the db, which we will use to call the creation of the database in the main program.
     *  We pass through the HarrisDbContext class and give the paramater context to call the database, with the method EnsureCreated();
     */
    public class DbInitializer
    {
        public static void Initialize(HarrisDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
