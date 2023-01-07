namespace FruitBasket;
public abstract class Fruit{

public int Count{
    get;set;
}
public int Price{
    get;set;
}

public Fruit(int count,int price){
    this.Count=count;
    this.Price=price;
}

public abstract string Taste();

public abstract string Color();

public override string ToString(){
    return "Count: "+Count+" Price: "+Price;
}


}
