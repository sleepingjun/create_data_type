// class :=自創新的資料型態
// object :=萬物皆物件； 用class宣告的資料型態都是object

Person p1 = new Person();//create object
p1.Name = "John";
p1.Age = 30;
p1.Height = 1.75;
Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}, Height: {p1.Height}m");
Person p2 = new Person();
p2.Name = "Alice";
p2.Age = 25;
p2.Height = 1.65;
Console.WriteLine($"Name: {p2.Name}, Age: {p2.Age}, Height: {p2.Height}m");
Person p3 = new Person();
p3.Name = "Bob";
p3.Age = 28;
p3.Height = 1.88;
Console.WriteLine($"Name: {p3.Name}, Age: {p3.Age}, Height: {p3.Height}m");