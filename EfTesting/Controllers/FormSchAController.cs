using EfTesting.Dto;
using EfTesting.Enums;
using EfTesting.Services;
using Microsoft.AspNetCore.Mvc;

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
            return _formSchAService.GetAll().ToList();
        }

        [HttpGet("insert")]
        async public Task InsertRecords()
        {
            FormSchADto formSchA = new FormSchADto
            {
                FormType = FecRecordType.IndividualContributionUnitemized,
                FilerCommittedId = "FEC-123",
                TransactionId = "TX 123",
                BackRefTransactionId = "BRT 123",
                BackRefScheduleName = FecRecordType.FecElectionActivity,
                EntityType = EntityType.IND,
                ContributorOrganizationName = "None",
                ContributorLastName = "Martin",
                ContributorFirstName = "Roger",
                ContributorMiddleName = "rdog",
                ContributorPrefix = "Mr",
                ContributorSuffix = "Jr",
                ElectionCode = "G2022",
                ElectionOtherDescription = "some election stuff",
                ContributionDate = DateTime.UtcNow,
                ContributionAmount = 15,
                ContributionAggregate = 100,
                ContributionPurpose = "Elect Bob",
                ContributorEmployer = "McDonalds",
                ContributorOccupation = "Server",
                IsMemo = false,
                MemoText = "my memo..."
            };

            await _formSchAService.Add(formSchA);
        }

        // GET api/<SchAController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
