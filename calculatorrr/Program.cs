
namespace ConsoleApp3;

public class program()
{
    public static void Main()
    {
        {
            var obj = new calculator();
            int a;
            do
            {
                double total, temp;


                Console.WriteLine("Enter the first value:");
                obj.a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second value:");
                obj.b = int.Parse(Console.ReadLine());

                Console.WriteLine(" \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Division ");
                temp = int.Parse(Console.ReadLine());

                switch (temp)
                {
                    case 1:
                        {
                            total = obj.add();
                            break;
                        }
                    case 2:
                        {
                            total = obj.sub();
                            break;
                        }
                    case 3:
                        {
                            total = obj.mul();
                            break;
                        }
                    case 4:
                        {
                            total = obj.div();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid operation.");
                            return;
                        }
                }
                Console.WriteLine($"The result is :{total}");
                Console.WriteLine("Continue Y/n: \n 1. yes \n 2. no");
                a = int.Parse(Console.ReadLine());
            }

            while (a == 1);
        }
    }
}