// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

string ClearString (string str) {
    string res = str.ToLower();
    string count = "";

    foreach(char elem in res) {
        if (elem != ' ') {
            count += elem;
        }
    }

    return count;
}

void PalendromString (string str) {
     
    int count = str.Length;
    bool flag = false;

    for (int i = 0; i < count/2; i++) {
        if (str[i] == str[count - i - 1]) {
            flag = true;
        } else {
            flag = false;
            break;
        }
    }

    if (flag) {
        Console.WriteLine($"Строка {str} является палендромом");
    } else {
        Console.WriteLine($"Строка {str} не является палендромом");
    }
}

string str = "t   aa      t";
string res = ClearString(str);
Console.WriteLine(res);
PalendromString(res);