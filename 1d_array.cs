using System;
sealed class D1_arrays<T> : Base_array{
    private T[] a;
    private elemenent_gen<T> _element_gen;
    public D1_arrays(bool flag, elemenent_gen<T> Element_gen) {
        _element_gen = Element_gen;
        Create_array(flag);
    }

    public override void Create_array(bool flag) {
        Console.WriteLine("Введите размер массива : ");
        int n = int.Parse(Console.ReadLine());
        a = new T[n];
        for (int i = 0; i < n; i++) {
            if (flag) {
                a[i] = _element_gen.Generate_Random();
            } else {
                a[i] = _element_gen.Generate_Key();
            }
        }
    }    

    // public T GenerateValue(bool flag)
    // {
    //     dynamic value;

    //     if (typeof(T) == typeof(int))
    //     {
    //         int_input val = new int_input();
    //         if (flag) {
    //             val.Generate_Random();
    //         } else {
    //             val.Generate_Key();
    //         }
    //         value = val;
    //     }
    //     else if (typeof(T) == typeof(double))
    //     {
    //         double_input val = new double_input();
    //         if (flag) {
    //             val.Generate_Random();
    //         } else {
    //             val.Generate_Key();
    //         }
    //         value = val;
    //     }
    //     else if (typeof(T) == typeof(bool))
    //     {
    //         bool_input val = new bool_input();
    //         if (flag) {
    //             val.Generate_Random();
    //         } else {
    //             val.Generate_Key();
    //         }
    //         value = val;
    //     }
    //     else
    //     {
    //         string_input val = new string_input();
    //         if (flag) {
    //             val.Generate_Random();
    //         } else {
    //             val.Generate_Key();
    //         }
    //         value = val;
    //     }

    //     return value;
    // }

    public override void Change(bool flag) {
        Console.WriteLine("Массив изменен");
        Create_array(flag);
    }
    
    public override void Print() {
        Console.WriteLine("Одномерный массив");
        Console.WriteLine("Выводится размер и содержимое массива : ");
        Console.WriteLine(a.Length);
        for (int i = 0; i < a.Length; i++) {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine();
    }
}