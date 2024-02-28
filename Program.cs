using System;
class HelloWorld {
  static void Main() {
    
    IArray[] base_Array  = new IArray[2];
    
    Console.WriteLine("Введите false, если хотите случайный ввод, иначе введите true");


    bool flag = bool.Parse(Console.ReadLine());
    
    base_Array[0] = new D1_arrays(flag, "string");     
    base_Array[1] = new D2_arrays(flag);
  

    for (int i = 0; i < base_Array.Length; i++) {
      base_Array[i].Print();
    }
    
    base_Array[0].Change(flag);
    base_Array[0].Print();

    IPrinter[] printer = new IPrinter[3];

    printer[0] = base_Array[0];     
    printer[1] = base_Array[1];
    printer[2] = new data();

    for (int i = 0; i < printer.Length; i++) {
      printer[i].Print();
    }
  }
}
