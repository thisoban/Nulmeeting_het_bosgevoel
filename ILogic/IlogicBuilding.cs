using System;
using System.Collections.Generic;
using Models;
namespace ILogic
{
    public interface IlogicBuilding
    {
        List<BuildingModel> Avaible(ReservationModel reserve);
        decimal Tax(BuildingModel building, ReservationModel reservation);
        BuildingModel Reserve(BuildingModel building, ReservationModel reservation);
        
    }
}
