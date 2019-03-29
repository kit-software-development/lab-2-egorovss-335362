namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>

    internal struct Name : IName
    {
        public string FullName { get; }
        public string ShortName { get; }
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */

        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; }
        
        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; }
        
        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; }


        public Name(string surname, string firstname, string patronymic)
        {
            FirstName = firstname;
            Surname = surname;
            Patronymic = patronymic;
            ShortName = surname + " " + firstname.Substring(0, 1) + "." + patronymic.Substring(0, 1) + ".";
            FullName = surname + " " + firstname + " " + patronymic;
        }

        public Name(IName name)
        {
            FullName = name.FullName;
            ShortName = name.ShortName;

            var arr = FullName.Split(' ');

            Surname = arr[0];

            FirstName = arr[1];

            Patronymic = arr[2];

        }

    }
}
