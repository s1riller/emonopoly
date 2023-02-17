using System;
using System.Collections.Generic;

namespace LinkedListTCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем связанный список
            LinkedList<Field> field = new LinkedList<Field>();
            //Добавляем field в список и получаем объект LinkedListNode<Field>
            //в котором храниться имя
            LinkedListNode<Field> adidas = field.AddLast(new Field() { Name = "adidas" });
            field.AddLast(new Field() { Name = "Nike" });
            field.AddFirst(new Field() { Name = "Puma" });

            // Отобразим элементы в прямом направлении
            LinkedListNode<Field> node;
            Console.WriteLine("Элементы коллекции в прямом направлении: ");
            for (node = field.First; node != null; node = node.Next)
                Console.Write(node.Value.Name + "\t");

            // Отобразить элементы в обратном направлении
            Console.WriteLine("\n\nЭлементы коллекции в обратном направлении: ");
            for (node = field.Last; node != null; node = node.Previous)
                Console.Write(node.Value.Name + "\t");

            Console.ReadLine();
        }
    }

    class Field
    {
        public string Name { get; set; }


    }
}
