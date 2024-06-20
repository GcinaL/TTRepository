using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TicketTracking.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [DisplayName("User Name")]
        public string Username { get; set; }


        [DisplayName("Password")]
        public string Password { get; set; }


        [DisplayName("User Type")]
        public string Type { get; set; }
    }
}
