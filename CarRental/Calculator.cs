using System;

namespace CarRental
{
    public class Calculator
    {
        public double calcCarValue(double value, int years, int volume, int hp)
        {
            double response;
            response = value - 0.1 * value * years;
            response += volume;
            response = response / (hp / 200);
            response = response * 0.05;
            return response;
        }
        public double calcDriverMod(int age, int driverLicence, int exp, int goodDrive)
        {
            double response;
            response = 125 - age;
            response -= (driverLicence * 2);
            response -= (exp * 5);
            response -= goodDrive;
            response = response / 100;
            return response;
        }
        public double calcResult(double value, int years, int volume, int hp, int age, int driverLicence, int exp, int goodDrive)
        {
            double car = calcCarValue(value, years, volume, hp);
            double driver = calcDriverMod(age, driverLicence, exp, goodDrive);
            double result = car * driver;
            return result;
        }
    }
}
