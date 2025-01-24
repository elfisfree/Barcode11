using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Barcode11.MainWindow;

namespace Barcode11
{
    public class BarcodeDbContext : DbContext
    {
        public BarcodeDbContext() : base("name=BarcodeDBConnectionString") { }  
        public DbSet<Product> Product { get; set; }
    }
}
