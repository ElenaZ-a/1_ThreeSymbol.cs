using System;

namespace ThreeSymbols
{
    
    class ThreeSymbols
    {
    // Инициализация массива строк
        static string [] Strings = { "One", "Two", "Three", "Four", "Five", "-:)"}; // массив строк
       

static string [] ThreeSymbolStrings(string [] strings){// функция которая обрабатывает массив строк и возвращает только с длиной <=3
    string [] StrOut;  //выходной массив строк длиной не больше 3
    string [] temp = new string [strings.Length];
    int size = 0; //Размер нового массива строк
    foreach (string str in strings){ // цикл по всем строкам в массиве строк
        if (str.Length <= 3) {// если длина не больше 3 то
            temp[size]= str; //добавить строку в выходной массив
            size++;   
        }
    }
    StrOut = new string [size];
    for (int i = 0; i<size; i++){
        StrOut[i]=  temp[i];
    }
    return StrOut; // функция возвращает массив строк длиной не больше 3 символа
}

static void PrintStrings(string [] strings, string ends){// функция печати строк
    Console.Write("[");
    for (int i = 0; i<strings.Length; i++){
        Console.Write(strings[i]);
        if (i<strings.Length-1){
            Console.Write(",");
        }
    }
    Console.Write("]");
    Console.Write(ends);
}

        static void Main(string[] args)
        {
            Console.Clear();
            PrintStrings(Strings,"->");
            PrintStrings(ThreeSymbolStrings(Strings),"\n");
        }   
    }
}

