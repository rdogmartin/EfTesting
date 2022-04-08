using EfTesting.DbContext;
using EfTesting.Dto;
using EfTesting.Interfaces;

namespace EfTesting.Repository;

public class FormSchARepository : Repository<FormSchADto>, IFormSchARepository
{
    public FormSchARepository(FecContext context) : base(context)
    {
    }
}
