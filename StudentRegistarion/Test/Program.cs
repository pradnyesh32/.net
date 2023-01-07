using Details;

List<Student> stud=StudentData.PopulateData();
foreach(Student s in stud){
    Console.WriteLine(s);  
}
Console.WriteLine("-------------------------------------------------------------------");
StudentComapre sort=new StudentComapre();
   

stud.Sort(sort);
 Console.WriteLine("After Sorting on Marks");
foreach(Student s in stud){
    Console.WriteLine(s);  
}
Console.WriteLine("-------------------------------------------------------------------");
stud.Sort();
Console.WriteLine("After Sorting on RollNO");
foreach(Student s in stud){
    Console.WriteLine(s);  
}
int count=stud.Count();
Console.WriteLine(count);

