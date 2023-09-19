// Things a customer needs
// First name
// Last Name
// Card #
// Pin #
// Balance $$
// https://www.youtube.com/watch?v=qBI7Qnz9Zho
// video code along, stopped @ 6:31

using System; // call our directives
public class cardHolder // initialize a cardHolder class to contain customer info
{
  String cardNum;
  int pin;
  string firstName;
  string lastName;
  double balance;

  public cardHolder(string cardNum, int pin, string firstName, string lastName, string balance)
  { // place info above into constructor to be called for multiple cards
    this.cardNum = cardNum;
    this.pin = pin;
    this.firstName = firstName;
    this.lastName = lastName;
    this.balance = balance;
  }

  // getters
  public String getNum()
  {
    return cardNum;
  }
   public String getFirstName()
  {
    return firstName;
  }
   public String getLastName()
  {
    return lastName;
  }
   public double getBalance()
  {
    return balance;
  }
   public int getPin()
  {
    return pin;
  }

  // setters

  public void setFirstName(String newFirstName)
  {
    firstName = newFirstName;
  }

  public void setLastName(String newLastName)
  {
    lastName = newLastName;
  }

   public void setBalance(String newBalance)
  {
    balance = newBalance;
  }

  public void setPin(int newPin)
  {
    int = newInt;
  }

  public static void Main(String[] args)
  {
    void printOptions()
    {
      Console.WriteLine("Please choose from the following options...")
      Console.WriteLine("1. Deposit")
      Console.WriteLine("2. Withdraw")
      Console.WriteLine("3. Show Balance")
      Console.WriteLine("4. Exit")
    }
    void deposit(cardHolder currentUser)
    {
      Console.WriteLine("How much would you like to deposit today? ");
      double deposit = Double.Parse(Console.ReadLine());
      currentUser.setBalance(deposit);
      Console.WriteLine("Thank you for your deposit! Your new balance is: " + currentUser.getBalance());
       // need to use parse here 
        // going from a double to a string that is being read on the command line
        // video mentioned possibly wrapping a try/catch here?
    }
  }
}