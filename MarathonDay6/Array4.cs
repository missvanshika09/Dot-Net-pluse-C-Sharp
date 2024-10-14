namespace ques4
{
    internal class Program
    { 
       //Accept  10 element in an array and display it in descending order.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10  Array");
            int[] arr = new int[9];
            for (int i = 0; i < arr.Length; i++)
            {
                arr [i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
           Array.Reverse(arr);
            Console.WriteLine("\n");

            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }

        }
    }
}
