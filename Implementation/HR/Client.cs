using System;
using Practice.Common;
using Practice.HR.Events;

namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о клиенте.
    /// </summary>
    internal class Client : AbstractPerson, IClient
    {
        private float v_discount;
        public float Discount
        {
                get { return v_discount; }
                set {  DiscountChange?.Invoke(this, new ValueChangeEventArgs<float>(v_discount));
                       v_discount = value; }
        }

    public event EventHandler<ValueChangeEventArgs<float>> DiscountChange;
    /*
     * TODO #4: Реализуйте интерфейс IClient для класса Client
     */
}
}
