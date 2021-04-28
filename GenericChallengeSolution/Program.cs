using System;
using System.Collections.Generic;

namespace GenericChallengeSolution
{
    public class ClassicCar
    {

        public string m_Make;
        public string m_Model;
        public int m_Year;
        public int m_Value;

        public ClassicCar(string make, string model, int year, int val)
        {
            m_Make = make;
            m_Model = model;
            m_Year = year;
            m_Value = val;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<ClassicCar> carList = new List<ClassicCar>();
            populateData(carList);

            // How many cars are in the collection?
            Console.WriteLine("There are {0} cars in the entire collection. \n",carList.Count);

            // How many "Ford" cars? FindAll();
            Predicate<ClassicCar> f = findFords;

            List<ClassicCar> ford = carList.FindAll(findFords);
            Console.WriteLine("There are {0} fords in the entire collection. \n", ford.Count);

            // what is the most valuable car?
            ClassicCar mostValuable = null; //temp
            int highValue = 0; //temp
            foreach(ClassicCar c in carList)
            {
                if(c.m_Value > highValue)
                {
                    mostValuable = c;
                    highValue = c.m_Value;
                }
            }
            Console.WriteLine("The most valuable car is a {0} {1} {2} at ${3}\n",
                            mostValuable.m_Year, mostValuable.m_Make, mostValuable.m_Model, mostValuable.m_Value);

            // What is the entire collection worth?
            int totalValue = 0;
            foreach (ClassicCar c in carList)
            {
                totalValue += c.m_Value;
            }
            Console.WriteLine("The collection is worth ${0}\n", totalValue);




            Console.ReadKey();
        }
        static void populateData(List<ClassicCar> theList)
        {
            theList.Add(new ClassicCar("Alfa Romeo", "Spider Veloce", 1965, 15000));
            theList.Add(new ClassicCar("Alfa Romeo", "1750 Berlina", 1970, 20000));
            theList.Add(new ClassicCar("Alfa Romeo", "Giuletta", 1978, 45000));
            theList.Add(new ClassicCar("Ford", "Thunderbird", 1971, 15000));
            theList.Add(new ClassicCar("Ford", "Mustang", 1976, 15000));
            theList.Add(new ClassicCar("Ford", "Corsair", 1970, 15000));
            theList.Add(new ClassicCar("Ford", "LTD", 1969, 15000));
            theList.Add(new ClassicCar("Chevrolet", "Camaro", 1979, 15000));
            theList.Add(new ClassicCar("Chevrolet", "Corvette Stringray", 1966, 15000));
            theList.Add(new ClassicCar("Chevrolet", "Monte Carlo", 1984, 15000));
            theList.Add(new ClassicCar("Mercedes", "300SL Roadster", 1957, 15000));
            theList.Add(new ClassicCar("Mercedes", "SSKL", 1930, 15000));
            theList.Add(new ClassicCar("Mercedes", "130H", 1936, 15000));
            theList.Add(new ClassicCar("Mercedes", "250SL", 1968, 15000));

        }
        static bool findFords(ClassicCar car)
        {
            int count = 0;
                if (car.m_Make == "Ford")
                  return true;
                          
            return false;
        }

       
    }
}
