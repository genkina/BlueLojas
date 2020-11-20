using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using blueLojas.Models;


namespace blueLojas.Models.Dados
{
    public class lojaContexto : DbContext
    {
        public lojaContexto(DbContextOptions<lojaContexto> options)
            : base(options)
        {
        }

        public DbSet<Produtos> Produtos { get; set; }
    }

    
}
