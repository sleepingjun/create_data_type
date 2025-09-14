// class :=自創新的資料型態
// object :=萬物皆物件； 用class宣告的資料型態都是object

using Biology;//用using引入namespace
using Furniture;
using System; //引入System namespace aka 用Console的時候不用再多打system了

class Program//C#會默認幫我包進來； 如果class create_data_type 就會把整個專案當成namespace 功能都能直接叫；跨專案也可(參考using system後使用時不用多打system
{
    static void Main() //C#會默認幫我包進來Main
    {
        //create object
        //有namespace要先打namespace 沒有/已經using了就直接用class名字
        Biology.Person p1 = new Person();
        p1.Name = "Terry";
        p1.Age = 19;
        p1.Height = 1.85;
        //Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}, Height: {p1.Height}m");
        p1.Introduce(); //叫功能

        Person p2 = new Person();
        p2.Name = "Alice";
        p2.Age = 25;
        p2.Height = 1.58;
        //Console.WriteLine($"Name: {p2.Name}, Age: {p2.Age}, Height: {p2.Height}m");
        p2.Introduce();

        Chair c1 = new Chair("Red", "Plastic", 40); //new Chair()會跑建構方法
        Console.WriteLine($"Chair Color: {c1.Color}, Material: {c1.Material}, Size: {c1.Size}cm");
        
        Table t1 = new Table();
        Bed b1 = new Bed("surprise!!!");
    }
}

