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

    public async Task<FormSchADto> Add(FormSchADto formSchA)
    {
        _formSchARepository.Add(formSchA);
        await _formSchARepository.Save();
        return formSchA;
    }

    public async Task AddRange(IEnumerable<FormSchADto> formSchAs)
    {
        _formSchARepository.AddRange(formSchAs);
        await _formSchARepository.Save();
    }

    public async Task Update(FormSchADto formSchA)
    {
        _formSchARepository.Update(formSchA);
        await _formSchARepository.Save();
    }
}
