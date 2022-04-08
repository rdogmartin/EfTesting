using EfTesting.DbContext;
using EfTesting.Dto;
using EfTesting.Interfaces;

namespace EfTesting.Repository;

public class FormBaseRepository : Repository<FormBaseDto>, IFormBaseRepository
{
    public FormBaseRepository(FecContext context) : base(context)
    {
    }
}
