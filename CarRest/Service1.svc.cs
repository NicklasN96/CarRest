using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static readonly IList<Car> Cars = new List<Car>();
       

        static Service1()
        {
            Car firstCar = new Car
            {
                Brand = "Audi",
                ModelYear = 2016
            };
            Cars.Add(firstCar);
           
        }

        public IList<Car> GetBooks()
        {
            return Cars;
        }

        public Car GetCar(string modelYear)
        {
            int modelyear = int.Parse(modelYear);
            return Cars.FirstOrDefault(book => book.ModelYear == modelyear);
        }

        public Car AddCar(Car car)
        {
            Cars.Add(car);
            return car;
        }

        public Car UpdateCar(string modelYear, Car book)
        {
            int modelyear = int.Parse(modelYear);
            Car existingCar = Cars.FirstOrDefault(b => b.ModelYear == modelyear);
            if (existingCar == null) return null;
            existingCar.Brand = book.Brand;
            existingCar.ModelYear = book.ModelYear;
            return existingCar;
        }

        public Car DeleteCar(string modelYear)
        {
            Car car = GetCar(modelYear);
            if (car == null) return null;
            bool removed = Cars.Remove(car);
            if (removed) return car;
            return null;
        }
    }
}
