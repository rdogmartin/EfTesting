using EfTesting.Enums;
using EfTesting.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfTesting.Dto
{
    [Table("FormSchA2", Schema = "fec")]
    public class FormSchA2Dto : IDatabaseEntity
    {
        [Key]
        public int UniqueId { get; set; }

        [Column(TypeName = "tinyint")]
        public FecRecordType FormType { get; set; }

        [Required, StringLength(9)]
        public string FilerCommittedId { get; set; } = null!;

        [Required, StringLength(20)]
        public string TransactionId { get; set; } = null!;

        [Required, StringLength(20)]
        public string BackRefTransactionId { get; set; } = null!;

        [Column(TypeName = "tinyint")]
        public FecRecordType BackRefScheduleName { get; set; }

        [Column(TypeName = "tinyint")]
        public EntityType EntityType { get; set; }

        [Required, StringLength(200)]
        public string ContributorOrganizationName { get; set; } = null!;

        [Required, StringLength(30)]
        public string ContributorLastName { get; set; } = null!;

        [Required, StringLength(20)]
        public string ContributorFirstName { get; set; } = null!;

        [Required, StringLength(20)]
        public string ContributorMiddleName { get; set; } = null!;

        [Required, StringLength(10)]
        public string ContributorPrefix { get; set; } = null!;

        [Required, StringLength(10)]
        public string ContributorSuffix { get; set; } = null!;

        [Required, StringLength(5)]
        public string ElectionCode { get; set; } = null!;

        [Required, StringLength(20)]
        public string ElectionOtherDescription { get; set; } = null!;

        public DateTime ContributionDate { get; set; }

        public decimal ContributionAmount { get; set; }

        public decimal ContributionAggregate { get; set; }

        [Required, StringLength(100)]
        public string ContributionPurpose { get; set; } = null!;

        [Required, StringLength(38)]
        public string ContributorEmployer { get; set; } = null!;

        [Required, StringLength(38)]
        public string ContributorOccupation { get; set; } = null!;

        public bool IsMemo { get; set; }

        [Required, StringLength(100)]
        public string MemoText { get; set; } = null!;
    }
}