using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17HW1
{
    public class ClassUser : Account
    {
        private string _id;
        private string _name;

        public ClassUser(string id, string name)
        {
            _id = id;
            _name = name;
        }
        public void PrintAcc()
        {
            Console.WriteLine($"Имя держателя: {_name}, \n\tId: {_id}");
        }
    }
}
