//namespace = 放模板的分類管理倉庫(?)/資料夾
//來創個class模板， 然後回Program.cs創出來

namespace Biology
{
    //可以在namespace裡面再放namespace 假設名字叫做qqq
    //這樣到時候using要喊 Biology.qqq
    class Person
    {
        public string Name;//public 屬性
        public int Age;
        public double Height;
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