using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Arispe.Models
{
    public class Arispe
    {
        [Key]
        public int ArispeID { get; set; }
        [Required]
        [StringLength(2, ErrorMessage ="The field {0} must contain betwen {2} and {1} characters", MinimumLength =24)]
        [Display(Name ="Nombre Completo")]
        public string FriendofArispe { get; set; }
        [Required]
        public List<int> Place { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Cumpleaños")]
        [DisplayFormat(DataFormatString ="0:dd/MM/yyyy")]
        public DateTime Birthdate { get; set; }
    }
}