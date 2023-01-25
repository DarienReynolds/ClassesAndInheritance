using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance
{
    class Refrigerator : Appliance
    {
        //Class Attributes
        private int numberOfDoors;
        private int height;
        private int width;

        //Class Constructor 
        public Refrigerator(long aItemNumber,
                            string aBrand,
                            int aQuantity,
                            double aWattage,
                            string aColor,
                            double aPrice,
                            int aNumberOfDoors,
                            int aHeight,
                            int aWidth) : base(aItemNumber, aBrand, aQuantity, aWattage, aColor, aPrice)
        {
            //From Base Class
            ItemNumber = aItemNumber;
            Brand = aBrand;
            Quantity = aQuantity;
            Wattage = aWattage;
            Color = aColor;
            Price = aPrice;

            //From Derived Class
            numberOfDoors = aNumberOfDoors;
            height = aHeight;
            width = aWidth;
        }


    }
}
