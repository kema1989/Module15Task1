using System;
using System.Linq;
using System.Collections.Generic;

namespace Module15Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));

            //ShowAllStudents(classes);--->--->--->--->--->---v
                                                            //к
        }                                                   //а
                                                            //к
        static string[] GetAllStudents(Classroom[] classes) //с
        {                                                   //д
            return (from cl in classes                      //е
                   from st in cl.Students.ToArray()         //л
                   select st).ToArray();                    //а
        }                                                   //т
                                                            //ь
                                                            //
                                                            //т
                                                            //о
                                                            //
                                                            //ж
                                                            //е
                                                            //
                                                            //с
                                                            //а
                                                            //м
                                                            //о е  с  п о м о щ ь ю  м е т о д о в  р а с ш и р е н и я ?😶😥😟
        //static void ShowAllStudents(Classroom[] classes)  
        //{
        //    var result = classes.Select(cl => cl.Students.ToArray().Select(st => st)).ToArray();
        //    foreach(var st in result)
        //        Console.WriteLine(st);
        //}
    }
}
