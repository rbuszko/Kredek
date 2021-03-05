using Microsoft.EntityFrameworkCore;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Repositories
{
    public class DataBaseContext : DbContext
    {
        /// <summary>
        /// Konstruktor klasy, połączenie z bazą
        /// </summary>
        /// <param name="opt"></param>
        public DataBaseContext(DbContextOptions<DataBaseContext> opt) : base(opt)
        {

        }
        /// <summary>
        /// Dodanie tabeli nauczyciela
        /// </summary>
        public DbSet<Teacher> teachers { get; set; }
        /// <summary>
        /// Dodanie tabeli ucznia
        /// </summary>
        public DbSet<Student> students { get; set; }
    }
}
