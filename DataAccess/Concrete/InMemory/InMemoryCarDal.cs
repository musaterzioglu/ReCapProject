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
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>()
            {
                new Car(){Id=1,BrandId=1,ColorId=1,ModelYear="2016",DailyPrice=1360,Description="Porsche 718 Boxster"},
                new Car(){Id=2,BrandId=2,ColorId=2,ModelYear="2007",DailyPrice=1200,Description="Porsche 911 Turbo"},
                new Car(){Id=3,BrandId=3,ColorId=3,ModelYear="2014",DailyPrice=2575,Description="Porsche 911 Carrera 4S"},
                new Car(){Id=4,BrandId=4,ColorId=4,ModelYear="2012",DailyPrice=8950,Description="Porsche Panamera Diesel"},
                new Car(){Id=5,BrandId=5,ColorId=5,ModelYear="2020",DailyPrice=2600,Description="Porsche Taycan 4S"},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            //Ne zaman kullanırsanız kullanın SingleOrDefault, sorgunun en fazla tek bir sonuçla sonuçlanması gerektiğini açıkça belirtirsiniz .
            //Öte yandan, FirstOrDefault sorgusu kullanıldığında herhangi bir miktarda sonuç döndürebilir, ancak yalnızca ilkini istediğinizi belirtirsiniz.
            //SingleOrDefault anahtar sözcüğü ile dizi içerisinde bulunan elemanlardan
            //belirlenen koşula göre sadece bir tanesinin gelmesi sağlanır.
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
            
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int getById)
        {
            return _car.Where(c => c.Id == getById).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
