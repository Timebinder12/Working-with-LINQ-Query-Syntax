﻿using System;
using System.Linq;

public class Program { 

    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }
    
    public static void Main(string[] args) {

        IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
        };

       // var birthdayQuery = stemPeople.Where(x => x.BirthYear > 1900)
       //                         .OrderByDescending(x => x.BirthYear); WRONG SYNTAX!

        var birthdayQuery2 = from s in stemPeople
                             where s.BirthYear > 1900
                             select s;

        Console.WriteLine("Famous people who have a birthdate after 1900:");
        foreach (var person in birthdayQuery2)
            Console.WriteLine($"{person.Name}\nBorn: {person.BirthYear} Died: {person.DeathYear}");
        Console.WriteLine();



       // var lQuery = stemPeople.Where(x => x.Name.Contains("ll")); WRONG SYNTAX!

        var lQuery2 = from s in stemPeople
                      where s.Name.Contains("ll")
                      select s;

        Console.WriteLine("People who have two lowercase l's in their name:");
        foreach(var person in lQuery2)
            Console.WriteLine($"{person.Name}");
        Console.WriteLine();

        //var birthdayCount = stemPeople.Count(x => x.BirthYear > 1950); WRONG SYNTAX!

        var birthdayCount2 = (from s in stemPeople
                             where s.BirthYear > 1950
                             select s).Count();

        Console.WriteLine("The amount of people who have a birthday after 1950:");
        Console.WriteLine(birthdayCount2);
        Console.WriteLine();

        //var birthCountList = stemPeople.Where(x => x.BirthYear >= 1920).Where(x => x.BirthYear <= 2000); WRONG SYNTAX!

        var birthCountList2 = from s in stemPeople
                              where s.BirthYear >= 1920
                              where s.BirthYear <= 2000
                              orderby s.BirthYear
                              select s;

        Console.WriteLine("People with birth years between 1920 and 2000 ordered by birthyear:");
        foreach (var person in birthCountList2)
            Console.WriteLine(person.Name);
        Console.WriteLine($"There are {birthCountList2.Count()} people in this list.");
        Console.WriteLine();


    }
}