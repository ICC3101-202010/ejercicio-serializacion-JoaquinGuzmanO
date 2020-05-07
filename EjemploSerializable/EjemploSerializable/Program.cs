using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EjemploSerializable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person_l = new List<Person>();
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("Escoja entre las siguientes opciones" +
                    "[1]agregar personas,[2]ver personas,[3]serializar,[4]restaurar,[5]detener");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("diga el nombre:");
                    string name = Console.ReadLine();
                    Console.WriteLine("diga el apellido:");
                    string lastname = Console.ReadLine();
                    Console.WriteLine("diga la edad:");
                    string age = Console.ReadLine();
                    int age1 = Int16.Parse(age);
                    Person person = new Person(name, lastname, age1);
                    person_l.Add(person);
                }
                if (option == "2")
                {
                    for (int j = 0; j < person_l.Count(); j++)
                    {
                        person_l[j].Information();
                    }
                }
                if (option == "3")
                {
                    for (int j = 0; j < person_l.Count(); j++)
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(stream, person_l[j]);
                        stream.Close();
                    }
                }
                if (option == "4")
                {
                    for (int j = 0; j <= person_l.Count(); j++)
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                        Person person = (Person)formatter.Deserialize(stream);
                        stream.Close();
                    }
                }
                if (option == "5")
                {
                    Console.WriteLine("################################################");
                    break;
                }
            }
        }
    }
}
