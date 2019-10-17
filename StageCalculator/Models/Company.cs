using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using StageCalculator.Interface;

namespace StageCalculator.Models
{
    [Table("Companies")]
    class Company: IClassIDandName
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }

        public int GetID()
        {
            return CompanyId;
        }

        public string GetName()
        {
            return CompanyName;
        }
    }
   
}
