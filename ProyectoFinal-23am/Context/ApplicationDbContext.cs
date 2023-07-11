﻿using Microsoft.EntityFrameworkCore;
using ProyectoFinal_23am.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_23am.Context
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)

        {
            options.UseMySQL("server = localhost; database=ProyectoDb23Am; user=root; password=;");


                }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
    }
}
