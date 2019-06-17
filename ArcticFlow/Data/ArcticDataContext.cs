using ArcticFlow.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArcticFlow.Data
{
    public class ArcticDataContext : DbContext
    {
        public ArcticDataContext(DbContextOptions<ArcticDataContext> options)
            : base(options)
        { }
        public DbSet<Arctic> Arctics { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<RedeSocial> RedesSociais { get; set; }
    }
}
