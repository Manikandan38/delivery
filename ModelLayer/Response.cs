using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ModelLayer
{
    public class EResponse
    {
        [Key]
        public int ResponseID { get; set; }

        public bool status { get; set; }

        public double Price { get; set; }

        public int RequestID { get; set; }


        public EResponse()
        {

        }

        public EResponse(int id, bool sts, double price, int reqid)
        {
            ResponseID = id;
            status = sts;
            Price = price;
            RequestID = reqid;
        }

    }

}
