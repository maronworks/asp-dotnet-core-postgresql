using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyApi.Models;

namespace MyApi.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<User> Users => Set<User>();
	}
}