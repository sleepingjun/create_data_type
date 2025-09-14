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
    {
        public string Name;
        public string Color;
        public int Age;
        public double Weight;
    }
}

namespace Furniture
{
    class Chair
    {
        public string Color;
        public string Material;
        public int Size;
    }
    class Table
    {
        public string Color;
        public string Material;
        public int Size;
    }
}