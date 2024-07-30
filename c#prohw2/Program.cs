using interfaces;
using shapes;
using vectors;

Rectangle Rec =  new Rectangle();

Rec.Move(20, 1);
Rec.Move(10, 1);

Rec.ChangeSize(Vector2.One * 10);

Console.WriteLine(Rec.Size);
Console.WriteLine(Rec.Position);
Console.WriteLine(Rec.Size.Length);