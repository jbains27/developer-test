using System;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class BookViewingViewModel
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phone is Required")]
        public string Phone { get; set; }

        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email is not valid")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is Required")]
        public DateTime BookingTime { get; set; }
        public int PropertyId { get; set; }
        public string BuyerUserId { get; set; }
        public string PropertyType { get; set; }
        public string StreetName { get; set; }
    }
}