using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaKereskedesDemo.Models
{
    public class Car
    {
        public int ID { get; }
        public int brandID { get; }
        public string model { get; }
        public int price { get; }
        public int fuelID { get; }
        public int numberOfAxes { get; }
        public int numberOfDoors { get; }
        public string drivetrain { get; }
        public string color{ get; }
        public bool available { get; }

        public Car(int id, int brandID, string model, int price, int fuelID, int numberOfAxes, int numberOfDoors, string drivetrain, string color, bool available)
        {
            ID = id;
            this.brandID = brandID;
            this.model = model;
            this.price = price;
            this.fuelID = fuelID;
            this.numberOfAxes = numberOfAxes;
            this.numberOfDoors = numberOfDoors;
            this.drivetrain = drivetrain;
            this.color = color;
            this.available = available;
        }
    }
}
