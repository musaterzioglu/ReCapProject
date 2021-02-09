using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Veritabani bağli verilerimiz yok, veri çekerek ya da oluşturduğumuzda düzenleyeceğiz.
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} {1} {2}", "Araba Markası: " + car.Description, "Üretim Yılı: "
                    + car.ModelYear, "Kiralama Fiyatı: " + car.DailyPrice);
            }



        }
    }
}
