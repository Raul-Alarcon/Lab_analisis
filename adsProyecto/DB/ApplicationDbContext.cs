﻿using adsProyecto.Models;
using Microsoft.EntityFrameworkCore;

namespace adsProyecto.DB
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}