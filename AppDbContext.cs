using System;
using Microsoft.EntityFrameworkCore;
using StudentDb.Models;


namespace StudentDb
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<Student> student { get; set; }
		
	}
}

