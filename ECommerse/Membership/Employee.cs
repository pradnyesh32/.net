namespace Membership;
public  class Employee {
   
    public int Empid{
        get;
        set;
    }
    public string FirstName{
        get;set;
    }
    public string LastName{
        get;set;
    }
    public string Email{
        get;set;
    }
    public double Salary{
        get;set;
    }

    public Employee(int id,string fn,string ln,string email,double sal){
        this.Empid=id;
        this.FirstName=fn;
        this.LastName=ln;
        this.Email=email;
        this.Salary=sal;
    }
    public Employee():this(12,"Pradnyesh","Kadam","pradnyeshkadam@123",75388){
    }
    
    public override string ToString(){
        string str="Firstname: "+FirstName+" Lastname: "+LastName+" Email: "+Email+" Salary: "+Salary;
        return str;
    }

    public virtual double CalculateSal(){
        double NetSalary=Salary-5000;
        return NetSalary;
    }









}