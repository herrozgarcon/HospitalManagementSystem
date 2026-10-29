using HospitalManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Data;

public class AppDbContext:DbContext
{


    public DbSet<Doctors> Doctors { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=HospitalSystem;User Id=sa;Password=Hrithik21$;TrustServerCertificate=True;");
        }
    }
    
    
}   