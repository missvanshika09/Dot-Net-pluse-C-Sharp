// Demonstrate invoking a constructor through this. 
  
using System;  
  
class XYCoord {   
  public int x, y;   
   
  public XYCoord() : this(0, 0) { //default constructor
    Console.WriteLine("Inside XYCoord()"); t12
  }  
 
  public XYCoord(XYCoord obj) : this(obj.x, obj.y) { // copy constructor-This constructor allows you to create a new object by copying values from another XYCoord object. It invokes the parameterized constructor with this(obj.x, obj.y).
    Console.WriteLine("Inside XYCoord(obj)"); 
  }  
 
  public XYCoord(int i, int j) {  //This constructor directly initializes the x and y fields with the provided values and outputs "Inside XYCoord(int, int)".
    Console.WriteLine("Inside XYCoord(int, int)"); t11
    x = i; 
    y = j; 
  }     
}     
     
class OverloadConsDemo {     
  public static void Main() {     
    XYCoord t1 = new XYCoord();   
    XYCoord t2 = new XYCoord(8, 9);   //Calls the parameterized constructor directly.
    XYCoord t3 = new XYCoord(t2);   //  The copy constructor calls the parameterized constructor with the values from t2.
   
    Console.WriteLine("t1.x, t1.y: " + t1.x + ", " + t1.y);  
    Console.WriteLine("t2.x, t2.y: " + t2.x + ", " + t2.y);  
    Console.WriteLine("t3.x, t3.y: " + t3.x + ", " + t3.y);  
  }     
}
/* output--------------
t1.x, t1.y: 0, 0
t2.x, t2.y: 8, 9
t3.x, t3.y: 8, 9
*/
