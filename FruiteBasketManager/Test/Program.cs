using FruitBasket;
using System.Collections.Generic;
Fruit f1=new Mango(10,50);
Fruit f3=new Mango(10,50);
Fruit f2=new Orange(20,40);
Console.WriteLine(f1);
Console.WriteLine(f2);
Console.WriteLine(f2);
List<Fruit>fruits=new List<Fruit>();
fruits.Add(f1);
fruits.Add(f2);
fruits.Add(f3);

Console.WriteLine("-------------------");
foreach(Fruit f in fruits){
    Console.WriteLine(f);
}