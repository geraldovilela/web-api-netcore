﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShelvesAndBooks.Models;

namespace ShelvesAndBooks.Data
{
    public class Connection : DbContext
    {
        public DataContext(DbContextOptions<Connection> options)
            : base(options)
        {
            return void;
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Shelve> Shelves { get; set; }

    }
}
