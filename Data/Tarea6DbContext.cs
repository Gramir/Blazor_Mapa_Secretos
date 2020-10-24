using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea5_.Models;

namespace Tarea5_.Data
{
    public class Tarea6DbContext:DbContext
    {
        public Tarea6DbContext(DbContextOptions<Tarea6DbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Secreto> Secretos { get; set; }
    }
}
