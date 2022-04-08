using EfTesting.Dto;
using EfTesting.Interfaces;

namespace EfTesting.Services
{
    public class Form99Service
    {
        private readonly IForm99Repository _form99Repository;

        public Form99Service(IForm99Repository form99Repository)
        {
            _form99Repository = form99Repository;
        }

        public async Task<Form99Dto?> GetById(int id)
        {
            var form99Dto = await _form99Repository.Find(id);
            return form99Dto;
        }

        public IQueryable<Form99Dto> GetAll()
        {
            return _form99Repository.GetAll();
        }

        public async Task Add(Form99Dto form99)
        {
            _form99Repository.Add(form99);
            await _form99Repository.Save();
        }

        public async Task Update(Form99Dto formBase)
        {
            var formBaseDto = await _form99Repository.Find(formBase.UniqueId);
            if (formBaseDto != null)
            {
                _form99Repository.Update(formBaseDto);
                await _form99Repository.Save();
            }
        }
    }
}
