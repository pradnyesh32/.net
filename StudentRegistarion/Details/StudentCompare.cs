namespace Details;
public class StudentComapre:Comparer<Student> {
    public override int Compare(Student x, Student y)
    {
       if(x.Marks>y.Marks){
        return 1;
       }
       else if(x.Marks<y.Marks){
        return -1;
       }
       else
       return 0;
    }

    

}