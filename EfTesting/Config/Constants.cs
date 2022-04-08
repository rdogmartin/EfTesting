namespace EfTesting.Config;

public static class Constants
{
    public static class AppSettings
    {
        public const string PrimaryAppConnection = "PrimaryAppConnection";
        public const string AllowedOrigins = "AllowedOrigins";
        public const string EnvironmentName = "EnvironmentName";
    }

    /// <summary>
    /// These are the max string length's for the .FEC files that we will be creating.
    /// These values come from the FEC's "spec" sheet. It gets updated rarely.
    /// http://docquery.fec.gov/formatspecs/FEC_EFO_Format_Specifications.xlsx
    /// </summary>
    public static class FecMaxLength
    {
        public const ushort OrganizationName = 200;
        public const ushort FecId = 9;
        public const ushort PartyCode = 3;
        public const ushort PartyType = 3;
        public const ushort ElectionDescription = 20;

        public const ushort FirstName = 20;
        public const ushort MiddleName = 20;
        public const ushort LastName = 30;
        public const ushort Prefix = 10;
        public const ushort Suffix = 10;
        public const ushort Title = 20; // Title or Position

        public const ushort Employer = 38;
        public const ushort Occupation = 38;

        public const ushort Address1 = 34;
        public const ushort Address2 = 34;
        public const ushort City = 30;
        public const ushort State = 2;
        public const ushort PostalCode = 9;
        public const ushort District = 2;

        public const ushort Phone = 10;
        public const ushort Email = 90;
        public const ushort WebUrl = 90;

        public const ushort MemoText = 100;
        public const ushort Form99Text = 4000;

        public const ushort DollarAmount = 12;
        public const ushort LoanDueDateTerms = 15;
        public const ushort InterestRateTerms = 15;

        public const ushort OfficeSought = 1;
    }

    public class Enums
    {
        public enum Environment
        {
            Unknown,
            Local,
            Development,
            Test,
            UAT,
            Production
        }
    }
}
