namespace A2_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            if ( n>= 1 && n<= 1188 )
            {
                int il = n / 12;
                int ay = n % 12;
                Console.WriteLine($"{n} ay={il} il ve ay {ay}");


            }
            else
            {
                Console.WriteLine("1 - 1188 intervalinda eded daxil edilmelidir ");

            }






            Console.WriteLine("Hello ");
        }
    }
}