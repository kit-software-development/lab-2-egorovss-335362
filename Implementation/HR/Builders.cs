using System;
using Practice.Common;
using Practice.Organization;

namespace Practice.HR
{
    /// <summary>
    ///     Класс-фабрика, позволяющий получать экземпляры типов,
    ///     инкапсулированных на уровне библиотеки.
    /// </summary>
    public static class Builders
    {
        /// <summary>
        ///     Возвращает экземпляр "Строителя" клиентов.
        /// </summary>
        /// <returns>
        ///     Экземпляр типа IClientBuilder.
        /// </returns>

        internal class clientbuilder : IClientBuilder
        {
            private IClient client = new Client();

            public IClient Build()
            {
                return client;
            }

            public IClientBuilder Name(IName name)
            {
                client.Name = new Name(name);
                return this;
            }

            public IClientBuilder Discount(float discount)
            {
                client.Discount = discount;
                return this;
            }

            public IClientBuilder Name(string name, string surname, string patronymic)
            {
                client.Name = new Name(name, surname, patronymic);
                return this;
             }
        }

        public static IClientBuilder ClientBuilder()
        {
            /*
             * TODO #6: Реализовать фабричный метод ClientBuilder класса Builders
             */
            return new clientbuilder();
        }

        /// <summary>
        ///     Возвращает экземпляр "Строителя" сотудников.
        /// </summary>
        /// <returns>
        ///     Возвращает экземпляр типа IEmployeeBuilder.
        /// </returns>
        public static IEmployeeBuilder EmployeeBuilder()
        {
            /*
             * TODO #7: Реализовать фабричный метод EmployeeBuilder класса Builders
             */
            return new employeebuilder();
        }

        internal class employeebuilder : IEmployeeBuilder
        {
            private Employee emp = new Employee();

           public IEmployee Build()
           {
                return emp;
           }

            public IEmployeeBuilder Department(IDepartment dep)
            {
                emp.Department = dep;
                return this;
            }


            public IEmployeeBuilder Name(IName name)
            {
                emp.Name = new Name(name);
                return this;
            }

            public IEmployeeBuilder Department(string dep)
            {

                emp.Department = new Department(dep);

                return this;
            }


            public IEmployeeBuilder Name(string name, string surname, string patronymic)

            {
                emp.Name = new Name(name, surname, patronymic);
                return this;
            }

        }

    }
}
