namespace Banking;
using GovermentPolicy;

public class Account

{   

 public event TaxOperation? overBalance;
 
  public event Notification? underBalance;
    public double Balance{get;set;}

    public Account(double balance){
        this.Balance=balance;
    }

    public void Withdraw(double bal){
        if(this.Balance>bal){
        this.Balance-=bal;
        }
        else{
            Console.WriteLine("Insufficient Balance");
        }
    }
    public void Deposite(double bal){
        this.Balance+=bal;
    }

     public void ProcessTax(){
        if(this.Balance>=250000){
            overBalance(this.Balance);
        }
        else{
             underBalance(this.Balance);
            // overBalance(this.Balance);
        }
        }
    public override string ToString(){
        return "Current Balance"+this.Balance;
    }
 
}
