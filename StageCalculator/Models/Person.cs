using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using StageCalculator.Interface;

namespace StageCalculator.Models
{
    [Table("People")]
    public class Person: IClassIDandName
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        [Required]
        public string PersonName { get; set; }
        [Required]
        public string PersonFamily { get; set; }
        
        public string PersonLastName { get; set; }

        
        [ForeignKey("BuletinId")]
        public virtual Buletin Buletin { get; set; }
        [Required]
        public int BuletinId { get; set; }


        public int GetID()
        {
            return PersonId;
        }

        public string GetName()
        {
            return string.Concat(PersonName," ",PersonFamily," ",PersonLastName);
        }
    }
}
