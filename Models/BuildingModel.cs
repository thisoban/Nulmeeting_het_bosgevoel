using System;
using System.Collections.Generic;

namespace Models
{
    public abstract class BuildingModel
    {
        public int uniqueNumber { get; set; }
        public double Price { get; set; }
        public buildingType BuildingType { get; set;}
        public int MaxPerson { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool reserved { get; set; }
        public bool Reperation { get; set; }
        public List<Reservedmodel> reservedDatetime { get; set; }
    }
}
