using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PriscilaZuniga_Examen1P.Models;

    public class PriscilaZuniga_DBContext : DbContext
    {
        public PriscilaZuniga_DBContext (DbContextOptions<PriscilaZuniga_DBContext> options)
            : base(options)
        {
        }

        public DbSet<PriscilaZuniga_Examen1P.Models.PZClass> PZClass { get; set; } = default!;
    }
