namespace FruitBasket;
public class Orange:Fruit{

    public Orange(int count,int price):base(count,price){

    }

    public override string Taste(){
        //Console.WriteLine("Taste: Sour");
        return "Taste: Sour";
    }

    public override string Color(){
        //Console.WriteLine("Color: Orange");
        return "Color: Orange";
    }
     
    public override string ToString(){
        return "Orange---->Taste: "+this.Taste()+" Color: "+this.Color()+" "+base.ToString();
    }




}