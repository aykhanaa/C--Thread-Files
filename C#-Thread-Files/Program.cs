
//void Methot1()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine("Method1 - " + i);
//    }
//}
//void Methot2()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine("Method2 - " + i);
//    }
//}

//void Methot3()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine("Method3 - " + i);
//    }
//}


//Thread thread1 = new Thread(Methot1);

//Thread thread2 = new Thread(Methot2);

//thread1.Start();

//Methot3();

//thread2.Start();

//C:\\Users\\Hp\\Desktop\\C#-Thread\\file1.txt

using C__Thread_Files;
using C__Thread_Files.Controllers;

//ExampleFile file = new ExampleFile();

//file.WriteToFile("C:\\Users\\Hp\\Desktop\\C#-Thread\\file2.txt","Salam Xaker bey");

//file.WriteToFile("C:\\Users\\Hp\\Desktop\\C#-Thread\\file3.txt", "Salam Beyruz bey");

//file.ReadFromFile("C:\\Users\\Hp\\Desktop\\C#-Thread\\file2.txt");

//file.WriteToNewFile("C:\\Users\\Hp\\Desktop\\C#-Thread\\file6.txt", "Necesiz Nesir bey");

//file.WriteToNewFile(d, "Necesiz Ayxan bey");

FileController fileController = new FileController();

//await fileController.ReadDataAsync();

await fileController.CreatFileWithContentAsync();

//await fileController.DeleteAsync();