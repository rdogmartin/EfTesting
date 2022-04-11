using EfTesting.Dto;
using EfTesting.Interfaces;

namespace EfTesting.Services;

public class FormSchA2Service
{
    private readonly IFormSchA2Repository _formSchA2Repository;

    public FormSchA2Service(IFormSchA2Repository formSchA2Repository)
    {
        _formSchA2Repository = formSchA2Repository;
    }

    public async Task<FormSchA2Dto?> GetById(int id)
    {
        var formSchADto = await _formSchA2Repository.Find(id);
        return formSchADto;
    }

    public IList<FormSchA2Dto> GetAll()
    {
        return _formSchA2Repository.GetAll().ToList();
    }

    public async Task Add(FormSchA2Dto formSchA)
    {
        _formSchA2Repository.Add(formSchA);
        await _formSchA2Repository.Save();
    }

    public async Task AddRange(IEnumerable<FormSchA2Dto> formSchAs)
    {
        _formSchA2Repository.AddRange(formSchAs);
        await _formSchA2Repository.Save();
    }
}
