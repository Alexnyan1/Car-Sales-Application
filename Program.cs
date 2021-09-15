using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PayStack.Net;
using RestSharp;


namespace UnderstandingClasses 
{

    public class Program 
    {
        static void Main(string[] args)
        {
            
            startLoop6: Console.WriteLine("Welcome to the Car Value App!");
            Console.WriteLine("We help to calculate the current value of your car");
            Console.WriteLine("");
            Console.WriteLine("Press 1 to check current car value");
            Console.WriteLine("Press 2 to view saved details in the car database");
            Console.WriteLine("Press 3 to exit");
            Console.Write("1/2/3: ");
            
            string firstInput = Console.ReadLine();

            
            startLoop: CarService newCar = new CarService();
            if (firstInput == "1")
            {
                Console.Clear();
                newCar.RandomId();
                newCar.CarMakeInput();
                newCar.CarModelInput();
                newCar.CarPlateNumberInput();
                newCar.CarYearInput();
                newCar.CarColorInput();
                newCar.CarYearOfPurchaseInput();
                newCar.PriceOfCarInput();
                newCar.CarMilageInput();    
                Console.Clear();
                newCar.CurrentCarValue();
                Console.WriteLine("The Price of Car(USD): {0:C}", newCar.Price);
                Console.WriteLine("The Current Price of Your Car is: {0:C} ", newCar.CurrentCarValue());


                startLoop5: Console.Write("Save to Database? y/n: ");
                string userValue = Console.ReadLine();
                if (userValue == "y")
                {
                    newCar.SavingToDatabase();
                    startLoop3: Console.Write("Start over? y/n: ");
                    string userValue2 = Console.ReadLine();
                    if (userValue2 == "y")
                    {
                        Console.Clear();
                        goto startLoop;
                    }
                    else if (userValue2 == "n")
                    {
                    startLoop2: Console.WriteLine("Press 1 to view saved inputs");
                    Console.WriteLine("Press 2 to exit");
                    Console.Write("1/2: ");
                    string userValue3 = Console.ReadLine();
                    if (userValue3 == "1")
                    {
                        newCar.SavedInputs();
                        Console.Clear();
                        goto startLoop2;

                    }
                    else if (userValue3 == "2")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        Console.Write("Press enter to return....");
                        Console.ReadLine();
                        Console.Clear();
                        goto startLoop2;
                    }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        Console.Write("Press enter to return....");
                        Console.ReadLine();
                        Console.Clear();
                        goto startLoop3;
                    }
                }

                else if (userValue == "n")
                {
                    startLoop4: Console.WriteLine("Press 1 to view saved inputs");
                    Console.WriteLine("Press 2 to Start Over");
                    Console.WriteLine("Press 3 to exit");
                    Console.Write("1/2/3: ");
                    string userValue4 = Console.ReadLine();

                    if (userValue4 == "1")
                    {
                        newCar.SavedInputs();
                        Console.Clear();
                        goto startLoop4;

                    }
                    else if (userValue4 == "3")
                    {
                        return;
                    }
                    else if (userValue4 == "2")
                    {
                        Console.Clear();
                        goto startLoop;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        Console.Write("Press enter to return....");
                        Console.ReadLine();
                        Console.Clear();
                        goto startLoop4;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input");
                    Console.Write("Press enter to return....");
                    Console.ReadLine();
                    Console.Clear();
                    goto startLoop5;
                }

            }
                
            else if (firstInput == "2")
            {

                Console.Clear();
                startLoop9: Console.WriteLine("Press 1 to search by Model");
                Console.WriteLine("Press 2 to search by Plate Number");
                Console.WriteLine("Press 3 to view all");
                Console.WriteLine("Press 4 to return to the main menu");
                Console.WriteLine("Press 5 to exit");
                Console.Write("1/2/3/4/5: ");
                string searchValue = Console.ReadLine();
                if (searchValue == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Searching by Car Model");
                    Console.Write("Input car model: ");
                    newCar.SearchByModel();
                    startLoop32: Console.WriteLine("Press 1 to continue and 2 to exit console");
                    Console.Write("1/2: ");
                    string input2 = Console.ReadLine();
                    if (input2 == "1")
                    {
                        newCar.BuySelectedCar();
                        Console.Write("Press enter to return....");
                        Console.ReadLine();
                        Console.Clear();
                        goto startLoop9;
                    }
                    else if (input2 == "2")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Error press any key to return to console");
                        Console.ReadKey();
                        goto startLoop32;
                    }
                    


                }
                else if (searchValue == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Searching by Car Plate Number");
                    Console.Write("Input car Plate Number: ");
                    newCar.SearchByPlateNumber();
                    startLoop31: Console.WriteLine("Press 1 to continue and 2 to exit console");
                    Console.Write("1/2: ");
                    string input1 = Console.ReadLine();
                    if (input1 == "1")
                    {
                        newCar.BuySelectedCar();
                        
                        Console.Write("Press enter to return....");
                        Console.ReadLine();
                        Console.Clear();
                        goto startLoop9;
                    }
                    else if (input1 == "2")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Error press any key to return to console");
                        Console.ReadKey();
                        goto startLoop31;
                    }
                }
                else if (searchValue == "3")
                {
                    
                    newCar.ViewAllDataBase();
                    startLoop33: Console.WriteLine("Press 1 to continue and 2 to exit console");
                    Console.Write("1/2: ");
                    string input3 = Console.ReadLine();
                    if (input3 == "1")
                    {
                        newCar.BuySelectedCar();
                       
                        Console.Write("Press enter to return....");
                        Console.ReadLine();
                        Console.Clear();
                        goto startLoop9;
                    }
                    else if (input3 == "2")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Error press any key to return to console");
                        Console.ReadKey();
                        goto startLoop33;
                    }
                    
                }
                else if (searchValue == "4")
                {
                    Console.Clear();
                    goto startLoop6;
                }
                else if (searchValue == "5")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write("Press enter to return....");
                    Console.ReadLine();
                    Console.Clear();
                    goto startLoop9;
                }
                

            }

            else if (firstInput == "3")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalids Input");
                Console.Write("Press enter to return......");
                Console.ReadLine();
                Console.Clear();
                goto startLoop6;

            }

        }

        

    }


}
