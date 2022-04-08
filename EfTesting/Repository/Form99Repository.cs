using EfTesting.DbContext;
using EfTesting.Dto;
using EfTesting.Interfaces;

namespace EfTesting.Repository;

public class Form99Repository : Repository<Form99Dto>, IForm99Repository
{
    public Form99Repository(FecContext context) : base(context)
    {
    }
}
