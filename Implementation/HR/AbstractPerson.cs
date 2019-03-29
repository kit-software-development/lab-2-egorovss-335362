using System;
using Practice.Common;
using Practice.HR.Events;

namespace Practice.HR
{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson : IPerson
    {
        private IName v_name;

        public IName Name
        {
            get
            {
                return v_name;
            }

            set
            {
                NameChange?.Invoke(this, new ValueChangeEventArgs<IName>(v_name));
                v_name = value;
            }
        }

        public event EventHandler<ValueChangeEventArgs<IName>> NameChange;

    /*
     * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
     */
}
}
