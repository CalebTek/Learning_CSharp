﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Person object
            Person jl = new Person("Jose", 1950, 5.9);
            Person jane = new Person("Jane", 2000, 5.8);

            //jl.Greet();
            //jl.Greet("Jane");
            jl.Greet(jane);

            //Console.WriteLine(jl.isAlive);
            //jl.Die();
            //Console.WriteLine(jl.isAlive);

            //int jlAge = jl.GetAge();
            //Console.WriteLine(jlAge);


            Console.ReadKey();
        }
    }

    /// <summary>
    /// This is a class that will define the properties 
    /// and functionality of Person objects.
    /// </summary>
    class Person
    {
        // Fields
        public string name;
        public int YOB;
        public double height;
        public bool isAlive;

        // Constructor just with the name
        public Person(string name)
        {
            this.name = name;
            this.YOB = DateTime.Now.Year;
            this.height = 2.0;
            this.isAlive = true;
        }

        // Constructor with more properties
        public Person(string name, int yob, double height)
        {
            this.name = name;
            this.YOB = yob;
            this.height = height;

            int currentYear = DateTime.Now.Year;

            if (this.YOB > currentYear)
            {
                this.isAlive = false;
            }
            else
            {
                this.isAlive = true;
            }
        }

        // METHODS
        public void Greet()
        {
            Console.WriteLine("Hi! I am " + this.name + "!");
        }

        public void Greet(string otherName)
        {
            Console.WriteLine("Hi " + otherName + "! I am " + this.name + "!");
        }

        public void Greet(Person other)
        {
            Console.WriteLine("Hi " + other.name + "! I am " + this.name + "!");
        }

        public void Die()
        {
            this.isAlive = false;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - this.YOB;
        }

    }
}
