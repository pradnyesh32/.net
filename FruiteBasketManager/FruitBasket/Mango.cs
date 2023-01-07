namespace FruitBasket;
public class Mango:Fruit{

    public Mango(int count,int price):base(count,price){  
    }

    public override string Taste(){
        //Console.WriteLine("Taste: Sweet");
        return "Taste: Sweet";
    }

    public override string Color(){
       // Console.WriteLine("Color: Yellow");
       return "Color: Yellow";
    }
     
    public override string ToString(){
        return "Mango---->Taste: "+this.Taste()+" Color: "+this.Color()+" "+base.ToString();
    }




}