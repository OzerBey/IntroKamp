﻿using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] { new Manager(),new Worker(),new Robot()};

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eatWorkers = new IEat[2] { new Worker(),new Manager()};

            foreach (var eatworker in eatWorkers)
            {
                eatworker.Eat();
            }
        }
    }
    interface IWorker
    {
        void Work();

    }

    interface IEat
    {
        void Eat();

    }

    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
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

    class Worker : IWorker, IEat, ISalary
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

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
