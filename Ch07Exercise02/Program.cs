namespace ch07Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 1; i <= 5000; i++)
                {
                    if (i == 5000)
                        throw new Exception("5000th cycle exception reached");
                }
            }
            catch
            {
                Console.WriteLine("Exception caught: 5000th cycle exception reached");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}