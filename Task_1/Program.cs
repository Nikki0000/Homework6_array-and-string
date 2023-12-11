// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.



string GetStringFromCharArray(char [,] chars) {
    string res = "";
    
    //поочередный перебор элементов массива, без индексации. С каждым элементом массива chars мы что то делаем
    foreach (char elem in chars) {
        res += elem;
    }

    return res;
}

void Show2dArray(char [,] chars) {
    for (int i = 0; i < chars.GetLength(0); i++) {
        for (int j = 0; j < chars.GetLength(1); j++) {
            Console.Write(chars[i, j] + " ");
        }
        Console.WriteLine();
    }
}



char [,] chars = {
    {'a', 'b', 'c', 'd'},
    {'e', 'f', 'g', 'h'}
};
Show2dArray(chars);
Console.WriteLine();
string str = GetStringFromCharArray(chars);
Console.WriteLine(str);
