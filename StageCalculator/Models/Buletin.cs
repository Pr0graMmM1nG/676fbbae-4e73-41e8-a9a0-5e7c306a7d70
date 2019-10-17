using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StageCalculator.Models
{
    [Table("Buletin")]
    public class Buletin
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BuletinId { get; set; }
        
        public DateTime BuletinBirthDate { get; set; }
        
        public string BuletinBirthPlace { get; set; }
        
        public string  BuletinBloodGroup{ get; set; }
        
        public string BuletinHeight { get; set; }
        
        public string BuletinEyesColor { get; set; }
       
        public string BuletinSex{ get; set; }
        
        public string BuletinSeria { get; set; }
        [Required]
        public string BuletinPersonalCode { get; set; }
        
        public DateTime BuletinCreateDate { get; set; }
        
        public DateTime BuletinExpireDate { get; set; }

       
        
    }
}