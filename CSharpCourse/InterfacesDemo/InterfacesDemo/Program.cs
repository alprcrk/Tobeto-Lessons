using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------* Çoklu İmplementasyon *--------
            // Bir çalışan arrayı oluşturmak istediğimde 
            IWorker[] workers = new IWorker[3]// tane çalışan
            {
                new Manager(),
                new Worker(),
                new Robot()
            }; 
            foreach (var worker in workers)
            {
                worker.Work(); // Bütün personele çalış emri vermiş oluyorum.
            }
            // Yemek için izin
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats) 
            {
                eat.Eat();
            }

        }
    }
    // Interfacelerin doğru planlanması
    interface IWorker
    {
        void Work();
    }
    // Araştırma: SOLID, Interface Segregation
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void Salary();
    }


    // 3 tip çalışan
    class Manager : IWorker, IEat, ISalary // Bir classın birden fazla Interfacesi Implamente edebilir.
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }
        public void GetSalary()
        {
            throw new NotImplementedException();
        }
        public void Work()
        {
            throw new NotImplementedException();
        }

    }
    class Worker: IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }
        public void GetSalary()
        {
            throw new NotImplementedException();
        }
        public void Work()
        {
            throw new NotImplementedException();
        }

    }
    class Robot: IWorker, IEat, ISalary
    {
        public void Work()
        {
            throw new NotImplementedException();
        }


    }
}
