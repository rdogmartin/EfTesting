using EfTesting.DbContext;
using EfTesting.Dto;
using EfTesting.Interfaces;

namespace EfTesting.Repository;

public class FormSchA2Repository : Repository<FormSchA2Dto>, IFormSchA2Repository
{
    public FormSchA2Repository(FecContext context) : base(context)
    {
    }
}
