using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17HW1
{
    internal class ClassObychnyAccount : Account, ICalculateInterest
    {
        // Метод для расчета процентной ставки
        public void CalculateInterest(ClassUser classUser)
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            classUser.Interest = classUser.Balance * 0.4;

            if (classUser.Balance < 1000)
                classUser.Interest -= classUser.Balance * 0.2;

            if (classUser.Balance < 1000 && classUser.Balance < 50000)
                classUser.Interest -= classUser.Balance * 0.4;


            Console.WriteLine(Environment.NewLine + $"Обычный аккаунт:\nСчёт {classUser.Type}, Баланс {classUser.Balance}, ставка {classUser.Interest}");
        }
    }
}
