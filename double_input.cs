using System;
sealed class double_input{
    private Random random = new Random();

    public double Generate_Random() {
        return random.NextDouble();
    }

    public double Generate_Key() {
        return double.Parse(Console.ReadLine());
    }
}