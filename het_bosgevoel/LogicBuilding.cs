using ILogic;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Bosgevoel
{
  public class LogicBuilding : IlogicBuilding
    {
        public decimal pricing()
        {
            decimal price = 0;
            return price;
        }

        public List<BuildingModel> Avaible(ReservationModel reserve)
        {
            List<BuildingModel> BuildingsDb = new List<BuildingModel>();
            List<BuildingModel> buildings = new List<BuildingModel>();
            foreach (BuildingModel building in BuildingsDb)
            {
                if (building.Reperation == false || reserve.persons <= building.MaxPerson )
                {
                    foreach (Reservedmodel res in building.reservedDatetime)
                    {
                        if (res.Start.Ticks != reserve.Start.Ticks || res.Start != reserve.End || res.End != reserve.Start || res.End != reserve.End )
                        {
                            buildings.Add(building);
                        }
                    }
                   
                }
            }
            throw new NotImplementedException();
        }

        public decimal Tax(BuildingModel building, ReservationModel reservation)
        {
            double AdultPrice = 1.50;
            double kidUnder18Price = 1.00;
            double Carpark = 5.00;
            double pricing = reservation.persons * AdultPrice;
            long time = reservation.End.Ticks - reservation.Start.Ticks;
            pricing += building.Price * (double)time;


            throw new NotImplementedException();
        }

        public BuildingModel Reserve(BuildingModel building, ReservationModel reservation)
        {
            throw new NotImplementedException();
        }
    }
}
