using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
///Создание общиего интерфейса для всех аккаунтов с методом CalculateInterest()
///
namespace Module17HW1
{
    public interface ICalculateInterest
    {
        internal void CalculateInterest(ClassUser classUser);
    }
}
