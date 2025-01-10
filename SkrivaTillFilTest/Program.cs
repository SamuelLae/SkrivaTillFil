FileStream fs = new FileStream("FilePath.txt", FileMode.Open, FileAccess.Read);

StreamReader reader = new (fs);

string fileContent = reader.ReadToEnd();

reader.Close();

Console.WriteLine(fileContent);