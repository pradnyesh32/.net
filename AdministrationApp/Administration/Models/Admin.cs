namespace Administration;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Admin{
    public string Name{get;set;}
    [Required]
    public string Email{get;set;}
    public string Password{get;set;}

    public Admin(string name,string email,string password){
        this.Email=email;
        this.Name=name;
        this.Password=password;

    }


    

}