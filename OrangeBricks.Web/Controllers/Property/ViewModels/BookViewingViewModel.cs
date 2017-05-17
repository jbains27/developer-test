using System;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class BookViewingViewModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BookingTime { get; set; }
        public int PropertyId { get; set; }
        public string BuyerUserId { get; set; }
        public string PropertyType { get; set; }
        public string StreetName { get; set; }
    }
}