
using System;


namespace Farid111
{
    class Program
    {
        static void Main(string[] args)

        {


            Console.WriteLine("MagazineCapacity");
            int MagazineCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("MemberOfBulletsRemaining");
            int MemberOfBulletsRemaining = int.Parse(Console.ReadLine());
            Console.WriteLine("DischarheSecond");
            double DischarheSecond = double.Parse(Console.ReadLine());
            Console.WriteLine("FireMode");
            string FireMode = Console.ReadLine();


            Weapons M16A = new Weapons(MagazineCapacity, MemberOfBulletsRemaining, DischarheSecond, FireMode); ; ; ; ;
            Console.Clear();



            Console.WriteLine("0- GetInfo");


            while (true)
            {

                int choose = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (choose)
                {
                    case 0:
                        Console.WriteLine("1- Shoot a bullet"); //Shoot metodu üçün
                        Console.WriteLine("2 -The bullets in the magazine are fired "); //Fire metodu üçün
                        Console.WriteLine("3- The number of bullets to fill the magazine completely"); //GetRemainBulletCount metodu üçün
                        Console.WriteLine("4- refill the magazine"); //Reload metodu üçün
                        Console.WriteLine("5- Change shooting mode"); //ChangeFireMode metodu üçün
                        Console.WriteLine("6- Shortcut to stop the program"); //Proqramdan dayandırmaq üçün
                        Console.WriteLine("7- Edit"); //Redaktə et
                        Console.WriteLine("T- Say capacity"); //Tutumu dəyişsin
                        Console.WriteLine("S- Number of bullets"); //Güllə sayı
                        Console.WriteLine("D- Reset time"); //Sıfırlama saniyəsi 

                        break;
                    case 1:

                        Console.WriteLine("1- Shoot a bullet");
                        M16A.Shoot();
                        break;
                    case 2:

                        Console.WriteLine("2 -The bullets in the magazine are fired ");
                        M16A.Fire();
                        break;

                    case 3:

                        Console.WriteLine("3- The number of bullets to fill the magazine completely");
                        break;
                    case 4:
                        Console.WriteLine("4- refill the magazine");
                        M16A.Reload();
                        break;

                    case 5:

                        Console.WriteLine("5- Change Fire mode");
                        M16A.ChangeFireMode();
                        break;

                    case 6:
                        Console.WriteLine("6- Shortcut to stop the program");

                        break;
                    case 7:
                        Console.WriteLine("7- Edit");
                        break;

              
                            //    break;
                            //case T;
                            //    Console.WriteLine("Tutumu dəyişsin");
                            //    break;

                            //    break;
                            //case S;
                            //    Console.WriteLine("Güllə sayı");
                            //    break;

                            //    break;
                            //case D;
                            //    Console.WriteLine("Sıfırlama saniyəsi ");
                            //    break;


                        }





                }
            }
        }
    }
}
