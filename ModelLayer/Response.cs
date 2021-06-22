using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ModelLayer
{
    public class Response
    {
        [Key]
        public int ResponseID { get; set; }

        public AcceptReject status { get; set; }

        public double Price { get; set; }

        [ForeignKey("UserRequest"), Column(Order = 0)]
        public int? RequestID { get; set; }
        public UserRequest UserRequest { get; set; }


        public enum AcceptReject
        {
            Accept,
            Reject
        }
    }
}
