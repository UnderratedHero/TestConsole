using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Test.Three;

namespace Test.Three
{
    internal class taskThree
    {
        private MyHashTable? _hashTable;
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Создайте справочник, введя количество элементов в нем");
            Console.WriteLine("Введите количество элементов в справочнике: ");
            var size = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Для продолжения, нажмите любую клавишу");
            Console.ReadKey();
            _hashTable= new MyHashTable(size);
            while (true)
            {
                var menu = @"
Введите номер меню:
1)Добавить данные в справочник;
2)Удалить данные из справочника;
3)Редактировать данные в справочнике;
4)Вывести все данные из справочника;
0)Выход.";
                Console.Clear();
                Console.WriteLine(menu);
                var menuNumber = Convert.ToInt32(Console.ReadLine());
                switch (menuNumber)
                {
                    case 1:
                        {
                            Add();
                            break;
                        }
                    case 2:
                        {
                            Delete();
                            break;
                        }
                    case 3:
                        {
                            Update();
                            break;
                        }
                    case 4:
                        {
                            Print(); 
                            break;
                        }
                    case 0:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Вы ввели неправильное число");
                            break;
                        }
                }
            }
        }
        private void Add()
        {
            Console.Clear();
            Console.WriteLine("Введите Фамилию через пробел: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Введите Имя через пробел: ");
            var name = Console.ReadLine();
            Console.WriteLine("Введите Отчество через пробел: ");
            var patronymic = Console.ReadLine();
            Console.WriteLine("Введите код оператора мобильной связи: ");
            var code = Console.ReadLine();
            Console.WriteLine("Введите номер телефона по принципу '99-99-999': ");
            var number = Console.ReadLine();
            var key = surname + " " + name + " " + patronymic;
            var value = "+375(" + code + ")" + string.Join("", number.Split('-')) ;
            if(_hashTable.AddElement(key, value))
            {
                Console.WriteLine("Элемент добавлен");
                Console.WriteLine("Для продолжения, нажмите любую клавишу");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Элемент добавлен, но произошла коллизия");
            Console.WriteLine("Для продолжения, нажмите любую клавишу");
            Console.ReadKey();
        }
        private void Delete()
        {
            Console.Clear();
            Console.WriteLine("Введите Фамилию через пробел: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Введите Имя через пробел: ");
            var name = Console.ReadLine();
            Console.WriteLine("Введите Отчество через пробел: ");
            var patronymic = Console.ReadLine();
            Console.WriteLine("Введите код оператора мобильной связи: ");
            var code = Console.ReadLine();
            Console.WriteLine("Введите номер телефона по принципу '99-99-999': ");
            var number = Console.ReadLine();
            var key = surname + " " + name + " " + patronymic;
            var value = "+375(" + code + ")" + string.Join("", number.Split('-'));
            if (_hashTable.RemoveElement(key, value))
            {
                Console.WriteLine("Удаление прошло успешно");
                Console.WriteLine("Для продолжения, нажмите любую клавишу");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Удалить элемент не удалось");
            Console.WriteLine("Для продолжения, нажмите любую клавишу");
            Console.ReadKey();
        }

        private void Update()
        {
            Console.Clear();
            Console.WriteLine("Введите Фамилию через пробел: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Введите Имя через пробел: ");
            var name = Console.ReadLine();
            Console.WriteLine("Введите Отчество через пробел: ");
            var patronymic = Console.ReadLine();
            Console.WriteLine("Введите старый код оператора мобильной связи: ");
            var oldCode = Console.ReadLine();
            Console.WriteLine("Введите старый номер телефона по принципу '99-99-999': ");
            var oldNumber = Console.ReadLine();
            var key = surname + " " + name + " " + patronymic;
            var oldValue = "+375(" + oldCode + ")" + string.Join("", oldNumber.Split('-'));
            Console.WriteLine("Введите новый код оператора мобильной связи: ");
            var newCode = Console.ReadLine();
            Console.WriteLine("Введите новый номер телефона по принципу '99-99-999': ");
            var newNumber = Console.ReadLine();
            var newValue = "+375(" + newCode + ")" + string.Join("", newNumber.Split('-'));
            if (_hashTable.UpdateElement(key, oldValue, newValue))
            {
                Console.WriteLine("Обновление контакта произошло успешно");
                Console.WriteLine("Для продолжения, нажмите любую клавишу");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Обновить контакт не удалось");
            Console.WriteLine("Для продолжения, нажмите любую клавишу");
            Console.ReadKey();
        }

        private void Print()
        {
            Console.Clear();
            var contacts = _hashTable.GetAllElements();
            foreach (var contact in contacts)
            {
                if (contact == null)
                {
                    continue;   
                }
                foreach (var pair in contact)
                {
                    Console.WriteLine($"Ключ: {pair.Key}, Значение: {pair.Value}");
                }
            }
            Console.WriteLine("Для продолжения, нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
