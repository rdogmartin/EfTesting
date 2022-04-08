using EfTesting.Dto;
using EfTesting.Interfaces;

namespace EfTesting.Services;

public class FormBaseService
{
    private readonly IFormBaseRepository _formBaseRepository;

    public FormBaseService(IFormBaseRepository formBaseRepository)
    {
        _formBaseRepository = formBaseRepository;
    }

    public async Task<FormBaseDto?> GetById(int id)
    {
        var formBaseDto = await _formBaseRepository.Find(id);
        return formBaseDto;
    }

    public IList<FormBaseDto> GetAll()
    {
        return _formBaseRepository.GetAll().ToList();
    }
}
