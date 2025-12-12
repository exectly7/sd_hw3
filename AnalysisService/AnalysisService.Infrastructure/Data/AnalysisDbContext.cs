using AnalysisService.Infrastructure.Data.Dtos;
using Microsoft.EntityFrameworkCore;

namespace AnalysisService.Infrastructure.Data;

public sealed class AnalysisDbContext(DbContextOptions<AnalysisDbContext> options) : DbContext(options)
{
    public DbSet<WorkDto> Works { get; set; }
    public DbSet<ReportDto> Reports { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorkDto>(builder =>
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Works");
        });

        modelBuilder.Entity<ReportDto>(builder =>
        {
            builder.HasKey(x => x.WorkId);
            builder.ToTable("Reports");
        });
    }
}