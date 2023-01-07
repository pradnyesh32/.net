namespace OFSEntity;
public class Faculty{
    public int FacultyID{
        get;set;
    }
    public string FacultyName{
        get;set;
}
    public string FacultyMail{
        get;set;
    }
    public Faculty(int id,string name,string email){
        this.FacultyID=id;
        this.FacultyName=name;
        this.FacultyMail=email;
    }

    public override string ToString(){
        return "FacultyID: "+FacultyID+" FacultyName: "+FacultyName+" FacultyMail: "+FacultyMail;
    }
}