using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Recipe Bibimbap = new Recipe("비빔밥", 2, 5);

Bibimbap.AddIngredient("밥");
Bibimbap.AddIngredient("고추장");
Bibimbap.AddIngredient("계란");
Bibimbap.AddIngredient("시금치");
Bibimbap.AddIngredient("당근");

Bibimbap.PrintRecipe();
Console.WriteLine();

Console.WriteLine($"계란 포함: {Bibimbap.HasIngredient("계란")}");
Console.WriteLine($"소고기 포함: {Bibimbap.HasIngredient("소고기")}");
Console.WriteLine();

Recipe Sandwidch = new Recipe("샌드위치", 1, 3);

Sandwidch.AddIngredient("빵");
Sandwidch.AddIngredient("햄");
Sandwidch.AddIngredient("치즈");

Sandwidch.PrintRecipe();