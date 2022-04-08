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
    public class Form99Controller : ControllerBase
    {
        private readonly Form99Service _form99Service;

        public Form99Controller(Form99Service form99Service)
        {
            _form99Service = form99Service;
        }

        // GET: api/<Form99Controller>
        [HttpGet]
        public ActionResult<List<Form99Dto>> Get()
        {
            return _form99Service.GetAll().ToList();
        }

        [HttpGet("insert")]
        async public Task InsertRecords()
        {
            Form99Dto form99 = new Form99Dto
            {
                // UniqueId = 0,
                FormType = FecFormType.Form99,
                FormSubtype = null,
                FecFilingId = "FEC-123",
                IsAmendment = false,
                AmendmentNum = 0,
                ReportPeriodStart = null,
                ReportPeriodEnd = null,
                Status = FecFormFilingStatus.Draft,
                ValidationResult = "",
                ValidationDateTime = null,
                DateSigned = null,
                FilingCommitteeEntityType = EntityType.IND,
                FilingCommitteeFecId = "Cm 123",
                FilingCommitteeName = "Micky for Prez",
                FilingCommitteeAddressLine1 = "123 Main St",
                FilingCommitteeAddressLine2 = "Ste 101",
                FilingCommitteeCity = "Boulder",
                FilingCommitteeState = "CO",
                FilingCommitteePostalCode = "80303",
                TreasurerFirstName = "David",
                TreasurerMiddleName = "L",
                TreasurerLastName = "Gilmour",
                TreasurerPrefix = "Mr",
                TreasurerSuffix = "Jr",
                DocumentType = Form99DocType.MiscReportToFec,
                TextContent = "Draft text content..."
            };

            await _form99Service.Add(form99);
        }

        // GET api/<Form99Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Form99Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Form99Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Form99Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
