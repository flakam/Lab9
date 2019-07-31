using System;
using System.Collections.Generic;
using System.Linq;


namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Dakota Slabbekoorn", "Joshua Bultsma", "Tommy Waalkes", "James Dockery", "Maricela Rivera", "KimVy Nguyen", "Sam Thomson", "Cody Shanley", "Flaka Mahmuti", "Mahruchi Rhee", "Manik Nath", "Moise Ingabire", "Liz Hitches", "Jason Speet" };
            string[] homeTowns = { "Kent City", "Grand Rapids", "Raleigh NC", "Grand Rapids, MI", "Morelia, Mex.", "Grand Rapids", "Grand Rapids", "Lawton, MI", " Pristina", "Teaneck, New Jersey", "CoxsBazar, Bangladesh", " Grand Rapids", "Planet Earth", "Holland" };

            string[] foods = { "Pho", "Cheese Tortellini", "Indian Style Chicken Curry", "Cheeseburgers/FrenchFries", "Tacos", "Sushi", "Tacos", "Potato soup", "Thai", "Chicken Wings", "Spicy Beef Curry", "Lasagna", "Smoked Salmon", "Burgers" };
            string[] colors = { "red", "blue", "orange", "yellow", "pink", "black", "white", "purple", "green", "white", "red", "green", "yellow", "pink" };
           string empty = System.String.Empty;
           // string newstudentht = "";
            //string newstudentff = "";
            //string newstudentfc = "";
            //string[] newstudent = { newstudentName, newstudentht, newstudentff, newstudentfc };
            bool con = true;
            List<Student> students = new List<Student>();
            Student s1 = new Student("Dakota Slabbekoorn", "Kent City", "Pho", "red");
            Student s2 = new Student("Joshua Bultsma", "Grand Rapids", "Cheese Tortellini", "blue");
            Student s3 = new Student("Tommy Waalkes", "Raleigh NC", "Indian Style Chicken Curry", "orange");
            Student s4 = new Student("James Dockery", "Grand Rapids", "Cheeseburgers / FrenchFries", "yellow");
            Student s5 = new Student("Maricela Rivera", "Morelia, Mex.", "Tacos", "pink");
            Student s6 = new Student("KimVy Nguyen", "Grand Rapids", "Sushi", "black");
            Student s7 = new Student("Sam Thomson", "Grand Rapids", "Tacos", "white");
            Student s8 = new Student("Cody Shanley", "Lawton,MI", "Potato soup", "purple");
            Student s9 = new Student("Flaka Mahmuti", "Pristina", "Thai", "green");
            Student s10 = new Student("Mahruchi Rhee", "Teaneck, New Jersey", "Chicken Wings", "white");
            Student s11 = new Student("Manik Nath", "CoxsBazar, Bangladesh", "Spicy Beef Curry", "red");
            Student s12 = new Student("Moise Ingabire", "Grand Rapids", "Lasagna", "green");
            Student s13 = new Student("Liz Hitches", "Earth", "Smoked Salmon", "yellow");
            Student s14 = new Student("Jason Speet", "holland", "Hamburgers", "pink");

          //  students.Sort();
            
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);
            students.Add(s9);
            students.Add(s10);
            students.Add(s11);
            students.Add(s12);
            students.Add(s13);
            students.Add(s14);

            students=students.OrderBy(x =>x.Name).ToList();//Alphabetized
            while (con)
            {


                Console.WriteLine("Which student would you like to learn about: 0-" + students.Count);

                for (int i = 0; i < students.Count; i++)
                {
                    Student stu = students[i];
                    Console.WriteLine(i + " " + stu.GetName());
                }
                int pick = 0;
                try
                {
                    string input = Console.ReadLine();
                    pick = int.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("A valid int was not given");
                }
                Student s;
                try
                {
                    s = students[pick];
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Incorrect input I'm assuming you want the person at index 0");
                    s = students[0];
                }

                string name = s.GetName();
                Console.WriteLine(name);
                Console.WriteLine($"What would you like to learn about {name}?");
                Console.WriteLine("1) Favorie Food ff");
                Console.WriteLine("2) Home Town ht");
                Console.WriteLine("3) Favorite Color  fc");
                string input2 = Console.ReadLine().ToLower().Trim();

                if (input2 == "1" || input2 == "ff")
                {
                    Console.WriteLine(s.FavoriteFood);
                }
                else if (input2 == "2" || input2 == "ht")
                {
                    Console.WriteLine(s.HomeTown);
                }
                else if ((input2 == "3" || input2 == "fc"))
                {
                    Console.WriteLine(s.FavoriteColor);
                }
                else
                {
                    Console.WriteLine("A valid int was not given");
                }
                while (con)
                {
                    Console.WriteLine($"Would you like to know more about {name}?");
                    string input3 = Console.ReadLine().ToLower().Trim();
                    if (input3 == "y")
                    {
                        Console.WriteLine($"What would you like to learn about {name}?");
                        Console.WriteLine("1) Favorie Food ff");
                        Console.WriteLine("2) Home Town ht");
                        Console.WriteLine("3) Favorite Color  fc");
                        string input4 = Console.ReadLine().ToLower().Trim();

                        if (input4 == "1" || input4 == "ff")
                        {
                            Console.WriteLine(s.FavoriteFood);
                        }
                        else if (input4 == "2" || input4 == "ht")
                        {
                            Console.WriteLine(s.HomeTown);
                        }
                        else if (input4 == "3" || input4 == "fc")
                        {
                            Console.WriteLine(s.FavoriteColor);
                        }
                        
                    }
                    else if (input3 == "n")
                    {
                        Console.WriteLine("Thank you");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry");
                    }
                }
                Console.WriteLine("Would you like to know more about any other student? Enter Y or N");
                string input5 = Console.ReadLine().ToLower();
                if (input5 == "y")
                {
                    con = true;
                }
                else
                {
                    con = false;
                    Console.WriteLine("Thank you");
                    Console.WriteLine("Would you like to add another student? Enter Y or N");
                    string input6 = Console.ReadLine().ToLower();

                    if (input6 == "y")
                    {       con = true;
                        
                        
                            Console.WriteLine("Enter a name");
                            string input = Console.ReadLine();
                        if (input == empty)
                        {
                           Console.WriteLine("No blanks allowed.Enter a name");
                            input = Console.ReadLine();
                        }
                            Student sc = new Student();
                            sc.SetName(input);
                            Console.WriteLine("Enter hometown");
                            sc.SetHomeTown(Console.ReadLine());
                        if (input == empty)
                        {
                            Console.WriteLine("No blanks allowed.Enter a hometown");
                            sc.SetHomeTown(Console.ReadLine());
                        }

                        Console.WriteLine("Enter a favorite food");
                            sc.SetFavoriteFood(Console.ReadLine());
                        if (input == empty)
                        {
                            Console.WriteLine("No blanks allowed.Enter a favorite food");
                            sc.SetFavoriteFood(Console.ReadLine());
                        }

                        Console.WriteLine("Enter favorite color");
                            sc.SetFavoriteColor(Console.ReadLine());
                        if (input == empty)
                        {
                            Console.WriteLine("No blanks allowed.Enter a favorite color");
                            sc.SetFavoriteColor(Console.ReadLine());
                        }
                        students.Add(sc);
                                             
                            Console.WriteLine();
                    }
                                                            
                    else
                    {
                        con = false;
                    }
                }
            }


        }
    }
}
