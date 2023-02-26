using System;

namespace CarClassLibrary
{
    public class Car
    {
        public int ID { get; set; }
        public string? Model { get; set; }
        public int Price { get; set; }
        public string? LicensePlate { get; set; }

        public void ValidateModel()
        {
            if (Model?.Length < 4)
            {
                throw new ArgumentOutOfRangeException("Modelnavn må ikke være under 4 tegn (desværre Kia)");
            }
        }
        public void ValidatePrice()
        {
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException("Pris skal være mere end 0");
            }
        }
        public void ValidateLicensePlate()
        {
            if (LicensePlate == null)
            {
                throw new ArgumentNullException("Nummerplade må ikke være null");
            }
            if (LicensePlate.Length < 2 || LicensePlate.Length > 7) 
            {
                throw new ArgumentOutOfRangeException("Nummerpladen skal være på mere end 2 tegn, og må ikke være mere end 7");
            }
           
        }

    }
}