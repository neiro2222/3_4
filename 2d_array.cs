using System;
sealed class D2_arrays<T> : Base_array{
    private T[,] array;
    public D2_arrays(bool flag) {
        Create_array(flag);
    }
    public override void Create_array(bool flag) {
        Console.WriteLine("Введите размеры двумерного массива : ");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        array = new T[n, m];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                array[i, j] = GenerateValue(flag);
            }
        }
    }
    
    public T GenerateValue(bool flag)
    {
        dynamic value;

        if (typeof(T) == typeof(int))
        {
            int_input val = new int_input();
            if (flag) {
                val.Generate_Random();
            } else {
                val.Generate_Key();
            }
            value = val;
        }
        else if (typeof(T) == typeof(double))
        {
            double_input val = new double_input();
            if (flag) {
                val.Generate_Random();
            } else {
                val.Generate_Key();
            }
            value = val;
        }
        else if (typeof(T) == typeof(bool))
        {
            bool_input val = new bool_input();
            if (flag) {
                val.Generate_Random();
            } else {
                val.Generate_Key();
            }
            value = val;
        }
        else
        {
            string_input val = new string_input();
            if (flag) {
                val.Generate_Random();
            } else {
                val.Generate_Key();
            }
            value = val;
        }

        return value;
    }
    public override void Change(bool flag) {
        Console.WriteLine("Массив изменен");
        Create_array(flag);
    }


    public override void Print() {
        Console.WriteLine("Двумерный массив");
        Console.WriteLine("Выводится размеры и содержимое массива : ");
        Console.Write($"{array.GetLength(0)} ");
        Console.Write(array.GetLength(1));
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}