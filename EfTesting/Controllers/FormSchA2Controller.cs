using EfTesting.Dto;
using EfTesting.Enums;
using EfTesting.MockData;
using EfTesting.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EfTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class FormSchA2Controller : ControllerBase
    {
        private readonly FormSchA2Service _formSchA2Service;

        public FormSchA2Controller(FormSchA2Service formSchA2Service)
        {
            _formSchA2Service = formSchA2Service;
        }

        // GET: api/<SchAController>
        [HttpGet]
        public ActionResult<List<FormSchA2Dto>> Get()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var items = _formSchA2Service.GetAll().ToList();
            stopwatch.Stop();
            Console.WriteLine("Elapsed={0}", stopwatch.Elapsed);
            return items.Take(2).ToList();
        }

        // GET api/<SchAController>/5
        [HttpGet("{id}")]
        public Task<FormSchA2Dto?> Get(int id)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var item = _formSchA2Service.GetById(id);
            stopwatch.Stop();
            Console.WriteLine("Elapsed={0}", stopwatch.Elapsed);
            return item;
        }

        [HttpGet("insert")]
        async public Task InsertRecords()
        {
            for (int i = 0; i < 500; i++)
            {
                var faker = new FakerGenerator();
                var entities = faker.FormSchA2Dto.Generate(1000);
                await _formSchA2Service.AddRange(entities);
            }

            //FormSchADto formSchA = new FormSchADto
            //{
            //    FormType = FecRecordType.IndividualContributionUnitemized,
            //    FilerCommittedId = "FEC-123",
            //    TransactionId = "TX 123",
            //    BackRefTransactionId = "BRT 123",
            //    BackRefScheduleName = FecRecordType.FecElectionActivity,
            //    EntityType = EntityType.IND,
            //    ContributorOrganizationName = "None",
            //    ContributorLastName = "Martin",
            //    ContributorFirstName = "Roger",
            //    ContributorMiddleName = "rdog",
            //    ContributorPrefix = "Mr",
            //    ContributorSuffix = "Jr",
            //    ElectionCode = "G2022",
            //    ElectionOtherDescription = "some election stuff",
            //    ContributionDate = DateTime.UtcNow,
            //    ContributionAmount = 15,
            //    ContributionAggregate = 100,
            //    ContributionPurpose = "Elect Bob",
            //    ContributorEmployer = "McDonalds",
            //    ContributorOccupation = "Server",
            //    IsMemo = false,
            //    MemoText = "my memo..."
            //};

            //await _formSchA2Service.Add(formSchA);
        }

        // POST api/<SchAController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SchAController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SchAController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
