using back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace back_end.Data
{
  public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
  {
    public DbSet<User> Users => Set<User>();
  } 
}