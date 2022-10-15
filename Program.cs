void PrintArray (string [] ar){
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar[i]}| ");
    }
    Console.WriteLine();
}

int ArrayDimensionCalculation(string [] str){
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3){
            count++;
        }
    }
    return count;
}

String [] Sample3 (string [] str){
    String [] StrResult = new String [ArrayDimensionCalculation(str)];
    for (int i = 0, j = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3){
            StrResult[j] = str[i];
            j++;
        }
    }
    return StrResult;
}


String [] StrArray = {"text","tex", "te","Kolia", "T", "В лесу родилась ёлочка"
                                ,"15987Э", "qwe","18", "мне", "уже", "qwer", "я"};

String [] StrArrayResult = Sample3(StrArray);
PrintArray(StrArrayResult);


