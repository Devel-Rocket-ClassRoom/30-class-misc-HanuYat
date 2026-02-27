using System;
using System.Text;

// README.md를 읽고 아래에 코드를 작성하세요.

Person person = new Person();
person.Print();
Console.WriteLine();

Hello hello = new Hello();
hello.Hi();
hello.Bye();
Console.WriteLine();

Console.WriteLine($"덧셈: {Calculator.Add(10, 20)}");
Console.WriteLine($"뺄셈: {Calculator.Subtract(30, 10)}");
Console.WriteLine($"곱셈: {Calculator.Multiply(10, 3)}");
Console.WriteLine();

Console.WriteLine(StringHelper.CleanAndUpper(" Hello World "));
Console.WriteLine(StringHelper.Reverse("Hello"));
Console.WriteLine(StringHelper.IsNullOrEmpty(""));
Console.WriteLine();

Console.WriteLine($"제곱근: {Math.Sqrt(16)}");
Console.WriteLine($"거듭제곱: {Math.Pow(2, 3)}");
Console.WriteLine($"최댓값: {Math.Max(10, 20)}");
Console.WriteLine($"최솟값: {Math.Min(10, 20)}");
Console.WriteLine();

StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(" ");
sb.Append("World");

string sb2 = new StringBuilder()
    .Append("Hello")
    .Append(" ")
    .Append("World")
    .ToString();

Console.WriteLine(sb.ToString());
Console.WriteLine(sb2);
Console.WriteLine();

string message = new MessageBulider()
    .AddText("안녕하세요!")
    .AddNewLine()
    .AddText("반갑습니다.")
    .AddSpace()
    .AddText("좋은 하루 되세요.")
    .Bulid();

Console.WriteLine(message);
Console.WriteLine();

Point point = new Point(0, 0)
    .MoveBy(10, 10)
    .MoveBy(20, 20)
    .MoveBy(30, 30);

Console.WriteLine(point);
Console.WriteLine();

string text = " Hello World ";
string chain = text
    .Trim()
    .ToLower()
    .Replace(" ", "_");

Console.WriteLine(chain);
Console.WriteLine();

MutableCircle circle = new MutableCircle(10);
Console.WriteLine($"반지름: {circle.Radius}");

circle.Radius = 20;
Console.WriteLine($"반지름: {circle.Radius}");
Console.WriteLine();

ImmutableCircle circle1 = new ImmutableCircle(10);
Console.WriteLine($"원본 반지름: {circle1.Radius}");

ImmutableCircle circle2 = new ImmutableCircle(20);
Console.WriteLine($"새 원 반지름: {circle2.Radius}");
Console.WriteLine($"원본 반지름: {circle1.Radius}");
Console.WriteLine();

Player player1 = new Player("용사", 1);
Player player2 = player1.LevelUp();

Console.WriteLine($"player1: {player1.Name}, 레벨: {player1.Level}");
Console.WriteLine($"player2: {player2.Name}, 레벨: {player2.Level}");
Console.WriteLine();

string hi = "Hello";
string hi2 = hi.ToUpper();

Console.WriteLine($"원본: {hi}");
Console.WriteLine($"수정본: {hi2}");
Console.WriteLine();

Character hero = new Character("용사");
Console.WriteLine($"{hero.Name} - 레벨: {hero.Level}, 체력: {hero.Health}");
hero.TakeDamage(30);
hero.Heal(10);
Console.WriteLine();

Console.WriteLine($"계산된 데미지: {GameHelper.CalculateDamage(10, 5)}");
Console.WriteLine($"생존 여부: {GameHelper.IsAlive(50)}");
Console.WriteLine($"체력 상태: {GameHelper.GetHealthStatus(30, 100)}");
Console.WriteLine();

Vector2D vector = new Vector2D(1, 1)
    .Add(2, 3)
    .Multiply(2)
    .Add(-1, -2);

Console.WriteLine($"결과 벡터: {vector}");