using System;
sealed class D1_arrays<T> : Base_array{
    private T[] a;
    
    public D1_arrays(bool flag) {
        Create_array(flag);
    }

    public override void Create_array(bool flag) {
        Console.WriteLine("Введите размер массива : ");
        int n = int.Parse(Console.ReadLine());
        a = new T[n];
        INPUT_1d<T> array = new INPUT_1d<T>(n);
        if (flag) {
            array.Generate_Random();
        } else {
            array.Generate_Key();
        }
        a = array.GET();
    }    
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