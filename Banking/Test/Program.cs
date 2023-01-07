using Banking;
using GovermentPolicy;
Account acct1=new Account(25000);


IncomeTax intax=new IncomeTax();
BankManager bm=new BankManager();

TaxOperation? tax=null;
tax=intax.ITtax;
tax+=intax.ProfessionalTax;
// tax+=bm.SentAlert;
Notification? notice=null;
notice=bm.SentAlert;

acct1.overBalance+=tax;

 acct1.underBalance+=notice;

Console.WriteLine(acct1);

Console.WriteLine("Enter the amount to Deposit");
double amount=double.Parse(Console.ReadLine());
acct1.Deposite(amount);
Console.WriteLine("After Deposite");
Console.WriteLine(acct1);
acct1.ProcessTax();

Console.WriteLine("Enter the amount to Withraw");
double amt=double.Parse(Console.ReadLine());
acct1.Withdraw(amt);
Console.WriteLine(acct1);
Console.WriteLine("After Withdraw");
Console.WriteLine(acct1);
acct1.ProcessTax();






