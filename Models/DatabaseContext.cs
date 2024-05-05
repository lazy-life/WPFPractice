using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractice.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext():base(@"Server=KIKO\SQLEXPRESS;Database=CodeDemoWpf;Trusted_Connection=True;") { 
        }

        public DbSet<User> Users { get; set; }
    }
}
