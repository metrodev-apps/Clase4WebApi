using Clase4Mvc.Models;
using Microsoft.EntityFrameworkCore;

public class TeamContext : DbContext
{
    public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }

    public DbSet<Team> Teams { get; set; }
}