/*Q1 create a class library having public method which will return square of a number use this dll file in your console application.(private Assembly)
Q2. put your class libraray in GAC and use it in console application(Shared Assembly)
*/

namespace Structure
{
     struct fullstruct 
    {
       public  int x;
        public int y;
        fullstruct(int x)
        {
            x = x;
        }
        fullstruct(int x, int y)

        {
            x = x;
            y = y;

        }
        public void display(int x)
        {
            Console.WriteLine("x={0}", x);
        } 
        public void display(int x, int y)
        {
            Console.WriteLine("x={0}, y={1}", x, y);
        }
        
        static void Main(string[] args)
        {
          fullstruct s = new  fullstruct();
            s.display(6);
            Console.WriteLine(s);

        }
    }
}
