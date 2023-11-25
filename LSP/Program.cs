// See https://aka.ms/new-console-template for more information
var rec = new Rectangle(2, 3);
Console.WriteLine($"{rec} has area: {Area(rec)}");

var sq = new Square();
sq.Width = 2;
Console.WriteLine($"{sq} has area: {Area(sq)}");

static int Area(Rectangle r) => r.Width * r.Height;
public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public Rectangle()
    {

    }
    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }
    public override string ToString()
    {
        return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
}

public class Square : Rectangle
{
    public override int Width
    {
        set
        {
            base.Width = base.Height = value;
        }
    }
    public override int Height
    {
        set
        {
            base.Width = base.Height = value;
        }
    }
    public Square()
    {

    }

    public Square(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }
}