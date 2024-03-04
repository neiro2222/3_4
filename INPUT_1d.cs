using System;
sealed class INPUT_1d<T>{
    private Random random;
    private T[] a;

    public INPUT_1d(int size) {
        random = new Random();
        a = new T[size];
    }

    public void Generate_Random()
    {
        if (typeof(T) == typeof(int)) {
            Int_input(true);
        } else if (typeof(T) == typeof(double)) {
            Double_input(true);
        } else if (typeof(T) == typeof(bool)) {
            Bool_input(true);
        } else {
            String_input(true);
        }
    }

    private void Int_input(bool flag) {
        for (int i = 0; i < a.Length; i++) {
            dynamic value;
            if (flag) {
                value = random.Next();
            } else {
                value = int.Parse(Console.ReadLine());
            }
            a[i] = value;
        }
    }

    private void Double_input(bool flag) {
        for (int i = 0; i < a.Length; i++) {
            dynamic value;
            if (flag) {
                value = random.NextDouble();
            } else {
                value = double.Parse(Console.ReadLine());
            }
            a[i] = value;
        }
    }

    private void Bool_input(bool flag) {
        for (int i = 0; i < a.Length; i++) {
            int value;
            dynamic value1;
            if (flag) {
                value = random.Next(0, 1);
                if (value == 0) {
                    value1 = false;
                } else {
                    value1  = true;
                }
            } else {
                value1 = bool.Parse(Console.ReadLine());
            }
            a[i] = value1;
        }
    }

    private void String_input(bool flag) {
        for (int i = 0; i < a.Length; i++) {
            dynamic value;
            if (flag) {
                value = new Random(Guid.NewGuid().GetHashCode());
            } else {
                value = Console.ReadLine();
            }
            a[i] = value;
        }
    }

    public void Generate_Key()
    {
        dynamic value;
        if (typeof(T) == typeof(int)) {
            Int_input(false);
        } else if (typeof(T) == typeof(double)) {
            Double_input(false);
        } else if (typeof(T) == typeof(bool)) {
            Bool_input(false);
        } else {
            String_input(false);
        }
    }

    public T[] GET() {
        return a;
    }
}