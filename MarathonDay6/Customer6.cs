        /* Create abstract class account having member id. name, balance
        Id is generated by application write  read only property for ID.
        It has abstract method public abstract void withdraw(double amt);
        It has deposit method which will increase the balance.
        Write getter setter for name
        Balance can be set only by child class.
It has static double int_rate = 0.07
Create two child class Saving, Current
Initialise data by calling parent class constructor
In saving account maintain minimum balance 1000 for this declare
Const double minbal = 1000
In current account negative balance allowed.
Let both child class override withdraw method.
        Create array of account class and store 2 object of saving account and current account.
Do the transaction.When you load it should print name of bank.
Also display all account detail name wise ascending order.
*/
public abstract class Account{
public int id;
public int i;
public string name{get; set;}
public double balance;
static double int_rate = 0.07;
public Const double minbal = 1000;

static Account(){
Console.WriteLine("Bank Name :ICICI ");
}
 public Account(string name, double balance)
{ id=i++;
this.name=name;
this.balance=balance;
}
public abstract void withdraw(double amt);
public  void depisot(double amt)
{ balance+=amt;
}
public override string Tostring()
{ 
return string.format("id={0}, name={1},balance ={2}" id, name, balance);
}
}
 //saving
class saving : Account{
public saving (string name, double balance): base(name, balance){}
public override withdraw(double amt){
if (balance >=minbal)
{
balance-=amt;
Console.WriteLine($"money has been withdrawal {balance}");
}
else
{
Console.WriteLine("lower than minbal {minbal}");
}
}
}
}
//current
class current:Account
{
public current(string name. double balance): base(name, balance){}
public override withdraw(double amt){
if (balance>=minbal){
Console.WriteLine("money has been withdrawal {balance}");
}
else{
balance-=amt;
Console.WriteLine("money has been left {balance}");
}

//Main Program
internal class Program
{
public static void Main(String[] args)
{
Account[] arr= new Account[2];
{
arr[0]=new saving("Raj",50000);
arr[1]=new current("vansh", 5000);
}
foreach(Account m in arr)
{
Console.WriteLline(m);
}
arr[0].withdraw(1000);
arr(1).depoist(500);
Array.Sort(arr,(x,y)=> x.name.CompareTo(y.name));
}
}
}

