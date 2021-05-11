using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingListToClass
{
    class Cars
    {
        public static List<Car> GetCars()
        {
            return new List<Car> //This is our database or datasource
            {
                new Car(){Owner="Mike", Type=CarType.Hatchback, Brand=CarBrand.Chevrolet},
                new Car(){Owner="Job", Type=CarType.Sedan, Brand=CarBrand.Mazda},
                new Car(){Owner="Emma", Type=CarType.SUV, Brand=CarBrand.Toyota}

            }.ToList();
        }
    }
}
