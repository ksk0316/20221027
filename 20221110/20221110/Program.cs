using System.Collections.Generic;
// ハンズオン13
//Console.WriteLine("体重を入力してください(kg)");
//double weight = 0;
//bool parseSuccess = false;
//while (!parseSuccess)
//{
//    string userWeight = Console.ReadLine() ?? "";

//    try
//    {
//        weight = double.Parse(userWeight);
//        parseSuccess = true;
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("数値を入力してください");
//    }
//}
//Console.WriteLine("体重は" + weight.ToString("F2") + "です。");

//Console.WriteLine("身長を入力してください(m)");
//double height = 0;
//parseSuccess = false;
//while (!parseSuccess)
//{
//    string userHeight = Console.ReadLine() ?? "";

//    try
//    {
//        height = double.Parse(userHeight);
//        parseSuccess = true;
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("数値を入力してください");
//    }
//}
//Console.WriteLine("身長は" + height.ToString("F2") + "です。");

//double bmi = weight / (height * height);
//Console.WriteLine("BMIは" + bmi.ToString("F4") + "です。");
// ハンズオン14
//Console.WriteLine("体重を入力してください(kg)");
//double weight = 0;
//bool parseSuccess = false;
//while (!parseSuccess)
//{
//    string userWeight = Console.ReadLine() ?? "";
//    parseSuccess = double.TryParse(userWeight, out weight);

//    if (!parseSuccess)
//        Console.WriteLine("数値を入力してください");
//}
//Console.WriteLine("体重は" + weight.ToString("F2") + "です。");

//Console.WriteLine("身長を入力してください(m)");
//double height = 0;
//parseSuccess = false;
//while (!parseSuccess)
//{
//    string userHeight = Console.ReadLine() ?? "";
//    parseSuccess = double.TryParse(userHeight, out height);

//    if (!parseSuccess)
//        Console.WriteLine("数値を入力してください");
//}
//Console.WriteLine("身長は" + height.ToString("F2") + "です。");

//double bmi = weight / (height * height);
//Console.WriteLine("BMIは" + bmi.ToString("F4") + "です。");
//ハンズオン15
int[] intArray = new int[] { 8574, 53589, 242, 145, 44535, 34 };
int int_max = int.MinValue;
int int_min = int.MaxValue;
int sum = 0;
for (int i = 0; i < intArray.Length; i++)
{
    if (int_max < intArray[i]) { 
        int_max = intArray[i];
    }
    if(int_min > intArray[i]){
        int_min = intArray[i];
    }
    sum += intArray[i];
}
Console.WriteLine("最大値" + int_max);
Console.WriteLine("最小値" + int_min);
Console.WriteLine("合計値" + sum);
sum /= intArray.Length;
Console.WriteLine("平均値" + sum);
