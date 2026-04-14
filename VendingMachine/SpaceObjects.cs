using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class SpaceObjects 
    {
        public int earthDistance = 0;
        public static Random rnd = new Random();
        public virtual string GetInfo()
        {
            var str = String.Format("\nУдалённость от Земли: {0} св. лет", this.earthDistance);
            return str;
        }
    }

    public class Planet : SpaceObjects
    {
        public int gForce = 0;
        public int radius = 0;
        public bool hasAtmosphere = false;

        public override string GetInfo()
        {
            var str = "Я планета";
            str += String.Format("\nСила притяжения: {0} м/с^2", this.gForce);
            str += String.Format("\nРадиус: {0} * 10^3 км", this.radius);
            str += String.Format("\nАтмосфера: {0}", this.hasAtmosphere);
            return str;
        }

        public static Planet Generate()
        {
            return new Planet
            {
                earthDistance = 1 + rnd.Next() % 101,
                gForce = 1 + rnd.Next() % 26,
                radius = 10 + rnd.Next() % 71,
                hasAtmosphere = rnd.Next() % 2 == 0
            };
        }
    }

    public enum StarColor { blue, white, yellow, green, red };
    public class Star : SpaceObjects
    {
        public int density = 0;
        public StarColor color = StarColor.blue;
        public int temperature = 0;

        public override string GetInfo()
        {
            var str = "Я звезда";
            str += String.Format("\nПлотность: {0} * 10^3 кг/м^3", this.density);
            str += String.Format("\nЦвет: {0}", this.color);
            str += String.Format("\nТемпература (Кельвины): {0} * 10^3 К", this.temperature);
            return str;
        }

        public static Star Generate()
        {
            return new Star
            {
                earthDistance = 1 + rnd.Next() % 100,
                density = 50 + rnd.Next() % 151,
                color = (StarColor)rnd.Next(5),
                temperature = 1 + rnd.Next() % 200
            };
        }
    }

    public enum CometNames 
    {
        Halley, Encke, Bopp, Hyakutake, Borrelly, Tempel1, Wild2, Ikeya_Seki,Churymov_Gerasimenko, Shoemaker_Levy9
    };
    public class Comet : SpaceObjects
    {
        public int transitPeriod = 0;
        public CometNames name = CometNames.Halley;

        public override string GetInfo()
        {
            var str = "Я комета";
            str += String.Format("\nПериод прохождения через солнечную систему: {0} лет", this.transitPeriod);
            str += String.Format("\nНазвание: {0}", this.name);
            return str;
        }

        public static Comet Generate()
        {
            return new Comet
            {
                earthDistance = 1 + rnd.Next() % 100,
                transitPeriod = 1 + rnd.Next() % 200,
                name = (CometNames)rnd.Next(10)
            };
        }
    }
}
