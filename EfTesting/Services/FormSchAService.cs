using EfTesting.Dto;
using EfTesting.Interfaces;

namespace EfTesting.Services;

public class FormSchAService
{
    private readonly IFormSchARepository _formSchARepository;

    public FormSchAService(IFormSchARepository formSchARepository)
    {
        _formSchARepository = formSchARepository;
    }

    public async Task<FormSchADto?> GetById(int id)
    {
        var formSchADto = await _formSchARepository.Find(id);
        return formSchADto;
    }

    public IList<FormSchADto> GetAll()
    {
        return _formSchARepository.GetAll().ToList();
    }

    public async Task Add(FormSchADto formSchA)
    {
        _formSchARepository.Add(formSchA);
        await _formSchARepository.Save();
    }
}
