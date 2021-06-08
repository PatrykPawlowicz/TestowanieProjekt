using System;

namespace CarRental
{
    public class Calculator
    {
        public double calcCarValue(double value, double years, double volume, double hp)
        {
            double response;
            response = 0.05 * ((value - (0.1 * value * years) + volume) / (200/hp));
            return response;
        }
        public double calcDriverMod(double age, double driverLicence)
        {
            double response;
            response = 150 - age;
            response -= (driverLicence * 3);
            response = response / 100;
            return response;
        }
        public double calcResult(double value, double years, double volume, double hp, double age, double driverLicence)
        {
            double car = calcCarValue(value, years, volume, hp);
            double driver = calcDriverMod(age, driverLicence);
            double result = car * driver;
            return result;
        }
    }
}
