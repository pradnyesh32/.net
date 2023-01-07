namespace Details;
using System.Collections.Generic;

public class StudentData{
    public static List<Student> PopulateData(){
        List<Student>list=new List<Student>();
        list.Add(new Student(1,"Ram",99));
        list.Add(new Student(3,"Abhi",100));
        list.Add(new Student(5,"Pradnyesh",96));
        list.Add(new Student(7,"Rohit",94));
        list.Add(new Student(2,"shubham",90));
        list.Add(new Student(4,"Anil",93));  
        list.Add(new Student(6,"Shashank",89));
        list.Add(new Student(8,"Sagar",91)); 
        return list;

    }

}