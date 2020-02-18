using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ReservationModel
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Zipcode { get; set; }
        public string HouseNumber { get; set; }
        public int persons { get; set; }
        public int KidsUnder4 { get; set; }
        public int KidsUnder18 { get; set; }
    }
}
