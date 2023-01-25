using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance
{
    class Appliance
    {
        //Class Attributes
        private long itemNumber;
        private string brand;
        private int quantity;
        private double wattage;
        private string color;
        private double price;

        //Class Constructor
        public Appliance(long aItemNumber,
                         string aBrand,
                         int aQuantity,
                         double aWattage,
                         string aColor,
                         double aPrice) 
        {
            itemNumber = aItemNumber;
            brand = aBrand;
            quantity = aQuantity;
            wattage = aWattage;
            color = aColor;
            price = aPrice;
        }

        //Setters and Getters
        public long ItemNumber
        { get { return itemNumber; } 
            set { itemNumber = value; } }
        public string Brand
        { get { return brand; } 
            set { brand = value; } }
        public int Quantity
        { get { return quantity; } 
            set { quantity = value; } }
        public double Wattage
        { get { return wattage; }
            set
            { wattage = value;} }
        public string Color
        { get { return color; }
            set
            { color = value; } }
        public double Price
        { get { return price; }
            set
            { price = value;} }

        //Appliance Availability Method
        public bool isAvailable(Appliance a1)
        {
            return true;
        }

        //Checkout Method
        public void checkout(Appliance a1)
        {

        }

        //Formatting Appliance Data to File
        public string formatForFile(List<Appliance> aList)
        {
            return "placeholder";
        }

        //ToString Method
        public override string ToString()
        {
            return base.ToString();

        }
    }
}
