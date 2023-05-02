﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Statics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Person object
            Person jl = new Person("Jose", 1789, 5.9);
            Person jane = new Person("Jane", 2000, 5.8);

            Console.WriteLine(jl);
            Console.WriteLine(jane);
            Console.WriteLine(Person.MaxAge);

            int d = Person.ComputeAgeDiff(jane, jl);
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }

    /// <summary>
    /// This is a class that will define the properties 
    /// and functionality of Person objects.
    /// </summary>
    class Person
    {
        // Static properties
        public static int MaxAge = 100;

        // Static methods
        public static int ComputeAgeDiff(Person one, Person two)
        {
            int diff = one.Age - two.Age;
            return Math.Abs(diff);
        }


        // Fields
        private string _name;
        private int _yob;
        private double _height;
        private bool _isAlive;

        // Properties
        public int Age
        {
            get => DateTime.Now.Year - this._yob;
        }

        public string Name
        {
            get => _name;
            set => this._name = value;
        }

        public bool IsAlive
        {
            get => _isAlive;
        }

        // Constructor just with the name
        public Person(string name)
        {
            this._name = name;
            this._yob = DateTime.Now.Year;
            this._height = 2.0;
            this._isAlive = true;
        }

        // Constructor with more properties
        public Person(string name, int yob, double height)
        {
            this._name = name;
            this._yob = yob;
            this._height = height;

            int currentYear = DateTime.Now.Year;

            if (this._yob < currentYear && currentYear - this._yob < Person.MaxAge)
            {
                this._isAlive = true;
            }
            else
            {
                this._isAlive = false;
            }
        }

        // METHODS
        public void Greet()
        {
            Console.WriteLine("Hi! I am " + this._name + "!");
        }

        public void Greet(string otherName)
        {
            Console.WriteLine("Hi " + otherName + "! I am " + this._name + "!");
        }

        public void Greet(Person other)
        {
            Console.WriteLine("Hi " + other._name + "! I am " + this._name + "!");
        }

        public void Die()
        {
            this._isAlive = false;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - this._yob;
        }

        public override string ToString()
        {
            string obj = $"{this._name}, {this.GetAge()}, {this._height}, {this._isAlive}";
            return obj;
        }
    }
}
