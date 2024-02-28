using System;
sealed class D1_arrays : Base_array{
    private int[] a;
    private string type;
    
    public D1_arrays(bool flag, string Type) {
        type = Type;
        Create_array(flag);
    }

    public override void Create_array(bool flag) {
        Console.WriteLine("Введите размер массива : ");
        int n = int.Parse(Console.ReadLine());
        a = new int[n];
        if (flag) {
            _Key_init();
        } else {
            _Random_init();
        }
    }
    
    public override void Change(bool flag) {
        Console.WriteLine("Массив изменен");
        Create_array(flag);
    }
    
    protected override void _Key_init() {
        Console.WriteLine("Введите элементы массива :");
        for (int i = 0; i < a.Length; i++) {
            a[i] = int.Parse(Console.ReadLine());
        }
    }

    protected override void _Random_init() {
        Console.WriteLine("Массив вводится случайно");
        Random rnd = new Random();
        for (int i = 0; i < a.Length; i++) {
            a[i] = rnd.Next(200);
        }
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