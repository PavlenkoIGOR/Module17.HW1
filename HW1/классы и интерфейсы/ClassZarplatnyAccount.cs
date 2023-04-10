using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17HW1
{
    internal class ClassZarplatnyAccount : Account, ICalculateInterest
    {
        public void CalculateInterest(ClassUser classUser)
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            classUser.Interest = classUser.Balance * 0.5;
            Console.WriteLine(Environment.NewLine + $"Зарплатный аккаунт:\nСтавка: {classUser.Interest}, Баланс: {classUser.Balance}");
        }
    }
}
