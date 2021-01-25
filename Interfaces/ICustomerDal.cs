using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICustomerDal // Data Access Layor
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");

        }

        public void Update()
        {
            Console.WriteLine("Sql updated");

        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");

        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");

        }

        public void Update()
        {
            Console.WriteLine("Oracle updted");

        }


    }

    class MysqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added");

        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted");

        }

        public void Update()
        {
            Console.WriteLine("Mysql updted");

        }


    }

    class CustomerManager
        {
            public void Add(ICustomerDal customerDal)
            {
                customerDal.Add();
            }
        }
}
