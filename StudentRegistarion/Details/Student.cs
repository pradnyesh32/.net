namespace Details;
public class Student:IComparable
{
public int Rollno{get;set;}
public string Name{get;set;}
public int Marks{get;set;}

public Student(int rollno,string name,int marks){
    this.Rollno=rollno;
    this.Name=name;
    this.Marks=marks;
}
    public override string ToString()
    {
        return "Roll NO: "+Rollno+" Name: "+Name+"       Marks: "+Marks;
    }

    public int CompareTo(object obj){
        Student anotherstud=(Student)obj;
        if(anotherstud.Rollno<this.Rollno){
            return 1;
        }
        else if(anotherstud.Rollno>this.Rollno){
            return -1;
        }
        else
        return 0;


    }





}
