using System;
using Practice.Common;
using Practice.HR.Events;
using Practice.Organization;

namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о сотруднике.
    /// </summary>
    internal class Employee : AbstractPerson, IEmployee
    {

        private IDepartment v_dep;

        public IDepartment Department
        {
            get { return v_dep; }

            set { DepartmentChange?.Invoke(this, new ValueChangeEventArgs<IDepartment>(v_dep));
                 v_dep = value; }
        }

     public event EventHandler<ValueChangeEventArgs<IDepartment>> DepartmentChange;
    }
}
