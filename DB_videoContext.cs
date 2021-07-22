using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_API_VIDEO
{
    public class DB_videoContext: DbContext
    {
        public DbSet<Videos> Video { get; set; }

        public DB_videoContext(DbContextOptions<DB_videoContext> options): base(options)
        {

        }

        
    }
}
