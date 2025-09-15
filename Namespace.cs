//namespace = 放模板的分類管理倉庫(?)/資料夾
//來創個class模板， 然後回Program.cs創出來
//class裡面可以定義methods(功能/function)跟properties(屬性值)

namespace Biology
{
    //可以在namespace裡面再放namespace 假設名字叫做qqq
    //這樣到時候using要喊 Biology.qqq
    class Person
    {
        public string Name;//public 屬性
        public int Age;
        public double Height;

        public void Introduce() //public 方法 //void不回傳，如果要回傳要改成別的資料型態 int/double/string...
        {
            Console.WriteLine($"Hi! My name is {Name}, I am {Age} years old and {Height} meters tall. Nice to meet you~");
        }
    }

    class Cat
    {
        public string Name;
        public string Color;
        public int Age;
        public double Weight;
    }

    class Dog 
    //如果寫成 Dog : Cat 就是繼承Cat的屬性，Cat有的Name. Color,Age,Weight屬性，Dog也會有
    //方法也可以繼承過去直接用
    {
        public string Name;
        public string Color;
        public int Age;
        public double Weight;
    }
}

//Constructors 建構方法 = special method/懶人創class大法
namespace Furniture
{
    class Chair
    {
        public string Color;
        public string Material;
        public int Size;
        public Chair(string color, string material, int size) //建構方法；沒有要回傳值 所以不用放void.int...
        {
            Color = color; //this.color = color; //如果叫一樣的話，可以+this代表這是屬性color
            Material = material;
            Size = size;
        }
    }
    class Table
    {
        public string Color;
        public string Material;
        public int Size;

        public Table() //可以不塞值，只在創建的時候執行下面指定的事
        {
            Console.WriteLine("A table is created.");
        }
    }
    class Bed
    {
        public Bed(string aa)
        {
            Console.WriteLine($"A bed is created. {aa}");
        }

    }
}