﻿using Library.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Context;

public class LibraryContext: DbContext
{
    public DbSet<Book> Books { get; set; }
    
    public LibraryContext(DbContextOptions<LibraryContext> options): base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
        
        base.OnModelCreating(modelBuilder);
    }
}