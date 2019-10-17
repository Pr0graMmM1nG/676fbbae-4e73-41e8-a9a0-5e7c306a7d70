using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace StageCalculator.Models
{
    [Table("Stage")]
    class Stage
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StageId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
        [Required]
        public int PersonId { get; set; }
        [Required]
        public DateTime StageBeginDate { get; set; }
        [Required]
        public DateTime StageEndDate { get; set; }
        [ForeignKey("CompanyId")]
        public  virtual Company Company { get; set; }
        [Required]
        public int CompanyId { get; set; }


        
        

        
        
    }
}
