using EfTesting.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfTesting.Dto;

[Table("Form99", Schema = "fec")]
public class Form99Dto : FormBaseDto
{
    public Form99Dto()
    {
        TextContent = string.Empty;
        DocumentType = Form99DocType.MiscReportToFec;
    }

    [Required, Column(TypeName = "tinyint")]
    public Form99DocType DocumentType { get; set; }

    [Required, Column(TypeName = "nvarchar(max)")]
    public string TextContent { get; set; }
}
