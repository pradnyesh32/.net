namespace Banking;

public delegate void Notification(double amount);

public class BankManager{
public void SentAlert(double amount){
    Console.WriteLine("Your Account Has Low Balance");
    }

    


}