using System;
using Microsoft.EntityFrameworkCore;
namespace ticketbookingapp.Data
{
	public class AppDbContext:DbContext 
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{
				
		}
	}
}

