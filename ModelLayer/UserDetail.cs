using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ModelLayer
{
    public class UserDetail
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [MaxLength(length: 20, ErrorMessage = "Only 20 characters allowed.")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [MaxLength(length: 30, ErrorMessage = "*Only 30 characters allowed")]
        public string Name { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [MaxLength(length: 10, ErrorMessage = "*Only 10 numbers allowed")]
        [MinLength(length: 10, ErrorMessage = "*Must have 10 numbers")]
        public string Phone { get; set; }

        [Required]
        [MaxLength(length: 30, ErrorMessage = "*Only 30 characters allowed")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "City")]
        public int CityID { get; set; }
        public City City { get; set; }

        public bool IsVerified { get; set; }

        public UserDetail()
        {

        }

        public UserDetail(int id, string uname, string pass, int age)
        {
            UserID = id;
            UserName = uname;
            Password = pass;
            Age = age;
        }
    }
}
