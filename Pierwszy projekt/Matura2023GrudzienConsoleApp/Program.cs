
try
{
    StreamReader sr = new StreamReader("mecz_przyklad.txt");

    //string? line;
    //while ((line = sr.ReadLine()) != null)
    //{

    //}

    string? line = sr.ReadLine();
    if (line != null)
    {
        Task1_1(line);
        Task1_2(line);
        Task1_3(line);
    }

    sr.Close();
}
catch (Exception)
{

    throw;
}

void Task1_1(string line)
{
    int count = 0;
    for (int i = 0; i < line.Length - 1; i++)
    {
        if (line[i] != line[i + 1])
            count++;
    }
    Console.WriteLine($"Ilość różnic to {count}");
}

void Task1_2(string line)
{
    int numberOfPointsA = 0;
    int numberOfPointsB = 0;
    for (int i = 0; i < line.Length; i++)
    {
        if (line[i] == 'A')
            numberOfPointsA++;
        if (line[i] == 'B')
            numberOfPointsB++;

        if ((numberOfPointsA >= 1000
              || numberOfPointsB >= 1000)
            && Math.Abs(numberOfPointsA - numberOfPointsB) > 3
           )
            break;
    }
    Console.WriteLine($"Wynik {numberOfPointsA}:{numberOfPointsB}");
}

void Task1_3(string line)
{
    int pointStreakA = 0;
    int goodPointStreakA = 0;
    int pointStreakB = 0;
    int goodPointStreakB = 0;
    int maxPointStreak = -1;
    char maxTeamPointStreak = ' ';
    for (int i = 0; i < line.Length - 1; i++)
    {
        if (line[i] == 'A')
        {
            pointStreakA++;
            pointStreakB = 0;
        }
        if (line[i] == 'B')
        {
            pointStreakB++;
            pointStreakA = 0;
        }

        if (pointStreakA == 10)
            goodPointStreakA++;
        if (pointStreakB == 10)
            goodPointStreakB++;

        if (pointStreakA > maxPointStreak)
        {
            maxPointStreak = pointStreakA;
            maxTeamPointStreak = 'A';
        }
        if (pointStreakB > maxPointStreak)
        {
            maxPointStreak = pointStreakB;
            maxTeamPointStreak = 'B';
        }
    }
    Console.WriteLine($"Ilość dobrych pass drużyny A {goodPointStreakA}");
    Console.WriteLine($"Ilość dobrych pass drużyny B {goodPointStreakB}");
    Console.WriteLine($"Łączna ilość dobrych pass {goodPointStreakA + goodPointStreakB}");
    Console.WriteLine($"Najlepsza passa to {maxPointStreak} drużyny {maxTeamPointStreak}");
}