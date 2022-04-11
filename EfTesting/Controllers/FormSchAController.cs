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
    public class FormSchAController : ControllerBase
    {
        private readonly FormSchAService _formSchAService;

        public FormSchAController(FormSchAService formSchAService)
        {
            _formSchAService = formSchAService;
        }

        // GET: api/<SchAController>
        [HttpGet]
        public ActionResult<List<FormSchADto>> Get()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var items = _formSchAService.GetAll().ToList();
            stopwatch.Stop();
            Console.WriteLine("Elapsed={0}", stopwatch.Elapsed);
            return items.Take(2).ToList();
        }

        // GET api/<SchAController>/5
        [HttpGet("{id}")]
        public Task<FormSchADto?> Get(int id)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var item = _formSchAService.GetById(id);
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
                var entities = faker.FormSchADto.Generate(1000);
                await _formSchAService.AddRange(entities);
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

            //await _formSchAService.Add(formSchA);
        }

        // POST api/<SchAController>
        [HttpPost]
        public async Task<ActionResult<FormSchADto>> Post(FormSchADto formSchADto)
        {
            formSchADto = await _formSchAService.Add(formSchADto);
            return CreatedAtAction(nameof(Post), new { id = formSchADto.UniqueId }, formSchADto);
        }

        // PUT api/<SchAController>/5
        [HttpPut]
        public async Task<ActionResult> Put(FormSchADto formSchADto)
        {
            await _formSchAService.Update(formSchADto);

            return NoContent();
        }

        // DELETE api/<SchAController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
