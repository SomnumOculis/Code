using System;

namespace Gethashgode
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Identifier { get; }

        public Person(string name, DateTime birthDate, string birthPlace, string identifier)
        {
            Name = name;
            BirthDate = birthDate;
            BirthPlace = birthPlace;
            Identifier = identifier;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Person otherPerson = (Person)obj;

            return Name == otherPerson.Name &&
                   BirthDate == otherPerson.BirthDate &&
                   BirthPlace == otherPerson.BirthPlace &&
                   Identifier == otherPerson.Identifier;
        }

        public override int GetHashCode()
        {
            return Identifier.GetHashCode();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество человек: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Выберите тип идентификатора (1 - номер паспорта, 2 - фамилия): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Информация про {i + 1} человека");
                Console.WriteLine("Введите Имя и отчество: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите дату рождения: ");
                DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Введите место рождения: ");
                string birthPlace = Console.ReadLine();
                string identifier = "";

                if (choice == 1)
                {
                    Console.WriteLine("Введите номер паспорта: ");
                    identifier = Console.ReadLine();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Введите фамилию: ");
                    identifier = Console.ReadLine();
                }

                
                Person person = new Person(name, birthDate, birthPlace, identifier);

               
            }

            Console.WriteLine();
            Console.WriteLine("Повторить ввод данных? (1 - yes, 0 - no): ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Main();
            }
            return;
        }
    }
}