using Microsoft.EntityFrameworkCore;

namespace CarVilla.Contexts;

public class AppDbContext : DbContext
{
	private readonly string _connectionString = @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=Carvilla;Trusted_Connection=True;TrustServerCertificate=True";
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(_connectionString);
		base.OnConfiguring(optionsBuilder);

	}
}
