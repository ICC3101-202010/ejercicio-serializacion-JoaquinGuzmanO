using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;


namespace EjemploSerializable
{
    [Serializable]
    public class Person
    {
        private string name;
        private string lastname;
        private int age;

        public Person(string name, string lastname, int age)
        {

            this.name = name;
            this.lastname = lastname;
            this.age = age;

        }
        public void Information()
        {
            Console.WriteLine("nombre: " + name + " " + "apellido: " + lastname + " " + "edad: "
                + age);

        }
    }
}
