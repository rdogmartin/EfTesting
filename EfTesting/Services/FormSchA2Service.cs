using EfTesting.Dto;
using EfTesting.Interfaces;

namespace EfTesting.Services;

public class FormSchA2Service
{
    private readonly IFormSchA2Repository _formSchARepository;

    public FormSchA2Service(IFormSchA2Repository formSchARepository)
    {
        _formSchARepository = formSchARepository;
    }

    public async Task<FormSchA2Dto?> GetById(int id)
    {
        var formSchADto = await _formSchARepository.Find(id);
        return formSchADto;
    }

    public IList<FormSchA2Dto> GetAll()
    {
        return _formSchARepository.GetAll().ToList();
    }

    public async Task Add(FormSchA2Dto formSchA)
    {
        _formSchARepository.Add(formSchA);
        await _formSchARepository.Save();
    }

    public async Task AddRange(IEnumerable<FormSchA2Dto> formSchAs)
    {
        _formSchARepository.AddRange(formSchAs);
        await _formSchARepository.Save();
    }
}
