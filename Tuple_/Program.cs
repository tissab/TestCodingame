// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//var isParsed = int.TryParse("1", out _);
//(Square, Circle) t1 = (new Square { Id = 1, name = "Man" }, new Circle { Id = 1, name = "Man" });
//(Square, Circle) t2 = (new Square { Id = 1, name = "Man" }, new Circle { Id = 1, name = "Man" });
//(int, int) i = (1, 2);
//(int, int) i1 = (1, 2);
//var r = (i == i1);
//var res = (t1== t2);

Shape s = new Square();
Shape c = s as Circle;

class Shape { }
class Square : Shape
{
    public int Id { get; set; }
    public string name { get; set; }
}
class Circle : Shape
{
    public int Id { get; set; }
    public string name { get; set; }
}