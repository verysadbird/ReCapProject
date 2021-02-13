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
            car1.BrandId = 2;
            car1.ColorId = 2;
            car1.DailyPrice = 50;
            car1.Description = "Nissan";
            car1.Id = 1;
            car1.ModelYear = 2017;

            Car car2 = new Car();
            car2.BrandId = 1;
            car2.ColorId = 2;
            car2.DailyPrice = 70;
            car2.Description = "Hyundai";
            car2.Id = 2;
            car2.ModelYear = 2019;

            carManager.GetCarsByBrandId(2);

            //carManager.Add(car1);
            //carManager.Add(car2);
            //carManager.Delete(car1);

            //EfColorDal colorDal = new EfColorDal();
            //ColorManager colorManager = new ColorManager(colorDal);

            //Color pink = new Color();
            //pink.ColorId = 1;
            //pink.ColorName = "Pink";

            //colorManager.Delete(pink);


        }
    }
}
