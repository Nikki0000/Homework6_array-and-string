// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.




string StringToLower(string str) {
    string res = str.ToLower();
    return res;
}

string str = "SgffSRfrSrGG";
string res = StringToLower(str);
Console.WriteLine(res);