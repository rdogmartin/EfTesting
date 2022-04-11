using Bogus;
using EfTesting.Dto;
using EfTesting.Enums;

namespace EfTesting.MockData;

public class FakerGenerator
{
    public Faker<FormBaseDto> FormBaseDto;
    public Faker<Form99Dto> Form99Dto;
    public Faker<FormSchADto> FormSchADto;
    public Faker<FormSchA2Dto> FormSchA2Dto;
    
    public FakerGenerator(int seed = 8675309)
    {
        // Set the randomizer seed to generate repeatable data sets
        //Randomizer.Seed = new Random(seed);

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

        FormSchADto = new Faker<FormSchADto>()
            .RuleFor(o => o.FormType, f => f.PickRandom<FecRecordType>())
            .RuleFor(o => o.FilerCommittedId, GenerateFecFilerCommitteeId)
            .RuleFor(o => o.TransactionId, GenerateTransactionId)
            .RuleFor(o => o.BackRefTransactionId, GenerateTransactionId)
            .RuleFor(o => o.BackRefScheduleName, f => f.PickRandom<FecRecordType>())
            .RuleFor(o => o.EntityType, f => f.PickRandom<EntityType>())
            .RuleFor(o => o.ContributorOrganizationName, f => f.Company.CompanyName())
            .RuleFor(o => o.ContributorLastName, f => f.Name.LastName())
            .RuleFor(o => o.ContributorFirstName, f => f.Name.FirstName())
            .RuleFor(o => o.ContributorMiddleName, f => f.Name.FirstName())
            .RuleFor(o => o.ContributorPrefix, f => f.Name.Prefix())
            .RuleFor(o => o.ContributorSuffix, f => f.Name.Suffix())
            .RuleFor(o => o.ElectionCode, GenerateElectionCode)
            .RuleFor(o => o.ElectionOtherDescription, f => f.Lorem.Word())
            .RuleFor(o => o.ContributionDate, f => f.Date.Recent())
            .RuleFor(o => o.ContributionAmount, f => f.Finance.Amount())
            .RuleFor(o => o.ContributionAggregate, f => f.Finance.Amount())
            .RuleFor(o => o.ContributionPurpose, f => f.Lorem.Sentence(3))
            .RuleFor(o => o.ContributorEmployer, GenerateEmployer)
            .RuleFor(o => o.ContributorOccupation, GenerateJobTitle)
            .RuleFor(o => o.IsMemo, f => f.Random.Bool())
            .RuleFor(o => o.MemoText, f => f.Lorem.Sentence(3));

        FormSchA2Dto = new Faker<FormSchA2Dto>()
            .RuleFor(o => o.FormType, f => f.PickRandom<FecRecordType>())
            .RuleFor(o => o.FilerCommittedId, GenerateFecFilerCommitteeId)
            .RuleFor(o => o.TransactionId, GenerateTransactionId)
            .RuleFor(o => o.BackRefTransactionId, GenerateTransactionId)
            .RuleFor(o => o.BackRefScheduleName, f => f.PickRandom<FecRecordType>())
            .RuleFor(o => o.EntityType, f => f.PickRandom<EntityType>())
            .RuleFor(o => o.ContributorOrganizationName, f => f.Company.CompanyName())
            .RuleFor(o => o.ContributorLastName, f => f.Name.LastName())
            .RuleFor(o => o.ContributorFirstName, f => f.Name.FirstName())
            .RuleFor(o => o.ContributorMiddleName, f => f.Name.FirstName())
            .RuleFor(o => o.ContributorPrefix, f => f.Name.Prefix())
            .RuleFor(o => o.ContributorSuffix, f => f.Name.Suffix())
            .RuleFor(o => o.ElectionCode, GenerateElectionCode)
            .RuleFor(o => o.ElectionOtherDescription, f => f.Lorem.Word())
            .RuleFor(o => o.ContributionDate, f => f.Date.Recent())
            .RuleFor(o => o.ContributionAmount, f => f.Finance.Amount())
            .RuleFor(o => o.ContributionAggregate, f => f.Finance.Amount())
            .RuleFor(o => o.ContributionPurpose, f => f.Lorem.Sentence(3))
            .RuleFor(o => o.ContributorEmployer, GenerateEmployer)
            .RuleFor(o => o.ContributorOccupation, GenerateJobTitle)
            .RuleFor(o => o.IsMemo, f => f.Random.Bool())
            .RuleFor(o => o.MemoText, f => f.Lorem.Sentence(3));
    }

    private static string GeneratePostalCode(Faker f)
    {
        return f.Address.ZipCode().Replace("-", "");
    }

    private static string GenerateJobTitle(Faker f)
    {
        var jobTitle = f.Name.JobTitle();
        if (jobTitle.Length > 38)
        {
            return jobTitle.Substring(0, 38);
        }

        return jobTitle;
    }

    private static string GenerateEmployer(Faker f)
    {
        var employer = f.Company.CompanyName();
        if (employer.Length > 38)
        {
            return employer.Substring(0, 38);
        }

        return employer;
    }

    private static string GenerateElectionCode(Faker f)
    {
        return $"{f.PickRandom('G', 'P', 'O')}{f.PickRandom("2020", "2021", "2022")}";
    }

    private static string GenerateFecFilingId(Faker f)
    {
        return $"fec-{f.Random.Int(1, 99999999):00000000}";
    }

    private static string GenerateFecFilerCommitteeId(Faker f)
    {
        return $"fec-{f.Random.Int(1, 9999):0000}";
    }

    private static string GenerateTransactionId(Faker f)
    {
        return $"fec-tx-{f.Random.Int(1, 9999):0000}";
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
