using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EfCarDal carDal = new EfCarDal();
            CarManager carManager = new CarManager(carDal);

            Car car1 = new Car();
            car1.BrandId = 1;
            car1.ColorId = 2;
            car1.DailyPrice = 50;
            car1.Description = "Nissan";
            car1.Id = 0;
            car1.ModelYear = 2017;

            carManager.Add(car1);
            

        }
    }
}
