Console.WriteLine("Напишите путь к файлу"); //C:\\laba\12.txt
string path = Console.ReadLine();
string path1 = Directory.GetCurrentDirectory();//получение путя к текущей папке 
if (File.Exists(path))//проверка существует ли файл
{
    string text = File.ReadAllText(path);//считывает текст
    File.WriteAllText(path1 + "\\199.txt", text);//пишет текст
    Console.WriteLine("готова");
    Console.WriteLine(path1 + "\\199.txt");
}
else
{
    Console.WriteLine("ошибка");
}
  
