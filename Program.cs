using System;

namespace b1_chap13_inheritance
{
    public class Vehicle{
        public string MainColor {get; set;}

        public int MaximumOccupancy {get; set;}
        //virtual allows method to have an "override"
        public virtual void Drive()
        {
            Console.WriteLine("vroom");
        }
    }

    public class Zero : Vehicle {  // Electric motorcycle
                    public double BatteryKWh { get; set; }
                    

                    public void ChargeBattery () { }

                    public override void Drive()
                    {
                        Console.WriteLine("zoooooooom!");
                    }
                }
                public class Cessna : Vehicle {  // Propellor light aircraft
                    public double FuelCapacity { get; set; }
                    

                    public void RefuelTank () { }
                }
                public class Tesla : Vehicle {  // Electric car
                    public double BatteryKWh { get; set; }
                    
                    public void ChargeBattery () { }
                }
                public class Ram : Vehicle {  // Gas powered truck
                    public double FuelCapacity { get; set; }
                    

                    public void RefuelTank () {  }
                }
    class Program
    {
        static void Main(string[] args)
        {
              var zero = new Zero();
              var tesla = new Tesla();
              var cessna = new Cessna();
              var ram = new Ram(); 

              zero.MainColor = "white";
              tesla.MaximumOccupancy = 5; 

              zero.Drive();
        }
    }
}
