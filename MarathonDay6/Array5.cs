namespace ques4
{
    internal class Program
    {
        //Accept 10 name in array , accept a name to be searched. If name is there in an array print message name is in list.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10  Array");
            string[] sarr = new string[9];
            for (int i = 0; i < sarr.Length; i++)
            {
                sarr [i] = (Console.ReadLine());
            }
            Console.WriteLine("Enter the name for search");
            string n= Console.ReadLine();
            for(int i = 0;i < sarr.Length; i++)
            {
                if (sarr[i] == n)
                {
                    Console.WriteLine("name is in the list \t"+ sarr[i]);
                }
              
            }
            Console.WriteLine("\n");
            Console.WriteLine("name is not in the list");


        }
    }
}
