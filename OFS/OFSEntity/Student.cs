namespace OFSEntity;
using System.ComponentModel.DataAnnotations;

    [Serializable]
public class Student
{

    public int StudentID{
        get;set;
    }
    public string StudentName{
        get;set;
    }
    public string Email{
        get;set;
    }

    public Student(int sid,string sname,string email){
        this.StudentID=sid;
        this.StudentName=sname;
        this.Email=email;
    }

    public override string ToString(){
        return "StudentId: "+StudentID+" StudentName: "+StudentName+" Email"+Email;
    } 


    

}
