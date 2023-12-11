// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.



string ReverseString (string str) {

    string currentWord = "";
    string reversedString = "";


    for (int i = 0; i < str.Length; i++) {
        if (str[i] != ' ') {
            currentWord += str[i];
        } else {
            reversedString = currentWord + ' ' + reversedString;
            currentWord = "";
        }
        
    }
    
    reversedString = currentWord + ' ' + reversedString;

    return reversedString;
}


string str = "hello my world";
string res = ReverseString(str);
Console.WriteLine(res);