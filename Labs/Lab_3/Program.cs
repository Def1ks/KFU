// Задание 1
// for (int i = 1; i <= 10; i++ ) {
//     for (int f = 1; f <= 10; f++) {
//         Console.WriteLine($"{i} * {f} = {i * f}");
//     }
//     Console.WriteLine("---");
// }

// Задание 2
// int num;
// int sum = 0;
// Console.Write("Введите число: ");
// if (int.TryParse(Console.ReadLine(), out num))
// {
//     if (num <= 0) {
//         Console.WriteLine("Ошибка. Введите число больше нуля");
//         return;
//     }

//     for (int i = 0; i <= num; i++) {
//         sum = sum + i;
//     }

//     Console.WriteLine($"Сумма чисел до {num}: {sum}");
// }
// else
// {
//     Console.WriteLine("Ошибка. Введите целое число");
// }

// Задание 3
// int num;
// Console.Write("Введите число: ");
// if (int.TryParse(Console.ReadLine(), out num))
// {
//     if (num <= 0) {
//         Console.WriteLine("Ошибка. Введите число больше нуля");
//         return;
//     }

//     for (int i = 0; i < num;i++) {
//         for (int f = 0; f <= i; f++) {
//             Console.Write("*");
//         }
//         Console.WriteLine();
//     }
// }
// else
// {
//     Console.WriteLine("Ошибка. Введите целое число");
// }

// Задание 4
// int num;
// Console.Write("Введите число: ");
// if (int.TryParse(Console.ReadLine(), out num))
// {
//     if (num <= 0) {
//         Console.WriteLine("Ошибка. Введите число больше нуля");
//         return;
//     }

//     if (num == 1) {
//         Console.WriteLine("Число не является простым");
//         return;
//     }

//     for (int i = 2; i < num; i++) {
//         if ((num % i) == 0) {
//             Console.WriteLine("Число не является простым");
//             return;
//         }
//     }
//     Console.WriteLine("Число является простым");
// }
// else
// {
//     Console.WriteLine("Ошибка. Введите целое число");
// }

// Массивчики
// Задание 6
// int[] nums = {1,2,3,4,5};
// int num;

// for (int i = 0; i < nums.Length; i++) {
//     Console.Write($"{nums[i]} ");
// }

// for (int i = 0; i < (nums.Length / 2); i++) {
//     num = nums[i];
//     nums[i] = nums[nums.Length - i - 1];
//     nums[nums.Length - 1] = num;
// }

// Console.WriteLine();

// for (int i = 0; i < nums.Length; i++) {
//     Console.Write($"{nums[i]} ");
// }

// Задание 7
// int[] nums = {5,3,7,4,8,6,2,1};
// int num;

// Console.WriteLine("Начальный массив:");
// for (int i = 0; i < nums.Length; i++) {
//     Console.Write($"{nums[i]} ");
// }

// for (int i = 0; i < nums.Length - 1; i++) {
//     for (int f = i + 1; f < nums.Length; f++) {  
//         if (nums[i] > nums[f]) {  
//             num = nums[i];
//             nums[i] = nums[f];
//             nums[f] = num;
//         }
//     } 
// }

// Console.WriteLine();
// Console.WriteLine("Отсортированный массив:");
// for (int i = 0; i < nums.Length; i++) {
//     Console.Write($"{nums[i]} ");
// }

// Задание 8
// int[,] matrix = {
//     {1,2,3},
//     {4,5,6},
//     {7,8,9}
// };

// int sum = 0;
// for (int i = 0; i < matrix.GetLength(0); i++) {
//     sum = sum + matrix[i,i];
// }

// Console.WriteLine(sum); 

// Заключителньое задание
int[] nums = new int[10]; 
Random random = new Random(); 

for (int i = 0; i < 10; i++) {
    nums[i] = random.Next(0, 10); 
}

int minNum = 10;
int maxNum = 0;
int sum = 0;
int countEvenNums = 0;

Console.WriteLine("Начальный массив:");
for (int i = 0; i < 10; i++) {
    Console.Write($"{nums[i]} ");

    if (nums[i] < minNum) {
        minNum = nums[i];
    }

    if (nums[i] > maxNum) {
        maxNum = nums[i];
    }

    sum = sum + nums[i];

    if (nums[i] % 2 == 0) {
        countEvenNums++;
    }
}

Console.WriteLine();
Console.WriteLine($"Минимальное число массива: {minNum}");
Console.WriteLine($"Максимальное число массива: {maxNum}");
Console.WriteLine($"Сумма всех чисел массива: {sum}");
Console.WriteLine($"Количество четных чисел в массиве: {countEvenNums}");

int num = 0;

for (int i = 0; i < (nums.Length / 2); i++) {
    num = nums[i];
    nums[i] = nums[nums.Length - i - 1];
    nums[nums.Length - i - 1] = num;  
}

Console.WriteLine("Перевернутый массив:");

for (int i = 0; i < 10; i++) {
    Console.Write($"{nums[i]} ");
}

for (int i = 0; i < nums.Length - 1; i++) {
    for (int f = i + 1; f < nums.Length; f++) {
        if (nums[i] > nums[f]) {  
            num = nums[i];
            nums[i] = nums[f];
            nums[f] = num;
        }
    } 
}

Console.WriteLine();
Console.WriteLine("Отсортированный массив:");

for (int i = 0; i < 10; i++) {
    Console.Write($"{nums[i]} ");
}
