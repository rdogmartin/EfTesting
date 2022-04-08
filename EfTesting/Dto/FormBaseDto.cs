using EfTesting.Config;
using EfTesting.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfTesting.Dto;
[Table("FormBase", Schema = "fec")]
public class FormBaseDto
{
    public FormBaseDto()
    {
        FilingCommitteeEntityType = EntityType.PartyCommittee;
        FilingCommitteeFecId = string.Empty;
        FilingCommitteeName = string.Empty;
        FilingCommitteeAddressLine1 = string.Empty;
        FilingCommitteeAddressLine2 = string.Empty;
        FilingCommitteeCity = string.Empty;
        FilingCommitteeState = string.Empty;
        FilingCommitteePostalCode = string.Empty;

        TreasurerFirstName = string.Empty;
        TreasurerMiddleName = string.Empty;
        TreasurerLastName = string.Empty;
        TreasurerPrefix = string.Empty;
        TreasurerSuffix = string.Empty;

        IsAmendment = false;
        AmendmentNum = 0;
        Status = FecFormFilingStatus.Draft;
        FecFilingId = string.Empty;
        ValidationResult = string.Empty;
    }

    [Key]
    public int UniqueId { get; set; }

    [Column(TypeName = "tinyint")]
    public FecFormType? FormType { get; set; }

    [Column(TypeName = "smallint")]
    public FecFormSubtype? FormSubtype { get; set; }

    [Required, StringLength(50)]
    public string FecFilingId { get; set; }

    [Required]
    public bool IsAmendment { get; set; }

    [Required, Column(TypeName = "smallint")]
    public short AmendmentNum { get; set; }

    public DateTime? ReportPeriodStart { get; set; }

    public DateTime? ReportPeriodEnd { get; set; }

    [Required, Column(TypeName = "tinyint")]
    public FecFormFilingStatus Status { get; set; }

    [Required, Column(TypeName = "nvarchar(max)")]
    public string ValidationResult { get; set; }

    public DateTime? ValidationDateTime { get; set; }

    public DateTime? DateSigned { get; set; }
    
    #region Filing Entity

    [Required, Column(TypeName = "tinyint")]
    public EntityType FilingCommitteeEntityType { get; set; }

    [Required, MaxLength(Constants.FecMaxLength.FecId)]
    public string FilingCommitteeFecId { get; set; }

    [Required, StringLength(Constants.FecMaxLength.OrganizationName)]
    public string FilingCommitteeName { get; set; }

    #region Address

    [Required, StringLength(Constants.FecMaxLength.Address1)]
    public string FilingCommitteeAddressLine1 { get; set; }

    [Required, StringLength(Constants.FecMaxLength.Address2)]
    public string FilingCommitteeAddressLine2 { get; set; }

    [Required, StringLength(Constants.FecMaxLength.City)]
    public string FilingCommitteeCity { get; set; }

    [Required, StringLength(Constants.FecMaxLength.State)]
    public string FilingCommitteeState { get; set; }

    [Required, StringLength(Constants.FecMaxLength.PostalCode)]
    public string FilingCommitteePostalCode { get; set; }

    #endregion
    
    #endregion

    #region Treasurer

    [Required, StringLength(Constants.FecMaxLength.FirstName)]
    public string TreasurerFirstName { get; set; }

    [Required, StringLength(Constants.FecMaxLength.MiddleName)]
    public string TreasurerMiddleName { get; set; }

    [Required, StringLength(Constants.FecMaxLength.LastName)]
    public string TreasurerLastName { get; set; }

    [Required, StringLength(Constants.FecMaxLength.Prefix)]
    public string TreasurerPrefix { get; set; }

    [Required, StringLength(Constants.FecMaxLength.Suffix)]
    public string TreasurerSuffix { get; set; }

    #endregion
}
