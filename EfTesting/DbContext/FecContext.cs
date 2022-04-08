using EfTesting.Dto;
using Microsoft.EntityFrameworkCore;

namespace EfTesting.DbContext
{
    public class FecContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public FecContext(DbContextOptions<FecContext> options) : base(options)
        {
        }

        public DbSet<FormBaseDto> FormBases => Set<FormBaseDto>();
        public DbSet<Form99Dto> Form99s => Set<Form99Dto>();

    }
}
