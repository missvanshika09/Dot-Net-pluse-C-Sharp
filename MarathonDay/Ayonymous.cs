namespace Day9
{ //we use this when we dnt want Publiser Subscriber method 
    delegate void CountIt();
    internal class Program_Anyomous_method
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Anonymous Method");
            CountIt count = delegate // we call by reference name in delegate thus no need to create  // delegate_name REference_name = delegate KEYWORD
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            };
            count();
        }
    }
}

//    // if we want parameter

            
//         namespace Day9
// { //we use this when we dnt want Publiser Subscriber method 
//     delegate void CountItadd(int x, int y);
//     internal class Program_Anyomous_method
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Welcome to Anonymous Method");
//             CountIt count = delegate (int x, int y // we call by reference name in delegate thus no need to create  // delegate_name REference_name = delegate KEYWORD
            
              
//                 return x+y;
//                     Console.WriteLine(x+y);
                
//             };

//           int result= count(3,8);
// Console.WriteLine("sum"+ result);
// CountIt p= delegate (intx, int y) // method defination as it is anonymous 
// { retun x*y;} ;
// Console.WriteLine(p(8,9));
//         }
//     }
// }
// // for multicast deligation 

// namespace Day9
// { //we use this when we dnt want Publiser Subscriber method 
//     delegate void CountItadd(int x, int y);
//     internal class Program_Anyomous_method
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Welcome to Anonymous Method");
//             CountIt count = delegate (int x, int y // we call by reference name in delegate thus no need to create  // delegate_name REference_name = delegate KEYWORD
            
              
//                 return x+y;
//                     Console.WriteLine(x+y);
                
//             };

//            /*result= count(3,8);
// Console.WriteLine("sum"+ result);*/
// CountIt += delegate (intx, int y) // method defination as it is anonymous 
// { retun x*y ;} ;
// Console.WriteLine(count (8,9));
// foreach(var x in count.GetInvocationList())
// Concole.WriteLine(x.Method +" " + x.DynamicInvocation( 5.6))
//         }
//     }
// }
/*
lamda
CountIt = (x,y)=> x*y;
lamda operator=>
lamda expresion---- CountIt = (x,y)=> x*y;
lamda statement ---CountIt = (x,y)=> {x*y},{x+y};*/
 

