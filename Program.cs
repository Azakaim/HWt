using System;

namespace HomeWorke_4
{
    class Business_analyst
    {

        static void Main(string[] args)


        {
            HomeWorke_4_1();
            Home_Worke_3_1();
            Home_Worke_3_2();
            Triangle();
            Umnozenie();

            #region HomeWorke_Matrix
            // 
            // * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //
            //
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            //
            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //
            #endregion

            #region Home_Worke_4.3.1
            static void Home_Worke_3_1()
            {

                //инициировал массивы с переменными для хранения данных ввода и калькуляции 
                int[] result = new int[3];

                bool[] flag = new bool[3];

                string[] str = new string[5];
                //присвоил строковой переменной значение в зависимости
                //от выбора пользователя
                str[3] = " * ";

                str[4] = " = ";
                //инициировал рандомайзер
                Random r = new();
                //счетчик
                int count = 0;
                //инициировал массивы с переменными для
                //хранения данных ввода и калькуляции
                int[] lenght = new int[7], check = new int[3],
                medianaLenghts = new int[3], counter = new int[4];
                //инициировал вложенный цикл для ввода данных пользователем
                for (int i = 0; i >= 0; i++)
                {
                    //логическое ветвление для контроля цикла 
                    if (count > 0) { break; }

                    Console.Clear();

                    Console.WriteLine("Нео ,введи количество строк в Матрице ");

                    str[0] = Console.ReadLine();


                    flag[0] = int.TryParse(str[0], out result[0]);//проверка на правильный ввод данных пользователем
                    //инициировал вложенный цикл для псоледующего ввода данных пользователем
                    for (; i >= 0; i++)
                    {
                        //логическое ветвление для контроля цикла 
                        if (count > 0) { break; }
                        //логическое ветвление для контроля цикла
                        //при верном вводе
                        if (flag[0] == true && result[0] != 0)
                        {
                            Console.Clear();

                            Console.WriteLine("Нео ,введи количество столбцов в Матрице ");

                            str[1] = Console.ReadLine();

                            flag[1] = int.TryParse(str[1], out result[1]);//проверка на правильный ввод данных пользователем
                            //инициировал вложенный цикл для псоледующего ввода данных пользователем
                            for (; i >= 0;)
                            {
                                //логическое ветвление для контроля цикла 
                                if (count > 0) { break; }

                                //логическое ветвление для контроля цикла
                                //при верном вводе
                                if (flag[1] == true && result[1] != 0)
                                {
                                    Console.Clear();

                                    Console.WriteLine("Нео ,введи число ");

                                    str[2] = Console.ReadLine();

                                    flag[2] = int.TryParse(str[2], out result[2]);

                                    //логическое ветвление для контроля цикла
                                    //при верном вводе и контроль кончного числа ввода == 9999
                                    if (flag[2] == true && result[2] != 0 && result[2] < 9999)
                                    {
                                        count++;
                                        break;
                                    }

                                    else { Console.WriteLine("Попробуйте еще раз!"); Console.ReadKey(); break; }
                                }


                                else { Console.WriteLine("Попробуйте еще раз!"); Console.ReadKey(); break; }
                            }

                        }

                        else { Console.WriteLine("Попробуйте еще раз!"); Console.ReadKey(); break; }
                    }
                }
                //инициировал двойной массив для генерации чисел 
                int[,] matrix = new int[result[0], result[1]];
                //инициировал двойной массив для генерации чисел
                int[,] matrix0 = new int[result[0], result[1]];
                //инициировал одинарный массив для хранения длинны элл-в массива
                int[] checklenght = new int[(int)result[1]];
                //инициировал массив для генерации ранжомных занчений и присваивания их перменным
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = r.Next(1, 20);

                        matrix0[i, j] = result[2] * matrix[i, j];

                    }
                }

                Console.Clear();

                //цикл для вывода 1- го массива == matrix.GetLength
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix0.GetLength(1); j++)
                    {
                        //длинна эллемента
                        lenght[0] = $"{matrix[i, j]}".Length;
                        //медиана где должен быть знак =
                        lenght[1] = matrix0.GetLength(0) / 2;
                        //логическое ветвление для матрицы из 1 элемента
                        if (lenght[1] == i && matrix0.GetLength(0) == 1)
                        {
                            Console.Write($"| {matrix[i, j]} |");
                            if (i == 0) { checklenght[j] = $"| {matrix[i, j]} |".Length; }
                            if (i == 0) { check[0] += checklenght[j] + medianaLenghts[0]; }
                            lenght[1] = matrix0.GetLength(0) / 2;//медиана где должен быть знак =
                            Console.SetCursorPosition(check[0], i);
                            Console.Write($" {str[3]} {result[2]} {str[4]}");

                        }
                        //логическое ветвление для матрицы из большего колл-ва элементов с длинной элл-та == 1 
                        if (j == 0 && lenght[0] == 1 && matrix0.GetLength(0) > 1)
                        {
                            //первый эл-т матрицы
                            Console.Write($"|{matrix[i, j]}  ");
                            //логическое ветвление для матрицы с заходом в 1 раз за все итерации
                            if (i == 0) { checklenght[j] = $"|{matrix[i, j]}  ".Length; }
                        }
                        //логическое ветвление для матрицы из большего колл-ва элементов с длинной элл-та == 2 
                        if (j == 0 && lenght[0] == 2 && matrix0.GetLength(0) > 1)
                        {
                            Console.Write($"|{matrix[i, j]} ");
                            if (i == 0) { checklenght[j] = $"|{matrix[i, j]} ".Length; }
                        }
                        //логическое ветвление для матрицы из большего колл-ва элементов
                        //не являющихся последним элл-т в итерации
                        if (j > 0 && j != matrix0.GetLength(1) - 1 && matrix0.GetLength(0) > 1)
                        {
                            //логическое ветвление с длинной элл-та == 1
                            if (lenght[0] == 1)
                            {
                                //средний эллемент матрицы
                                Console.Write($"{matrix[i, j]}  ");
                                if (i == 0) { checklenght[j] = $"{matrix[i, j]}  ".Length; }
                            }
                            //логическое ветвление с длинной элл-та == 2
                            if (lenght[0] == 2)
                            {
                                Console.Write($"{matrix[i, j]} ");
                                if (i == 0) { checklenght[j] = $"{matrix[i, j]} ".Length; }
                            }
                        }
                        //логическое ветвление для матрицы из большего колл-ва элементов
                        //являющихся последним элл-м в итерации
                        if (j == matrix0.GetLength(1) - 1 && matrix0.GetLength(0) > 1)
                        {
                            //логическое ветвление для элементов с длинной элл-та == 1
                            if (lenght[0] == 1 && j != 0 && matrix0.GetLength(0) > 1)
                            {
                                Console.Write($" {matrix[i, j]}|"); //последний эллемент матрицы
                                if (i == 0) { checklenght[j] = $" {matrix[i, j]}|".Length; }
                            }
                            //логическое ветвление для элементов с длинной элл-та == 2
                            if (lenght[0] == 2 && j != 0 && matrix0.GetLength(0) > 1)
                            {
                                Console.Write($"{matrix[i, j]}|");
                                if (i == 0) { checklenght[j] = $"{matrix[i, j]}|".Length; }
                            }
                            //логическое ветвление для вывода медианного элемента - множителя
                            //и подсчета длинны этих элл-в
                            if (lenght[1] == i && i > 0 && j != 0 && matrix0.GetLength(0) > 1)
                            {
                                Console.SetCursorPosition(check[0], i);
                                Console.Write($" {str[3]} {result[2]} {str[4]}");
                                medianaLenghts[0] = $" {str[3]} {result[2]} {str[4]}".Length;
                                counter[3]++;
                            }
                        }
                        //логическое ветвление для 
                        //подсчета длинны выводимых элл-в
                        if (i == 0 && matrix0.GetLength(0) > 1)
                        {
                            check[0] += checklenght[j];
                        }
                        //условие в котором соблюдается единожды сложение длинны всех элементов строки
                        if (matrix0.GetLength(0) > 1 && medianaLenghts[0] != 0 && counter[3] == 1)
                        {
                            check[0] += medianaLenghts[0]; counter[3]++;
                        }
                    }
                    Console.WriteLine();


                }

                //цикл для вывода 1- го массива == matrix0.GetLength
                for (int i = 0; i < matrix0.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix0.GetLength(1); j++)
                    {
                        //вычисление и присваивание длинны элл-та
                        lenght[6] = $"{matrix0[i, j]}".Length;
                        //логическое ветвление для вывода  элл-в с результатом оперций на консоль
                        if (j == 0)
                        {
                            //логическое ветвление для вывода первых элл-в разной длинны
                            switch (lenght[6])
                            {
                                case 1:
                                    Console.SetCursorPosition(check[0], i);
                                    Console.Write($"|{matrix0[i, j]}      "); break;
                                case 2:
                                    Console.SetCursorPosition(check[0], i);
                                    Console.Write($"|{matrix0[i, j]}     "); break;
                                case 3:
                                    Console.SetCursorPosition(check[0], i);
                                    Console.Write($"|{matrix0[i, j]}    "); break;
                                case 4:
                                    Console.SetCursorPosition(check[0], i);
                                    Console.Write($"|{matrix0[i, j]}   "); break;
                                case 5:
                                    Console.SetCursorPosition(check[0], i);
                                    Console.Write($"|{matrix0[i, j]}  "); break;
                                case 6:
                                    Console.SetCursorPosition(check[0], i);
                                    Console.Write($"|{matrix0[i, j]} "); break;
                            }

                        }
                        //логическое ветвление для вывода срединных элл-в разной длинны
                        if (j > 0 && j != matrix0.GetLength(1) - 1)
                        {
                            switch (lenght[6])
                            {
                                case 1: Console.Write($"{matrix0[i, j]}      "); break;
                                case 2: Console.Write($"{matrix0[i, j]}     "); break;
                                case 3: Console.Write($"{matrix0[i, j]}    "); break;
                                case 4: Console.Write($"{matrix0[i, j]}   "); break;
                                case 5: Console.Write($"{matrix0[i, j]}  "); break;
                                case 6: Console.Write($"{matrix0[i, j]} "); break;
                            }
                        }
                        //логическое ветвление для вывода кончных элл-в в матрице, разной длинны
                        if (j > 0 && j == matrix0.GetLength(1) - 1)
                        {
                            switch (lenght[6])
                            {
                                case 1: Console.Write($"      {matrix0[i, j]}|"); break;
                                case 2: Console.Write($"     {matrix0[i, j]}|"); break;
                                case 3: Console.Write($"    {matrix0[i, j]}|"); break;
                                case 4: Console.Write($"   {matrix0[i, j]}|"); break;
                                case 5: Console.Write($"  {matrix0[i, j]}|"); break;
                                case 6: Console.Write($" {matrix0[i, j]}|"); break;
                            }

                        }
                    }
                    Console.WriteLine();

                }

                Console.ReadKey();
            }
            #endregion

            #region Home_Worke_4.3.2


            static void Home_Worke_3_2()
            {
                Console.Clear();
                
                //инициировал массивы для хранения данных ввода пользователя
                int[] resultini = new int[3];

                int[] counter = new int[5];

                string[] stringer = new string[4];
                //присвоил переменной значение " = "
                stringer[3] = " = ";
                //инициировал рандомайзер
                Random rand = new();
                ////инициировал массивы для хранения булевых значений
                bool[] flager = new bool[3];

                int[] lenghtEl = new int[7];

                int[] checker = new int[3];

                //инициировал вложенный цикл DO WHILE для получения данных от пользователя
                do
                {
                    //логическое ветвление инициировано с целью избавления от нагромождения
                    //этим выражением кода, при потворных итерациях 
                    if (counter[0] == 0)
                    {
                        Console.WriteLine("Введите колличество строк в матрице:"); counter[0]++;
                    }

                    stringer[0] = Console.ReadLine();

                    flager[0] = int.TryParse(stringer[0], out resultini[0]);//проверка на правильность ввода данных 

                    //логическое ветвление для неверного ввода 
                    if (flager[0] != true && stringer[0] != "")
                    {
                        Console.WriteLine("Вы ввели не верное значение,попробуйте еще раз!");
                    }
                    //логическое ветвление для неверного ввода 
                    switch (stringer[0])
                    {
                        case "": Console.WriteLine("Вы ввели не верное значение,попробуйте еще раз!"); counter[0]++; break;
                    }

                    while (flager[0] == true && stringer[2] == null && resultini[0] != 0)
                    {
                        //логическое ветвление инициировано с целью избавления от нагромождения
                        //этим выражением кода, при потворных итерациях
                        if (counter[1] == 0)
                        {
                            Console.WriteLine("Введите колличество столбцов в матрице :");
                        }

                        stringer[1] = Console.ReadLine();

                        flager[1] = int.TryParse(stringer[1], out resultini[1]);//проверка на правильность ввода данных

                        //логическое ветвление для неверного ввода 
                        if (flager[1] != true && stringer[1] != "")
                        {
                            Console.WriteLine("Вы ввели не верное значение,попробуйте еще раз!"); counter[1]++;
                        }
                        //логическое ветвление для неверного ввода 
                        switch (stringer[1])
                        {
                            case "": Console.WriteLine("Вы ввели не верное значение,попробуйте еще раз!"); counter[1]++; break;
                        }
                        //инициировал внутренний цикл DO WHILE для получения данных от пользователя
                        while (flager[1] == true)
                        {
                            if (resultini[1] != 0)
                            {
                                if (counter[2] == 0)
                                {
                                    Console.WriteLine("Обозначте действие," +
                                    "которое вы хотите произвести с матрицами " +
                                    "(+) сложение или вычитание (-) :");
                                }

                                stringer[2] = Console.ReadLine();
                                //логическое ветвление верного ввода
                                if (stringer[2] == "-" || stringer[2] == "+")
                                {
                                    break;
                                }
                                //логическое ветвление для неверного ввода 
                                switch (stringer[2])
                                {
                                    default: Console.WriteLine("Вы ввели не верное значение," +
                                        "попробуйте еще раз!");
                                    counter[2]++; break;
                                }

                            }

                        }
                    }

                } while (stringer[2] == null);//логическое значение при котором цикл будет функционировать

                //инициировал массивы с перменными для хранения рандомных чисел
                //и результата операций между ними
                int[,] matrix0 = new int[resultini[0], resultini[1]];
                int[,] matrix1 = new int[resultini[0], resultini[1]];
                int[,] matrix2 = new int[resultini[0], resultini[1]];
                int[] checks = new int[resultini[1]];
                int[] checkz = new int[resultini[1]];
                int[] medianaLenghts = new int[3];

                //инициировал цикл для присвоенния рандомных значений
                //и выбора оперций между элл-ми матриц
                for (int i = 0; i < matrix0.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix0[i, j] = rand.Next(2, 22);
                        matrix1[i, j] = rand.Next(2, 20);
                        //логическое ветвление выбора операции
                        switch (stringer[2])
                        {
                            case "-":
                                matrix2[i, j] = matrix0[i, j] - matrix1[i, j];
                                break;
                            case "+":
                                matrix2[i, j] = matrix0[i, j] + matrix1[i, j];
                                break;
                        }
                    }
                }
                Console.Clear();

                //инициировал цикл для вывода на экран консоли элл-в 1-й матрицы  matrix0.GetLength
                for (int i = 0; i < matrix0.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        //длинна эллемента
                        lenghtEl[0] = $"{matrix0[i, j]}".Length;
                        //медиана где должен быть знак " = "
                        lenghtEl[1] = matrix0.GetLength(0) / 2;
                        //логическое ветвление для матрицы из 1 элемента
                        if (lenghtEl[1] == i && matrix0.GetLength(0) == 1)
                        {
                            Console.Write($"| {matrix0[i, j]} |");
                            if (i == 0) { checks[j] = $"| {matrix0[i, j]} |".Length; }
                            if (i == 0) { checker[0] += checks[j] + medianaLenghts[0]; }
                            lenghtEl[1] = matrix0.GetLength(0) / 2;//медиана где должен быть знак " = "
                            Console.SetCursorPosition(checker[0], i);
                            Console.Write($" {stringer[2]} ");
                        }
                        //логическое ветвление для матрицы из большего колл-ва элементов
                        //где длинна элл-та == 1
                        if (j == 0 && lenghtEl[0] == 1 && matrix0.GetLength(0) > 1)
                        {
                            Console.Write($"|{matrix0[i, j]}  ");
                            if (i == 0) { checks[j] = $"|{matrix0[i, j]}  ".Length; }
                        }
                        //логическое ветвление для матрицы из большего колл-ва элементов
                        //где длинна элл-та == 2
                        if (j == 0 && lenghtEl[0] == 2 && matrix0.GetLength(0) > 1)
                        {
                            Console.Write($"|{matrix0[i, j]} ");
                            if (i == 0) { checks[j] = $"|{matrix0[i, j]} ".Length; }
                        }

                        //логическое ветвление для срединных элл-в матрицы 
                        if (j > 0 && j != matrix0.GetLength(1) - 1 && matrix0.GetLength(0) > 1)
                        {
                            //логическое ветвление где длинна элл-та == 1
                            if (lenghtEl[0] == 1)
                            {
                                Console.Write($"{matrix0[i, j]}  ");
                                if (i == 0) { checks[j] = $"{matrix0[i, j]}  ".Length; }
                            }
                            //логическое ветвление где длинна элл-та == 2
                            if (lenghtEl[0] == 2)
                            {
                                Console.Write($"{matrix0[i, j]} ");
                                if (i == 0) { checks[j] = $"{matrix0[i, j]} ".Length; }
                            }
                        }
                        //логическое ветвление для конечных  элл-в  в строке матрицы 
                        if (j == matrix0.GetLength(1) - 1 && matrix0.GetLength(0) > 1)
                        {
                            //логическое ветвление где длинна элл-та == 1
                            if (lenghtEl[0] == 1 && j != 0 && matrix0.GetLength(0) > 1)
                            {
                                Console.Write($" {matrix0[i, j]}|");
                                if (i == 0) { checks[j] = $" {matrix0[i, j]}|".Length; }
                            }
                            //логическое ветвление где длинна элл-та == 2
                            if (lenghtEl[0] == 2 && j != 0 && matrix0.GetLength(0) > 1)
                            {
                                Console.Write($"{matrix0[i, j]}|");
                                if (i == 0) { checks[j] = $"{matrix0[i, j]}|".Length; }
                            }
                            //логическое ветвление для медианного элл-та " = "
                            if (lenghtEl[1] == i && i > 0 && j != 0 && matrix0.GetLength(0) > 1)
                            {
                                Console.SetCursorPosition(checker[0], i);
                                Console.Write($" {stringer[2]} ");
                                medianaLenghts[0] = $" {stringer[2]} ".Length;
                                counter[3]++;
                            }
                        }
                        //логическое ветвление для подсчета длинны элл-тов выводимых на консоль
                        if (i == 0 && matrix0.GetLength(0) > 1)
                        {
                            checker[0] += checks[j];
                        }
                        //логическое ветвление при котором соблюдается единожды сложение длинны всех элементов строки
                        if (matrix0.GetLength(0) > 1 && medianaLenghts[0] != 0 && counter[3] == 1)
                        {
                            checker[0] += medianaLenghts[0]; counter[3]++;
                        }
                    }
                    Console.WriteLine();

                }

                //инициировал цикл для вывода на экран консоли элл-в 2-й матрицы matrix1.GetLength
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        lenghtEl[2] = $"{matrix1[i, j]}".Length;

                        //логическое ветвление для первого элемента матрицы 
                        if (j == 0 && matrix1.GetLength(0) > 1)
                        {
                            //логическое ветвление с выводом в по разной длинне элл-та
                            switch (lenghtEl[2])
                            {
                                case 1:
                                    Console.SetCursorPosition(checker[0], i);
                                    Console.Write($" |{matrix1[i, j]}  ");
                                    checkz[j] = $" |{matrix1[i, j]}  ".Length; break;
                                case 2:
                                    Console.SetCursorPosition(checker[0], i);
                                    Console.Write($" |{matrix1[i, j]} ");
                                    checkz[j] = $" |{matrix1[i, j]} ".Length; break;
                                case 3:
                                    Console.SetCursorPosition(checker[0], i);
                                    Console.Write($" |{matrix1[i, j]}");
                                    checkz[j] = $" |{matrix1[i, j]}".Length; break;
                            }

                        }
                        //логическое ветвление для вывода срединных элл-в матрицы
                        if (j > 0 && j != matrix1.GetLength(1) - 1 && matrix1.GetLength(0) > 1)
                        {
                            //логическое ветвление с выводом в по разной длинне элл-та
                            switch (lenghtEl[2])
                            {
                                case 1:
                                    Console.Write($"{matrix1[i, j]}  ");
                                    checkz[j] = $"{matrix1[i, j]}  ".Length; break;
                                case 2:
                                    Console.Write($"{matrix1[i, j]} ");
                                    checkz[j] = $"{matrix1[i, j]} ".Length; break;
                                case 3:
                                    Console.Write($"{matrix1[i, j]}");
                                    checkz[j] = $"{matrix1[i, j]}".Length; break;
                            }

                        }
                        //логическое ветвление для вывода конечных элл-в строки матрицы
                        if (j > 0 && j == matrix0.GetLength(1) - 1 && matrix1.GetLength(0) > 1)
                        {
                            switch (lenghtEl[2])
                            {
                                case 1:
                                    Console.Write($"  {matrix1[i, j]}|");
                                    checkz[j] = $"  {matrix1[i, j]}|".Length; break;
                                case 2:
                                    Console.Write($" {matrix1[i, j]}|");
                                    checkz[j] = $" {matrix1[i, j]}|".Length; break;
                                case 3:
                                    Console.Write($"{matrix1[i, j]}|");
                                    checkz[j] = $"{matrix1[i, j]}|".Length; break;
                            }
                            //логическое ветвление для вывода медианного элл-та " = "
                            if (lenghtEl[1] == i && i > 0 && j != 0 && matrix0.GetLength(0) > 1)
                            {
                                Console.SetCursorPosition(checker[1], i);
                                Console.Write($" {stringer[3]} ");
                                medianaLenghts[1] = $" {stringer[3]} ".Length;
                                counter[4]++;
                            }
                        }
                        //логическое ветвление для вычисления длинны выводимых элл-в матрицы
                        if (i == 0 && matrix1.GetLength(0) > 1)
                        {
                            checker[1] += checkz[j];

                            if (j == matrix0.GetLength(1) - 1)
                            {
                                checker[1] += checker[0];
                            }
                        }
                        //логическое ветвление для вычисления длинны выводимых элл-в матрицы
                        //с медианным значением знаков " = " и " + " или " - "
                        if (matrix1.GetLength(0) > 1 && medianaLenghts[1] != 0 && counter[4] == 1)
                        {
                            checker[2] += checker[1] + medianaLenghts[1]; counter[4]++;
                        }

                    }


                }

                //инициировал цикл для вывода на экран консоли элл-в 3-й матрицы matrix2.GetLength
                //со значениями результатов операций между матрицами
                for (int i = 0; i < matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        //длинна элл-та 
                        lenghtEl[3] = $"{matrix2[i, j]}".Length;
                        //логическое ветвление для первого элемента матрицы
                        if (j == 0 && matrix2.GetLength(0) > 1)
                        {
                            //логическое ветвление по длинна элл-та 
                            switch (lenghtEl[3])
                            {
                                case 1:
                                    Console.SetCursorPosition(checker[2], i);
                                    Console.Write($" |{matrix2[i, j]}  ");
                                    checkz[j] = $" |{matrix2[i, j]}  ".Length; break;
                                case 2:
                                    Console.SetCursorPosition(checker[2], i);
                                    Console.Write($" |{matrix2[i, j]} ");
                                    checkz[j] = $" |{matrix2[i, j]} ".Length; break;
                                case 3:
                                    Console.SetCursorPosition(checker[2], i);
                                    Console.Write($" |{matrix2[i, j]}");
                                    checkz[j] = $" |{matrix2[i, j]}".Length; break;
                            }

                        }
                        //логическое ветвление для срединных элементов строки матрицы
                        if (j > 0 && j != matrix2.GetLength(1) - 1 && matrix2.GetLength(0) > 1)
                        {
                            //логическое ветвление по длинна элл-та 
                            switch (lenghtEl[3])
                            {
                                case 1:
                                    Console.Write($"{matrix2[i, j]}  ");
                                    checkz[j] = $"{matrix2[i, j]}  ".Length; break;
                                case 2:
                                    Console.Write($"{matrix2[i, j]} ");
                                    checkz[j] = $"{matrix2[i, j]} ".Length; break;
                                case 3:
                                    Console.Write($"{matrix2[i, j]}");
                                    checkz[j] = $"{matrix2[i, j]}".Length; break;
                            }

                        }
                        //логическое ветвление для конечных элементов строки матрицы
                        if (j > 0 && j == matrix2.GetLength(1) - 1 && matrix2.GetLength(0) > 1)
                        {
                            //логическое ветвление по длинна элл-та 
                            switch (lenghtEl[3])
                            {
                                case 1:
                                    Console.Write($"  {matrix2[i, j]}|");
                                    checkz[j] = $"  {matrix2[i, j]}|".Length; break;
                                case 2:
                                    Console.Write($" {matrix2[i, j]}|");
                                    checkz[j] = $" {matrix2[i, j]}|".Length; break;
                                case 3:
                                    Console.Write($"{matrix2[i, j]}|");
                                    checkz[j] = $"{matrix2[i, j]}|".Length; break;
                            }

                        }
                    }

                    Console.WriteLine();
                }

                Console.ReadKey();
            }


            #endregion

            #region HomeWorke_4_2()-Triangle
            static void Triangle()
            {
                #region HomeWorke_4(2)
                // * Задание 2
                // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
                // 
                // При N = 9. Треугольник выглядит следующим образом:
                //                                 1
                //                             1       1
                //                         1       2       1
                //                     1       3       3       1
                //                 1       4       6       4       1
                //             1       5      10      10       5       1
                //         1       6      15      20      15       6       1
                //     1       7      21      35      35       21      7       1
                //                                                              
                //                                                              
                // Простое решение:                                                             
                // 1
                // 1       1
                // 1       2       1
                // 1       3       3       1
                // 1       4       6       4       1
                // 1       5      10      10       5       1
                // 1       6      15      20      15       6       1
                // 1       7      21      35      35       21      7       1
                // 
                // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля
                #endregion

                Console.Clear();

                Console.WriteLine("\nТреугольник Паскаля\n");
                //задаю значение размера Буфера консоли
                Console.SetBufferSize(375, 300);
                //задаю значение размера окна консоли
                Console.SetWindowSize(170, 55);
                //инициировал вложенный массив с 25 строками по условию задачи
                int[][] triangle = new int[25][];
                //инициировал переменную для хранения длинны элл-ов и присовил ей значение 
                int lenght ;

                for (int i = 0; i < triangle.Length; i++)
                {
                    //присвоил итому массиву значение с иницииацией
                    //нового массива внутри этого массива
                    triangle[i] = new int[i + 1];
                    
                    //инициировал вложенный цикл для вычисления 
                    //значений элл-в массива треугольника Паскаля
                    //и последующим выводом элл-в массива на консоль
                    for (int j = 0; j < triangle[i].Length; j++)
                    {
                        //логическое ветвление для присвоения первому элл-та массива
                        //начального значения тругольника Паскаля
                        if (i == 0 || j >= i || j == 0)
                        {
                            triangle[i][j] = 1;
                        }
                        //логическое ветвление для вычисления последующих элл-тов массива
                        //по формуле для чисел треугольника паскаля,
                        //равных сумме двух расположенных над ним чисел  

                        if (i > 0 && j > 0 && j != i)
                        {
                            triangle[i][j] = triangle[i - 1][j] + triangle[i - 1][j - 1];
                        }

                        //вычисление длинны элл-та массива
                        lenght = $"{triangle[i][j]}".Length;

                        //логическое ветвление для вывода строк массива с длинной элл-та == 1
                        if (lenght == 1)
                        {
                            //логическое ветвление для вывода на консоль элл-тов массива равных цифре 1
                            if (i >= 1 && i == j)
                            {
                                Console.Write($"       {triangle[i][j]}");

                                Console.WriteLine();
                            }
                            else
                            {
                                //логическое ветвление для вывода срединных элл-в массива заключенных между единицами
                                if (i <= 24 && j == i - 1)
                                {
                                    Console.Write($"{triangle[i][j]}"); continue;
                                }

                                Console.Write($"{triangle[i][j]}       ");
                            }
                            //логическое ветвление для разделения строк абзацем
                            if (i == 0 && j == 0) { Console.WriteLine(); }
                        }
                        //логическое ветвление для вывода строк массива с длинной элл-та == 2
                        if (lenght == 2)
                        {
                            //логическое ветвление для вывода срединных элл-в массива заключенных между единицами
                            if (i <= 24 && j == i - 1)
                            {
                                Console.Write($"{triangle[i][j]}"); continue;
                            }
                            Console.Write($"{triangle[i][j]}      ");
                        }
                        //логическое ветвление для вывода строк массива с длинной элл-та == 3
                        if (lenght == 3)
                        {
                            //логическое ветвление для вывода срединных элл-в массива заключенных между единицами
                            if (i <= 24 && j == i - 1)
                            {
                                Console.Write($"{triangle[i][j]}"); continue;
                            }
                            Console.Write($"{triangle[i][j]}     ");
                        }
                        //логическое ветвление для вывода строк массива с длинной элл-та == 4
                        if (lenght == 4)
                        {
                            //логическое ветвление для вывода срединных элл-в массива заключенных между единицами
                            if (i <= 24 && j == i - 1)
                            {
                                Console.Write($"{triangle[i][j]}"); continue;
                            }
                            Console.Write($"{triangle[i][j]}    ");
                        }
                        //логическое ветвление для вывода строк массива с длинной элл-та == 5
                        if (lenght == 5)
                        {
                            //логическое ветвление для вывода срединных элл-в массива заключенных между единицами
                            if (i <= 24 && j == i - 1)
                            {
                                Console.Write($"{triangle[i][j]}"); continue;
                            }
                            Console.Write($"{triangle[i][j]}   ");
                        }
                        //логическое ветвление для вывода строк массива с длинной элл-та == 6
                        if (lenght == 6)
                        {
                            //логическое ветвление для вывода срединных элл-в массива заключенных между единицами
                            if (i <= 24 && j == i - 1)
                            {
                                Console.Write($"{triangle[i][j]}  "); continue;
                            }
                            Console.Write($"{triangle[i][j]}  ");
                        }
                        //логическое ветвление для вывода строк массива с длинной элл-та == 7
                        if (lenght == 7)
                        {
                            //логическое ветвление для вывода срединных элл-в массива заключенных между единицами
                            if (i <= 24 && j == i - 1)
                            {
                                Console.Write($"{triangle[i][j]} "); continue;
                            }
                            Console.Write($"{triangle[i][j]} ");
                        }

                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            #endregion

            #region HomeWorke_4_1()
            static void HomeWorke_4_1()
            {
                //одномерный массив для хранения значений месяц/доход/расход
                string[] str = { "Месяц", "Доход/тыс.руб.", "Расход/тыс.руб.", "Прибыль/тыс.руб." };
                int[,] massiv0 = new int[12, 4];//двумерный массив для хранения вещественных значений месяц/доход/расход
                int[] marga = new int[12];//одномерный массив для значений прибыли 
                Random rand = new Random();//переменная рандомайзера значений дохода и расхода
                string noprofitCheck = "";
                int countNo = 0;//счетчик месяцев с отрицательной прибылью
                int countYes = 0;//счетчик месяцев с положительной прибылью
                //вывожу на консоль одномерный массив месяц/доход/расход
                Console.WriteLine($"{str[0],5}{str[1],18}{str[2],18}{str[3],18}");

                //Внешний цикл для двумерного массива 
                for (int i = 0; i < massiv0.GetLength(0); i++)
                {
                    for (int j = 0; j < massiv0.GetLength(1); j++)//Внутренний цикл для двумерного массива
                    {
                        if (j > 0)//логическое ветвление для оптимизации процесса рандомизации значений
                        {
                            massiv0[i, 1] = rand.Next(1, 10) * 10000;//рандомный доход
                            massiv0[i, 2] = rand.Next(0, 10) * 10000;//рандомный расход
                            massiv0[i, 3] = massiv0[i, 1] - massiv0[i, 2];//маржинальность 
                            marga[i] = massiv0[i, 3];//маржинальные значения
                            //Вывод значений 
                            Console.Write($"{massiv0[i, 0],2} {massiv0[i, 1],17}{massiv0[i, 2],17}{marga[i],17}");
                            break;
                        }

                        //логическое ветвление для придяния фиксированных значений в двумерном массиве
                        if (i >= 0 && j == 0)
                        {
                            massiv0[i, 0] = i + 1;
                        }

                    }
                    Console.WriteLine();//для переноса каретки между строками массива (что бы не в один ряд)
                }

                //Цикл для одномерного массива по выявлению
                //самых худших показателей по месяцам, с худшей прибылью
                for (int i = 0; i < marga.Length; i++)
                {
                    if (massiv0[i, 1] < massiv0[i, 2] || massiv0[i, 3] == 0)//месяцы с худшей прибылью
                    {
                        //присваиваем значение месяцев с отрицательным или нулевым значением прибыли
                        //строковой переменной 
                        noprofitCheck = noprofitCheck + "," + (i + 1).ToString();
                        countNo++;
                    }
                    else//количество месяцев с положительной прибылью
                    {

                        countYes++;
                    }

                }
                Console.WriteLine($"\nМесяцы с худшей прибылью {noprofitCheck}");

                Console.WriteLine($"\n{countYes} количество месяцев с положительной прибылью");

                if (countNo < 3)
                {
                    Console.WriteLine("\nМаржинальность бизнеса высокая");
                }

                if (countNo >= 3 && countNo < 5)
                {
                    Console.WriteLine("\nУ Вас хорошие перспективы в данном направлении Бизнеса");
                }

                if (countNo >= 5)
                {
                    Console.WriteLine("\nМаржинальность бизнеса убыточна," +
                        "\nВам стоит пресмотреть преспективы в данном направлении бизнеса");
                }

                Console.WriteLine("\nНажмите Enter");
                Console.ReadKey();


            }
            #endregion

            #region Umnozenie
            static void Umnozenie()
            {
                {
                    Console.Clear();

                    //определил переменные и создал массивы
                    int[] resultini = new int[4];

                    int[] counter = new int[5];

                    string[] stringer = new string[5];

                    stringer[3] = " = ";
                        
                    stringer[2] = " * ";

                    Random rand = new();

                    bool[] flager = new bool[4];

                    int[] lenghtEl = new int[7];

                    int[] checker = new int[4];

                    
                    //Инициировал внешний цикл Do While для получения данных от пользователя
                    do
                    {   //условие при котрором в цикле при повторной итерации не будет нагромождения из этой фразы  
                        if (counter[0] == 0)
                        {
                            Console.WriteLine("Введите колличество строк в первой матрице,которое будет равно колличеству столбцов " +
                                "второй матрицы:"); counter[0]++;
                        }
                        
                        stringer[0] = Console.ReadLine();//

                        flager[0] = int.TryParse(stringer[0], out resultini[0]);//проверка на не правильны ввод данных

                        if (flager[0] != true && stringer[0] != "")
                        {
                            Console.WriteLine("\nВы ввели неверное значение,попробуйте еще раз!");
                        }

                        switch (stringer[0])
                        {
                            case "": Console.WriteLine("\nВы ввели неверное значение,попробуйте еще раз!"); counter[0]++; break;
                        }

                        //внутренний цикл для получения данных от пользователя
                        while (flager[0] == true && resultini[0] != 0 && resultini[1] == 0)
                        {
                            if (counter[1] == 0)
                            {
                                Console.WriteLine("\nВведите колличество столбцов в первой матрице ,которое будет равно колличеству строк " +
                                "второй матрицы:"); 
                            }
                            stringer[1] = Console.ReadLine();

                            flager[1] = int.TryParse(stringer[1], out resultini[1]);//проверка на не правильны ввод данных

                            if (flager[1] != true && stringer[1] != "")
                            {
                                Console.WriteLine("\nВы ввели неверное значение,попробуйте еще раз!"); counter[1]++;
                            }
                            switch (stringer[1])
                            {
                                case "": Console.WriteLine("\nВы ввели неверное значение,попробуйте еще раз!"); counter[1]++; break;
                            }

                            //внутренний цикл для получения данных от пользователя
                            while (flager[1] == true)
                            {
                                if (resultini[1] != 0)
                                {
                                    if (counter[2] == 0) { break; }
                                }
                            }
                        }

                    } while ( resultini[1] == 0);//условие при выполнении которого не прервет работу цикл 

                    //инициировал вложенный массив с данными пользователя 
                    int[][] matrix0 = new int[resultini[0]][];

                    //выделил память каждому эл-ту массива через вложенный 2-й цикл
                    for (int i = 0; i < matrix0.Length; i++)
                    {
                        matrix0[i] = new int[resultini[1]];

                        for (int j = 0; j < matrix0[i].Length; j++)
                        {
                            matrix0[i][j] = 0;
                        }
                    }

                    //инициировал вложенный массив с данными пользователя 
                    int[][] matrix1 = new int[resultini[1]][];

                    //выделил память каждому эл-ту массива через вложенный 2-й цикл
                    for (int i = 0; i < matrix1.Length; i++)
                    {
                        matrix1[i] = new int[resultini[0]];

                        for (int j = 0; j < matrix1[i].Length; j++)
                        {
                            matrix1[i][j] = 0;
                        }
                    }
                    
                    //инициировал переменные для гармоничного вывода массивов на экран консоли
                    int[] medianaLenghts = new int[3], maxvalue = new int[1] , minvalue = new int[1];

                    //определил мин. и макс. значения введенные пользователем
                    if (resultini[0] > resultini[1])
                    {
                        maxvalue[0] = resultini[0];

                        minvalue[0] = resultini[1];
                    }
                    if (resultini[1] > resultini[0])
                    {
                       maxvalue[0] = resultini[1];

                       minvalue[0] = resultini[0];
                    }
                    if (resultini[0] == resultini[1])
                    {
                        maxvalue[0] = resultini[1];

                        minvalue[0] = resultini[0];
                    }

                    //инициировал массив для хранение длинны элл-ов после каждого вывода на консоль
                    int[] checks = new int[maxvalue[0]];
                    int[] checkz = new int[maxvalue[0]];

                    //инициировал массив для хранение резултата операций между эллементами массива 
                    int[,] matrix2 = new int[minvalue[0], minvalue[0]];

                    //выделил память каждому эл-ту массива через вложенный 2-й цикл
                    for (int i = 0; i < matrix2.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix2.GetLength(1); j++)
                        {
                            matrix2[i,j] = 0;
                        }
                    }

                    //присвоил пременным массива рандомные значения
                    for (int i = 0; i < matrix0.Length; i++)
                    {
                        for (int j = 0; j < matrix0[i].Length; j++)
                        {
                            matrix0[i][j] = rand.Next(2, 9);
                        }
                    }

                    //присвоил пременным массива рандомные значения
                    for (int i = 0; i < matrix1.Length; i++)
                    {
                        for (int j = 0; j < matrix1[i].Length; j++)
                        {
                            matrix1[i][j] = rand.Next(1, 7);
                        }
                    }

                    //инициировал тройной вложенный цикл с разными логическими условиям для проведения
                    //операций векторного умножения матриц
                    for (int i = 0; i < matrix2.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix2.GetLength(0); j++)
                        {
                            for (int k = 0; k <= matrix1[i].Length ; k++)
                            {
                                //условие при котором мы определим множимое и множитель || что столбец а что строка)
                                if (resultini[0] > resultini[1] && matrix0.Length == 1)
                                {
                                    if (k == 0) { continue; }
                                    
                                    matrix2[i, j] += matrix0[k - 1 ][i] * matrix1[j][k - 1 ];
                                }
                                //условие при котором мы определим множимое и множитель || что столбец а что строка)
                                if (resultini[0] < resultini[1] && matrix0.Length == 1)//определение множителя
                                {
                                    matrix2[i, j] += matrix1[k][i] * matrix0[j][k];
                                }
                                //условие при котором мы определим множимое и множитель || что столбец а что строка)
                                if (resultini[0] > resultini[1] && matrix0.Length != 1)
                                {
                                    if (k == 0) { continue; }

                                    matrix2[i, j] += matrix0[k - 1][i] * matrix1[j][k - 1];
                                }
                                //условие при котором мы определим множимое и множитель || что столбец а что строка)
                                if (resultini[0] < resultini[1] && matrix0.Length != 1)//определение множителя
                                {
                                    matrix2[i, j] += matrix1[k][i] * matrix0[j][k];
                                }
                                //условие при котором мы определим множимое и множитель || что столбец а что строка)
                                if ( resultini[0] == resultini[1])
                                {
                                    if (k == 0) { continue; }

                                    matrix2[i, j] += matrix0[k - 1][i] * matrix1[j][k - 1];
                                }
                            }
                            
                        }
                    }

                    Console.Clear();

                    //вложенный цикл для вывода Матрицы == matrix0
                    for (int i = 0; i < matrix0.Length; i++)
                    {
                        for (int j = 0; j < matrix0[i].Length; j++)
                        {   
                            //длинна эллемента
                            lenghtEl[0] = $"{matrix0[i][j]}".Length;
                            //медиана где должен быть знак " = "
                            lenghtEl[1] = matrix0.Length / 2;
                            //логическое условие для матрицы из 1 -го элл-та 
                            if (matrix0[i].Length == 1)//для матрицы из 1 элемента
                            {
                                Console.Write($"| {matrix0[i][j]} |");

                                if (i == 0 && j == 0) { checks[j] += $"| {matrix0[i][j]} |".Length; }
                                
                                if (lenghtEl[1] == i)
                                {
                                    Console.Write($" {stringer[2]} ");
                                    medianaLenghts[0] = $" {stringer[2]} ".Length;
                                    counter[3]++;
                                }

                                if (counter[3] == 1) { checker[0] += checks[j] + medianaLenghts[0]; counter[3]++; }
                            }
                            //условие для матрицы из болшего кол -ва элл-в и длинны эл-та == 1 
                            if (j == 0 && lenghtEl[0] == 1 && matrix0[i].Length > 1)
                            {
                                Console.Write($"|{matrix0[i][j]}  ");//первый эл-т матрицы
                                if (i == 0) { checks[j] = $"|{matrix0[i][j]}  ".Length; }//что бы не все по кругу собирать а 1 раз
                            }
                            //условие для матрицы из болшего кол -ва элл-в и длинны эл-та == 2
                            if (j == 0 && lenghtEl[0] == 2 && matrix0[i].Length > 1)
                            {
                                Console.Write($"|{matrix0[i][j]} ");
                                if (i == 0) { checks[j] = $"|{matrix0[i][j]} ".Length; }
                            }
                            //условие для последовательного вывода на консоль всех элл-в
                            //кроме последнего элл -та матрицы  
                            if (j > 0 && j != matrix0[i].Length - 1 && matrix0[i].Length > 1)
                            {
                                if (lenghtEl[0] == 1)
                                {
                                    Console.Write($"{matrix0[i][j]}  ");//средний эллемент матрицы
                                    if (i == 0) { checks[j] = $"{matrix0[i][j]}  ".Length; }
                                }
                                if (lenghtEl[0] == 2)
                                {
                                    Console.Write($"{matrix0[i][j]} ");
                                    if (i == 0) { checks[j] = $"{matrix0[i][j]} ".Length; }
                                }
                            }
                            //условие для  вывода на консоль последнего элл -та матрицы  
                            if (j == matrix0[i].Length - 1 && matrix0[i].Length > 1)
                            {
                                if (lenghtEl[0] == 1 && j != 0 && matrix0[i].Length > 1)
                                {
                                    Console.Write($" {matrix0[i][j]}|"); //последний эллемент матрицы
                                    if (i == 0) { checks[j] = $" {matrix0[i][j]}|".Length; }
                                }
                                if (lenghtEl[0] == 2 && j != 0 && matrix0[i].Length > 1)
                                {
                                    Console.Write($"{matrix0[i][j]}|");
                                    if (i == 0) { checks[j] = $"{matrix0[i][j]}|".Length; }
                                }
                                if (lenghtEl[1] == i && i > 0 && j != 0 && matrix0[i].Length > 1)
                                {
                                    Console.SetCursorPosition(checker[0], i);
                                    Console.Write($" {stringer[2]} ");
                                    medianaLenghts[0] = $" {stringer[2]} ".Length;
                                    counter[3]++;
                                }
                                
                            }
                            //условие для подсчета длинны строк вывода элл-в матрицы
                            if (i == 0 && matrix0[i].Length > 1)
                            {
                                checker[0] += checks[j];
                            }
                            //логическое условие для матрицы из 1 -го элл-та и вывода знака " * "
                            if (j == matrix0[i].Length - 1 && lenghtEl[1] == i && i == 0 && j != 0 && matrix0[i].Length > 1)
                            {
                                Console.SetCursorPosition(checker[0], i);
                                Console.Write($" {stringer[2]} ");
                                medianaLenghts[0] = $" {stringer[2]} ".Length;
                                counter[3]++;
                            }
                            //условие в котором соблюдается единожды сложение длинны всех элементов строки
                            //для вычисления точки для курсора  ипоследующего вывода на консоль элл-в других матриц
                            if (matrix0[i].Length > 1 && medianaLenghts[0] != 0 && counter[3] == 1)
                            {
                                checker[0] += medianaLenghts[0]; counter[3]++;
                            }
                        }
                        Console.WriteLine();

                    }

                    //вложенный цикл для вывода Матрицы == matrix1
                    for (int i = 0; i < matrix1.Length; i++)
                    {
                        //медиана где должен быть знак =
                        lenghtEl[1] = matrix1.Length / 2;

                        for (int j = 0; j < matrix1[i].Length; j++)
                        {
                            //длинна эллемента
                            lenghtEl[2] = $"{matrix1[i][j]}".Length;
                            //логическое условие для матрицы из 1 -го элл-та 
                            if (j == 0 && matrix1[i].Length == 1) 
                            
                            {
                                switch (lenghtEl[2])
                                {
                                    case 1:
                                        Console.SetCursorPosition(checker[0], i);
                                        Console.Write($" |{matrix1[i][j]}|  ");
                                        checkz[j] = $" |{matrix1[i][j]}|  ".Length; break;
                                    case 2:
                                        Console.SetCursorPosition(checker[0], i);
                                        Console.Write($" |{matrix1[i][j]}| ");
                                        checkz[j] = $" |{matrix1[i][j]}| ".Length; break;
                                    case 3:
                                        Console.SetCursorPosition(checker[0], i);
                                        Console.Write($" |{matrix1[i][j]}|");
                                        checkz[j] = $" |{matrix1[i][j]}|".Length; break;
                                }
                                if (i == lenghtEl[1])
                                {
                                    Console.SetCursorPosition(checker[1], i);
                                    Console.Write($" {stringer[3]} ");
                                    medianaLenghts[1] = $" {stringer[3]} ".Length;
                                    counter[4]++;
                                }
                                if (i == 0 )
                                {
                                    checker[1] += checkz[j];

                                    if (j == matrix1[i].Length - 1)
                                    {
                                        checker[1] += checker[0];
                                    }
                                }

                                if ( medianaLenghts[1] != 0 && counter[4] == 1)
                                {
                                    checker[2] += checker[1] + medianaLenghts[1]; counter[4]++;
                                }
                            }
                            //логическое условие для матрицы из 1 -го элл-та 
                            if (lenghtEl[1] == i && i > 0 && j != 0 && matrix1[i].Length == 1)
                            {
                                Console.SetCursorPosition(checker[1], i);
                                Console.Write($" {stringer[3]} ");
                                medianaLenghts[1] = $" {stringer[3]} ".Length;
                                counter[4]++;
                            }
                            //условие для матрицы из болшего кол -ва элл-в и длинны эл-та == 1||2||3 
                            if (j == 0 && matrix1[i].Length > 1)
                            {
                                switch (lenghtEl[2])
                                {
                                    case 1:
                                        Console.SetCursorPosition(checker[0], i);
                                        Console.Write($" |{matrix1[i][j]}  ");
                                        checkz[j] = $" |{matrix1[i][j]}  ".Length; break;
                                    case 2:
                                        Console.SetCursorPosition(checker[0], i);
                                        Console.Write($" |{matrix1[i][j]} ");
                                        checkz[j] = $" |{matrix1[i][j]} ".Length; break;
                                    case 3:
                                        Console.SetCursorPosition(checker[0], i);
                                        Console.Write($" |{matrix1[i][j]}");
                                        checkz[j] = $" |{matrix1[i][j]}".Length; break;
                                }

                            }
                            //условие для последовательного вывода на консоль всех элл-в
                            //кроме последнего элл -та матрицы  
                            if (j > 0 && j != matrix1[i].Length - 1 && matrix1[i].Length > 1)
                            {
                                switch (lenghtEl[2])
                                {
                                    case 1:
                                        Console.Write($"{matrix1[i][j]}  ");
                                        checkz[j] = $"{matrix1[i][j]}  ".Length; break;
                                    case 2:
                                        Console.Write($"{matrix1[i][j]} ");
                                        checkz[j] = $"{matrix1[i][j]} ".Length; break;
                                    case 3:
                                        Console.Write($"{matrix1[i][j]}");
                                        checkz[j] = $"{matrix1[i][j]}".Length; break;
                                }

                            }
                            //условие для  вывода на консоль последнего элл -та матрицы 
                            if (j > 0 && j == matrix1[i].Length - 1 && matrix1[i].Length > 1)
                            {
                                switch (lenghtEl[2])
                                {
                                    case 1:
                                        Console.Write($"  {matrix1[i][j]}|");
                                        checkz[j] = $"  {matrix1[i][j]}|".Length; break;
                                    case 2:
                                        Console.Write($" {matrix1[i][j]}|");
                                        checkz[j] = $" {matrix1[i][j]}|".Length; break;
                                    case 3:
                                        Console.Write($"{matrix1[i] [j]}|");
                                        checkz[j] = $"{matrix1[i][j]}|".Length; break;
                                }
                                if (lenghtEl[1] == i && i > 0 && j != 0 && matrix1.Length > 1)
                                {
                                    Console.SetCursorPosition(checker[1], i);
                                    Console.Write($" {stringer[3]} ");
                                    medianaLenghts[1] = $" {stringer[3]} ".Length;
                                    counter[4]++;
                                }
                            }
                            //логическое условие для матрицы из 1 -го элл-та
                            if (lenghtEl[1] == i  && matrix1.Length == 1 )// 1 строчный
                            {
                                checker[1] += checkz[j];

                                if (j == matrix1[i].Length - 1)
                                {
                                    checker[1] += checker[0];

                                    Console.SetCursorPosition(checker[1], i);
                                    Console.Write($" {stringer[3]} ");
                                    medianaLenghts[1] = $" {stringer[3]} ".Length;
                                    counter[4]++;
                                }
                                if (medianaLenghts[1] != 0 && counter[4] == 1)
                                {
                                    checker[2] += checker[1] + medianaLenghts[1]; counter[4]++;
                                }
                            }
                            //условие для подсчета длинны строк вывода элл-в матрицы
                            if (i == 0 && matrix1[i].Length > 1 && matrix1.Length != 1)
                            {
                                checker[1] += checkz[j];

                                if (j == matrix1[i].Length - 1)
                                {
                                    checker[1] += checker[0];
                                }
                            }
                            //условие в котором соблюдается единожды сложение длинны всех элементов строки
                            //для вычисления точки для курсора и последующего вывода на консоль элл-в других матриц
                            if (matrix1[i].Length > 1 && medianaLenghts[1] != 0 && counter[4] == 1)
                            {
                                checker[2] += checker[1] + medianaLenghts[1]; counter[4]++;
                            }

                        }

                    }

                    //вложенный цикл для вывода Матрицы c результатами вычислений == matrix2
                    for (int i = 0; i < matrix2.GetLength(0); i++)
                    {
                        //присвоил пременной значение 0 для обнуления при итерациях
                        //и последующего заполнения 
                        checker[3] = 0;
                        //медиана где должен быть знак =
                        lenghtEl[4] = matrix2.Length / 2;

                        for (int j = 0; j < matrix2.GetLength(1); j++)
                        {
                            //длинна элл-та
                            lenghtEl[3] = $"{matrix2[i,j]}".Length;
                            //логическое условие для матрицы из 1 -го элл-та
                            if (j == 0 && matrix2.GetLength(0) == 1)
                            {
                                switch (lenghtEl[3])
                                {
                                    case 1:
                                        Console.SetCursorPosition(checker[2], i);
                                        Console.Write($" |{matrix2[i, j]}|   ");
                                        checkz[j] = $" |{matrix2[i, j]}|   ".Length;
                                        checker[3] += checker[2] + checkz[j]; break;
                                    case 2:
                                        Console.SetCursorPosition(checker[2], i);
                                        Console.Write($" |{matrix2[i, j]}|  ");
                                        checkz[j] = $" |{matrix2[i, j]}|  ".Length;
                                        checker[3] += checker[2] + checkz[j]; break;
                                    case 3:
                                        Console.SetCursorPosition(checker[2], i);
                                        Console.Write($" |{matrix2[i, j]}| ");
                                        checkz[j] = $" |{matrix2[i, j]}| ".Length;
                                        checker[3] += checker[2] + checkz[j]; break;
                                }

                            }
                            //условие для матрицы из болшего кол -ва элл-в и длинны эл-та == 1||2||3 
                            if (j == 0 && matrix2.GetLength(0) > 1)
                            {
                                switch (lenghtEl[3])
                                {
                                    case 1:
                                        Console.SetCursorPosition(checker[2], i);
                                        Console.Write($" |{matrix2[i, j]}   ");
                                        checkz[j] = $" |{matrix2[i, j]}   ".Length;
                                        checker[3] += checker[2] + checkz[j]; break;
                                    case 2:
                                        Console.SetCursorPosition(checker[2], i);
                                        Console.Write($" |{matrix2[i, j]}  ");
                                        checkz[j] = $" |{matrix2[i, j]}  ".Length;
                                        checker[3] += checker[2]+checkz[j]; break;
                                    case 3:
                                        Console.SetCursorPosition(checker[2], i);
                                        Console.Write($" |{matrix2[i, j]} ");
                                        checkz[j] = $" |{matrix2[i, j]} ".Length;
                                        checker[3] += checker[2] + checkz[j]; break;
                                }

                            }
                            //условие для последовательного вывода на консоль всех элл-в
                            //кроме последнего элл -та матрицы 
                            if (j > 0 && j != matrix2.GetLength(1) - 1 && matrix2.GetLength(1) > 1)
                            {
                                switch (lenghtEl[3])
                                {
                                    case 1:
                                        Console.SetCursorPosition(checker[3], i);
                                        Console.Write($"{matrix2[i, j]}   ");
                                        checkz[j] = $"{matrix2[i, j]}   ".Length;
                                        checker[3] += checkz[j]; break;
                                        
                                    case 2:
                                        Console.SetCursorPosition(checker[3], i);
                                        Console.Write($"{matrix2[i, j]}  ");
                                        checkz[j] = $"{matrix2[i, j]}  ".Length;
                                        checker[3] += checkz[j]; break;
                                    case 3:
                                        Console.SetCursorPosition(checker[3], i);
                                        Console.Write($"{matrix2[i, j]} ");
                                        checkz[j] = $"{matrix2[i, j]} ".Length;
                                        checker[3] += checkz[j]; break;
                                }

                            }
                            //условие для  вывода на консоль последнего элл -та матрицы
                            if (j > 0 && j == matrix2.GetLength(1) - 1 && matrix2.GetLength(1) > 1)
                            {
                                switch (lenghtEl[3])
                                {
                                    case 1:
                                        Console.SetCursorPosition(checker[3], i);
                                        Console.Write($"  {matrix2[i, j]}|");
                                        checkz[j] = $"  {matrix2[i, j]}|".Length; break;
                                    case 2:
                                        Console.SetCursorPosition(checker[3], i);
                                        Console.Write($" {matrix2[i, j]}|");
                                        checkz[j] = $" {matrix2[i, j]}|".Length; break;
                                    case 3:
                                        Console.SetCursorPosition(checker[3], i);
                                        Console.Write($"{matrix2[i, j]}|");
                                        checkz[j] = $"{matrix2[i, j]}|".Length; break;
                                }

                            }
                        }

                        Console.WriteLine();
                    }

                    Console.ReadKey();
                }
            }
            #endregion
        }
    }

}