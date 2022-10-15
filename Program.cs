void PrintArray (string [] ar){
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar[i]} ");
    }
    Console.WriteLine();
}

String [] Sample3 (string [] str){
    String [] StrResult = new string [str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3){
            StrResult[i] = str[i];
        }
    }
    return StrResult;
}

String [] StrArray = {"text","tex", "te", "t"};
PrintArray(Sample3(StrArray));


