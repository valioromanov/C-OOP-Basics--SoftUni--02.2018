using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager_Valentin_Romanov
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=cn") { }
        public DbSet<EventInfo> EventList { get; set; }
    }
}
