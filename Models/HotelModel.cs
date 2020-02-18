using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class HotelModel:BuildingModel
    {
        public RoomType roomType { get; set; }
        public bool Shower { get; set; }
        public bool Wifi { get; set; }
        public bool Minibar { get; set; }


    }
}
