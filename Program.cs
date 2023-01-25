using System;


namespace travel
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int number=0;
            generate program = new generate();
            program.GenerateHotel();
            program.generateOferts();
            bool flag= true;
            while (flag)
            {
               
                for (int i = 0; i < program.oferts.Count; i++)
                {
                    Console.WriteLine("Numer: " + ++i);
                    i--;
                    program.oferts[i].showOfert();

                }

                Console.WriteLine("Proszę wybrać numer oferty ");
                var strin = Console.ReadLine();
                if (int.TryParse(strin, out number))
                {
                    Console.Clear();
                    switch (number)
                    {
                        case 1:
                            {
                                program.endprice(program.oferts[0].priceofert);
                                flag = false;
                                break;
                            }
                        case 2:
                            {
                                program.endprice(program.oferts[1].priceofert);
                                flag = false;
                                break;
                            }
                        case 3:
                            {
                                program.endprice(program.oferts[2].priceofert);
                                flag = false;
                                break;
                            }
                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("nie ma takiej oferty :");
                                Console.ResetColor();
                            }
                            break;

                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("proszę wpisać liczbę");
                    Console.ResetColor();
                }

            }
            Console.WriteLine("dziękuje to wszystko");
            Console.ReadKey();
            
           

        }
    }
}
