using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ModelLayer
{
    public class UserRequest
    {
        [Key]
        public int RequestID { get; set; }


        [Required]
        [Remote("IsValidDate", "Validation", HttpMethod = "POST", ErrorMessage = "*Please provide a valid Date!")]
        [Display(Name = "Date and Time of Pickup")]
        public DateTime DTofPickup { get; set; }

        [Required]
        [Display(Name = "Weight Of Package")]
        [Range(1, 10, ErrorMessage = "*Weight Below 1kg and Above 10kg are not Acceptable")]
        public double WeightOfPackage { get; set; }

        [Required]
        [MaxLength(length: 30, ErrorMessage = "*Only 30 characters allowed")]
        public string Address { get; set; }


        [ForeignKey("City"), Column(Order = 0)]
        public int? CityID { get; set; }
        public City City { get; set; }



        [ForeignKey("UserDetail"), Column(Order = 1)]
        public int? UserID { get; set; }
        public UserDetail UserDetail { get; set; }


        [ForeignKey("ExecutiveDetail"), Column(Order = 2)]
        public int? ExecutiveID { get; set; }
        public ExecutiveDetail ExecutiveDetail { get; set; }




        public class ValidationControl : Controller
        {
            [HttpPost]
            public JsonResult IsValidDate(string dob)
            {
                var min = DateTime.Now;
                var max = DateTime.Now.AddDays(3);
                var msg = string.Format("Please enter a date between {0:MM/dd/yyyy} and {1:MM/dd/yyyy}", min, max);

                try
                {
                    var date = DateTime.Parse(dob);
                    if (date >= min && date <= max)
                        return Json(msg);
                    else
                        return Json(true);
                }
                catch (Exception)
                {

                    return Json(msg);
                }
            }
        }
    }
}
