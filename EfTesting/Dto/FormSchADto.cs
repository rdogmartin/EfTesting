using EfTesting.Enums;
using EfTesting.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfTesting.Dto
{
    [Table("FormSchA", Schema = "fec")]
    public class FormSchADto : IDatabaseEntity
    {
        [Key]
        public int UniqueId { get; set; }

        [Column(TypeName = "nvarchar(35)")]
        public FecRecordType FormType { get; init; }

        [Required, StringLength(9)]
        public string FilerCommittedId { get; init; } = null!;

        [Required, StringLength(20)]
        public string TransactionId { get; init; } = null!;

        [Required, StringLength(20)]
        public string BackRefTransactionId { get; init; } = null!;

        [Column(TypeName = "nvarchar(35)")]
        public FecRecordType? BackRefScheduleName { get; init; }

        [Column(TypeName = "nchar(3)")]
        public EntityType EntityType { get; init; }

        [Required, StringLength(200)]
        public string ContributorOrganizationName { get; init; } = null!;

        [Required, StringLength(30)]
        public string ContributorLastName { get; init; } = null!;

        [Required, StringLength(20)]
        public string ContributorFirstName { get; init; } = null!;

        [Required, StringLength(20)]
        public string ContributorMiddleName { get; init; } = null!;

        [Required, StringLength(10)]
        public string ContributorPrefix { get; init; } = null!;

        [Required, StringLength(10)]
        public string ContributorSuffix { get; init; } = null!;

        [Required, StringLength(5)]
        public string ElectionCode { get; init; } = null!;

        [Required, StringLength(20)]
        public string ElectionOtherDescription { get; init; } = null!;

        public DateTime ContributionDate { get; init; }

        public decimal ContributionAmount { get; init; }

        public decimal ContributionAggregate { get; init; }

        [Required, StringLength(100)]
        public string ContributionPurpose { get; init; } = null!;

        [Required, StringLength(38)]
        public string ContributorEmployer { get; init; } = null!;

        [Required, StringLength(38)]
        public string ContributorOccupation { get; init; } = null!;

        public bool IsMemo { get; init; }

        [Required, StringLength(100)]
        public string MemoText { get; init; } = null!;
    }
}