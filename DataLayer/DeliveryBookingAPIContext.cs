using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeliveryBookingAPI.ModelLayer;

namespace DeliveryBookingAPI.DataLayer
{
    public class DeliveryBookingAPIContext : DbContext
    {

        public DeliveryBookingAPIContext (DbContextOptions<DeliveryBookingAPIContext> options)
            : base(options)
        {

        }

        public DbSet<DeliveryBookingAPI.ModelLayer.City> City { get; set; }

        public DbSet<DeliveryBookingAPI.ModelLayer.UserDetail> UserDetail { get; set; }

        public DbSet<DeliveryBookingAPI.ModelLayer.ExecutiveDetail> ExecutiveDetail { get; set; }

        public DbSet<DeliveryBookingAPI.ModelLayer.UserRequest> UserRequest { get; set; }

        public DbSet<DeliveryBookingAPI.ModelLayer.EResponse> EResponse { get; set; }


        //public DbSet<DeliveryBookingAPI.ModelLayer.Response> Response { get; set; }

        //public DbSet<DeliveryBookingAPI.ModelLayer.ExecutiveResponse> ExecutiveResponses { get; set; }
        
    }
}
