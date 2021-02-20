using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //ColorTest();



            EfBrandDal brandDal = new EfBrandDal();
            BrandManager brandManager = new BrandManager(brandDal);

            Brand porsche = new Brand();
            porsche.BrandId = 3;
            porsche.BrandName = "Porsche";

            //brandManager.Add(porsche);
            //brandManager.Add(new Brand { BrandId = 4, BrandName = "Lamborghini" });
            //brandManager.Add(new Brand { BrandId = 5, BrandName = "Lotus" });
            //brandManager.Add(new Brand { BrandId = 1, BrandName = "Hyundai" });
            //brandManager.Add(new Brand { BrandId = 2, BrandName = "Nissan" });
            //brandManager.Add(new Brand { BrandId = 3, BrandName = "Ford" });



            CarManager carManager = new CarManager(new EfCarDal());

            //foreach(var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine("Brand Id: " + brand.BrandId + "      Brand Name: " + brand.BrandName);
            //}


            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.GetAll();

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("Car: " + car.ColorName + "Brand: " + car.BrandName);
            }

        }




        private static void ColorTest()
        {
            EfColorDal colorDal = new EfColorDal();
            ColorManager colorManager = new ColorManager(colorDal);

            Color pink = new Color();
            pink.ColorId = 1;
            pink.ColorName = "Pink";

            colorManager.Delete(pink);
        }

        private static void CarTest()
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

            carManager.Add(car1);
            carManager.Add(car2);
            carManager.Delete(car1);
        }
    }
}
