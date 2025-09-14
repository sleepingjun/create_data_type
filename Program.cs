// class :=自創新的資料型態
// object :=萬物皆物件； 用class宣告的資料型態都是object

//create object
//有namespace要先打namespace 沒有就直接用class名字
using Biology;//用using引入namespace
using System; //引入System namespace aka 用Console的時候不用再多打system了
Biology.Person p1 = new Person();
p1.Name = "John";
p1.Age = 30;
p1.Height = 1.75;
Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}, Height: {p1.Height}m");
Biology.Person p2 = new Person();
p2.Name = "Alice";
p2.Age = 25;
p2.Height = 1.65;
Console.WriteLine($"Name: {p2.Name}, Age: {p2.Age}, Height: {p2.Height}m");