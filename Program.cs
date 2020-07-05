using System;
using System.ComponentModel;
using System.IO;

namespace ShopInConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            int chooseOption =  5;
            do
            {
                
                Console.WriteLine("#1. Enter Shop");
                Console.WriteLine("#2. Enter AdminPanel");
                Console.WriteLine("#0. Exit");
                Console.WriteLine("ChooseOption: ");
                var chooseOption1 = Convert.ToInt32(Console.ReadLine());
               
                do
                {

                    if (chooseOption1 == 1)
                    {

                        Console.WriteLine("Welcome to the shop area.");
                        Console.WriteLine("");
                        Console.WriteLine("1. View Products");
                        Console.WriteLine("2. View Cart");
                        Console.WriteLine("3. Add To Cart");
                        Console.WriteLine("0. To Go Back");
                        Console.WriteLine("ChooseOption: ");
                        var chooseOption2 = Convert.ToInt32(Console.ReadLine());

                        do { 
                        if (chooseOption2 == 1)
                        {
                            Console.WriteLine("You have arived at View Product");
                            Console.WriteLine("");
                            Console.WriteLine("Choose 0 to go back");
                            var back = Convert.ToInt32(Console.ReadLine());
                            if (back == 0)
                            {
                                Console.WriteLine("");
                                    chooseOption2 = back;
                                }

                        }
                        else if (chooseOption2 == 2)
                        {
                            Console.WriteLine("You have arived at Add Product");
                            Console.WriteLine("");
                            Console.WriteLine("Choose 0 to go back");
                            var back = Convert.ToInt32(Console.ReadLine());
                            if (back == 0)
                            {
                                Console.WriteLine("");
                                    chooseOption2 = back;
                                }

                        }
                        else if (chooseOption2 == 3)
                        {
                            Console.WriteLine("You have arrived to Edit Product");
                            Console.WriteLine("");
                            Console.WriteLine("Choose 0 to go back");
                            var back = Convert.ToInt32(Console.ReadLine());
                            if (back == 0)
                            {
                                Console.WriteLine("");
                                    chooseOption2 = back;
                                }

                        }
                        else
                        {

                            Console.WriteLine("");
                            chooseOption2 = 0;
                            chooseOption1 = chooseOption2;

                        }

                        } while (chooseOption2 != 0);
                    }
                       


                    else if (chooseOption1 == 2)
                    {

                        Console.WriteLine("Welcome to the admins area.");
                        Console.WriteLine("");
                        Console.WriteLine("1. View Product");
                        Console.WriteLine("2. Add Product");
                        Console.WriteLine("3. Edit Product");
                        Console.WriteLine("4. Delete Product");
                        Console.WriteLine("0. To Go Back");
                        Console.WriteLine("ChooseOption: ");
                        var chooseOption2 = Convert.ToInt32(Console.ReadLine());

                        do { 
                        if (chooseOption2 == 1)
                        {
                            Console.WriteLine("You have arived at View Product");
                            Console.WriteLine("");
                            Console.WriteLine("Choose 0 to go back");
                            var back = Convert.ToInt32(Console.ReadLine());
                            if (back == 0)
                            {
                                Console.WriteLine("");
                                    chooseOption2 = back;
                                }

                        }

                        else if (chooseOption2 == 2)
                        {
                            Console.WriteLine("You have arived at Add Product");
                            Console.WriteLine("");
                            Console.WriteLine("Choose 0 to go back");
                            var back = Convert.ToInt32(Console.ReadLine());
                            if (back == 0)
                            {
                                Console.WriteLine("");
                                    chooseOption2 = back;
                                }
                        }

                        else if (chooseOption2 == 3)
                        {
                            Console.WriteLine("You have arrived to Edit Product");
                            Console.WriteLine("");
                            Console.WriteLine("Choose 0 to go back");
                            var back = Convert.ToInt32(Console.ReadLine());
                            if (back == 0)
                            {
                                Console.WriteLine("");
                                    chooseOption2 = back;
                                }
                        }

                        else if (chooseOption2 == 4)
                        {
                            Console.WriteLine("You have arrived to Delete Product");
                            Console.WriteLine("");
                            Console.WriteLine("Choose 0 to go back");
                            var back = Convert.ToInt32(Console.ReadLine());
                            if (back == 0)
                            {
                                Console.WriteLine("");
                                chooseOption2 = back;
                            }
                        }

                            else
                            {
                                Console.WriteLine("");
                                chooseOption2 = 0;
                                chooseOption1 = chooseOption2;
                            }

                        } while (chooseOption2 != 0);
                    }

                    else
                    {
                        chooseOption1 = 0;
                        chooseOption = chooseOption1;
                    }

                } while (chooseOption1 != 0);
                
            } while (chooseOption != 0);


        }
    }
}
