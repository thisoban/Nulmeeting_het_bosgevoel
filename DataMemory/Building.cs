using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DataMemory
{
    public class Building
    {
       public  List<BungalowModel> bungalows = new List<BungalowModel>();
        public List<HotelModel> rooms = new List<HotelModel>();
        BungalowModel bungalow1111 = new BungalowModel()
        {
            MaxPerson = 4,
            BuildingType = buildingType.bungalow,
            Price = 80.00,
            Reperation = false,
            reserved = false,
            uniqueNumber = 111,
            Surface = 90,
            Disabled = false,
            WaterSide = false,
            Rooms = 7
        };
        BungalowModel bungalow2222 = new BungalowModel()
        {
            MaxPerson = 4,
            BuildingType = buildingType.bungalow,
            Price = 80.00,
            Reperation = true,
            reserved = false,
            uniqueNumber = 112,
            Surface = 90,
            Disabled = true,
            WaterSide = false,
            Rooms = 4
        };
        HotelModel room1 = new HotelModel()
        {
            Minibar = true,
            BuildingType = buildingType.hotel,
            roomType = RoomType.TwoPersonSingle,
            MaxPerson = 2,
            Price = 60,
            Reperation = false,
            reserved = false,
            Shower = true,


        };  
        Reservedmodel bungalow11 = new Reservedmodel()
        {
            Start = DateTime.Now,
        };

        public void startup()
        {
         
            bungalows.Add(bungalow1111);
            bungalows.Add(bungalow2222);
        }

    }
}
