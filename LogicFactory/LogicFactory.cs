using ILogic;
using Logic_Bosgevoel;
using System;

namespace LogicFactory
{
    public static class LogicFactory
    {
        public static IlogicBuilding GProductLogic()
        {
            return new LogicBuilding();
        }
    }
}
