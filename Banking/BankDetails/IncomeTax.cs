namespace GovermentPolicy;

public delegate void TaxOperation(double amount);
public class IncomeTax
{

       
public void ProfessionalTax(double amount){
    Console.WriteLine("Professional Tax is 20%");
}
public void ITtax(double amount){

  Console.WriteLine("ITtax Tax is 10%");
}
     
 }

    
