using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
  public class BungalowModel : BuildingModel
    {
        // type bungalow 
        //invalide of niet invalide
        public double Surface { get; set; }
        public bool WaterSide { get; set; }
        public int Rooms { get; set; }
        public bool Disabled { get; set; }

    }
}
