// Задача №3. Задать номер четверти (прим: д.б. задан пользователем), показать диапазоны для возможных координат.

Console.OutputEncoding = System.Text.Encoding.UTF8; //найдено в справочнике для отображения матем.обозначений в консоли

string Coordinate(int N)
{
    string Result = ("0");
    if (N == 1)
    {
        Result = ("X ⊂ (0; +∞]; Y ⊂ (0; +∞]");
    }
    else if (N == 2)
    {
        Result = ("X ⊂ (0; -∞]; Y ⊂ (0; +∞]");
    }
    else if (N == 3)
    {
        Result = ("X ⊂ (0; -∞]; Y ⊂ (0; -∞]");
    }
    else if (N == 4)
    {
        Result = ("X ⊂ (0; +∞]; Y ⊂ (0; -∞]");
    }
    else
    {
        Result = ("Введите число от 1 до 4");
    }
    return Result;
}

Console.WriteLine("Введите номер четверти");
int Number = int.Parse(Console.ReadLine());

string Answer = (Coordinate(Number));
Console.WriteLine(Answer);
