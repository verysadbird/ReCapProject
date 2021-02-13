using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=3, ModelYear=2015, DailyPrice=400, Description="Car1"},
                new Car{Id=2, BrandId=2, ColorId=1, ModelYear=2010, DailyPrice=200, Description="Car2"},
                new Car{Id=3, BrandId=3, ColorId=6, ModelYear=2012, DailyPrice=450, Description="Car3"},
                new Car{Id=4, BrandId=2, ColorId=4, ModelYear=2019, DailyPrice=500, Description="Car4"},
                new Car{Id=5, BrandId=1, ColorId=8, ModelYear=2021, DailyPrice=800, Description="Car5"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public string GetById(int id)
        {
            Car CarToShow = _cars.SingleOrDefault(c => c.Id == id);
            return CarToShow.Description;
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.Description = car.Description;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.BrandId = car.BrandId;
        }
    }
}
