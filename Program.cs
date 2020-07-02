using System;
using System.IO;

namespace ShopInConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            int chooseOption = 1;

            do
            {

                var chooseOption1 = chooseOption;

                Console.WriteLine("#1. Enter Shop");
                Console.WriteLine("#2. Enter AdminPanel");
                Console.WriteLine("#0. Exit");
                Console.WriteLine("ChooseOption: ");
                chooseOption1 = Convert.ToInt32(Console.ReadLine());

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
                        chooseOption1 = Convert.ToInt32(Console.ReadLine());
                        while (chooseOption1 != 0)
                        {
                            if (chooseOption1 == 1)
                            {
                                Console.WriteLine("You have arived at View Product");

                            }
                            else if (chooseOption1 == 2)
                            {
                                Console.WriteLine("You have arived at Add Product");

                            }
                            else if (chooseOption1 == 3)
                            {
                                Console.WriteLine("You have arrived to Edit Product");

                            }
                            else
                            {
                                Console.WriteLine("You have entered an invalid option.");

                            }
                        }


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
                        chooseOption1 = Convert.ToInt32(Console.ReadLine());

                        while (chooseOption1 != 0)
                        {
                            if (chooseOption1 == 1)
                            {
                                Console.WriteLine("You have arived at View Product");

                            }
                            else if (chooseOption1 == 2)
                            {
                                Console.WriteLine("You have arived at Add Product");

                            }
                            else if (chooseOption1 == 3)
                            {
                                Console.WriteLine("You have arrived to Edit Product");

                            }
                            else if (chooseOption1 == 4)
                            {
                                Console.WriteLine("You have arrived to Delete Product");
                            }

                            else
                            {
                                Console.WriteLine("You have entered an invalid option.");

                            }
                        }


                    }
                    else if (chooseOption1 == 0) 
                    {
                        chooseOption = 0;
                    }


                    else
                    {
                        Console.WriteLine("You have entered an invalid option.");
                    }




                } while (chooseOption1 != 0);

            if (chooseOption == 0)
                {
                    break;
                }

            } while (chooseOption != 0);


        }
    }
}
