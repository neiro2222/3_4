using System;
sealed class string_input{
    private Random random = new Random();

    public string Generate_Random() {
        dynamic value = new Random(Guid.NewGuid().GetHashCode());
        return value;
    }

    public string Generate_Key() {
        return Console.ReadLine();
    }
}