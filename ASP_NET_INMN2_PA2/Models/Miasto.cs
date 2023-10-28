using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_NET_INMN2_PA2.Models;

public class Miasto
{
    public int Id { get; set; }
    public string? Nazwa { get; set; }
    public string? Województwo { get; set; }
    [Display(Name = "Data założenia")]
    [DataType(DataType.Date)]
    public DateTime? DataZałożenia { get; set; }
    public decimal? Powierzchnia { get; set; }
    [Column(TypeName = "decimal(10,0)")]
    public ulong? Populacja { get; set; }
    public string? Państwo { get; set; }
}
