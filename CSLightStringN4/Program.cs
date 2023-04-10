using System;
using System.Text;

namespace CSLightStringN4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            uint age;
            string educationalInstitution;
            decimal money;
            string conclusion;

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Как вас зовут? ");
            name = Console.ReadLine();

            Console.Write("Сколько вам лет? ");
            age = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Где вы учитесь? ");
            educationalInstitution = Console.ReadLine();

            Console.Write("Сколько у вас есть денег? ");
            money = Convert.ToDecimal(Console.ReadLine());

            conclusion = $"Вас зовут {name}. Ваш возраст {age}. " +
                $"Вы учитесь в {educationalInstitution}. А денег у вас {money}. " +
                $"{name}, вы молодец!";

            Console.WriteLine(conclusion);
            Console.ReadLine();
        }
    }
}
