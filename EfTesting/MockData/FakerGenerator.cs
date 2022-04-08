using Bogus;
using EfTesting.Dto;
using EfTesting.Enums;

namespace EfTesting.MockData;

public class FakerGenerator
{
    public Faker<FormBaseDto> FormBaseDto;
    public Faker<Form99Dto> Form99Dto;
    
    public FakerGenerator(int seed = 8675309)
    {
        // Set the randomizer seed to generate repeatable data sets
        Randomizer.Seed = new Random(seed);

        FormBaseDto = new Faker<FormBaseDto>()
            //.RuleFor(o => o.UniqueId, f => f.Random.Guid())
            .RuleFor(o => o.FilingCommitteeAddressLine1, f => f.Address.StreetAddress())
            .RuleFor(o => o.FilingCommitteeAddressLine2, f => f.Address.SecondaryAddress())
            .RuleFor(o => o.FilingCommitteeCity, f => f.Address.City())
            .RuleFor(o => o.FilingCommitteeState, GenerateStateCode)
            .RuleFor(o => o.FilingCommitteePostalCode, GeneratePostalCode)
            .RuleFor(o => o.FilingCommitteeEntityType, f => f.PickRandom<EntityType>())
            .RuleFor(o => o.FilingCommitteeFecId, GenerateFecId)
            .RuleFor(o => o.FilingCommitteeName, f => f.Company.CompanyName())
            .RuleFor(o => o.DateSigned, f => f.Date.Recent())
            .RuleFor(o => o.TreasurerFirstName, f => f.Name.FirstName())
            .RuleFor(o => o.TreasurerMiddleName, f => f.Name.FirstName())
            .RuleFor(o => o.TreasurerLastName, f => f.Name.LastName())
            .RuleFor(o => o.TreasurerPrefix, f => f.Name.Prefix())
            .RuleFor(o => o.TreasurerSuffix, f => f.Name.Suffix())
            .RuleFor(o => o.AmendmentNum, f => f.Random.Short(0, 5))
            .RuleFor(o => o.FecFilingId, GenerateFecFilingId)
            .RuleFor(o => o.FormType, f => f.PickRandom<FecFormType>())
            .RuleFor(o => o.FormSubtype, f => f.PickRandom<FecFormSubtype>())
            .RuleFor(o => o.IsAmendment, f => f.Random.Bool())
            .RuleFor(o => o.ReportPeriodEnd, f => f.Date.Soon(30))
            .RuleFor(o => o.ReportPeriodStart, f => f.Date.Recent(5))
            .RuleFor(o => o.Status, f => f.PickRandom<FecFormFilingStatus>())
            .RuleFor(o => o.ValidationResult, f => f.Lorem.Sentence())
            .RuleFor(o => o.ValidationDateTime, f => f.Date.Recent());

        Form99Dto = new Faker<Form99Dto>()
            .RuleFor(o => o.DocumentType, f => f.PickRandom<Form99DocType>())
            .RuleFor(o => o.TextContent, f => f.Lorem.Paragraphs());

        
    }

    private static string GeneratePostalCode(Faker f)
    {
        return f.Address.ZipCode().Replace("-", "");
    }

    private static string GenerateFecFilingId(Faker f)
    {
        return $"fec-{f.Random.Int(1, 99999999):00000000}";
    }

    private static string GenerateFecId(Faker f)
    {
        return $"{f.PickRandom('C', 'H')}{f.Random.Int(1, 99999999):00000000}";
    }

    private static string GenerateStateCode(Faker f)
    {
        return "CO";
        //return StateHelper.GetStateCodeFromFullState(f.Address.State());
    }
}
