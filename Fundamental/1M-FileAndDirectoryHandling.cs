using System;
using System.IO;

class FileAndDirectory
{
    public void Learnfiles()
    {
        //Create a Text file containing text "Hello World!"
        // @ = Verbating Character
        var folderPath = @"E:\ASP.net\Rajantamang\Fundamental\TestFiles";    // here \ is special character so it escape squence
        var fullFilepath = $"{folderPath}/test.txt ";
        File.WriteAllText(fullFilepath, "Hello World!");

        var folder = $"{folderPath}/New Folder ";
        Directory.CreateDirectory(folder);
        Directory.Delete(folder);

        // Create a folder with name "A" somewhere and create a text file a.file inside "A"
    }

    public void NewFolderAndFile()
    {
        var NewPath = @"E:\ASP.net\Rajantamang\Fundamental\TestFiles";
        //var FolderA= $"{NewPath}/A";
        // Directory.CreateDirectory(FolderA);
        // var filea = $"{FolderA}\\a.file";
        // File.WriteAllText(filea, "A");

        // Create a folders with names Folder 1, Folder 2, Folder 3....Folder 10.
        for (int i = 1; i <= 10; i++)
        {
            string foldername = "Folder" +i;
            string path = $"{NewPath}\\" + foldername;
            //Directory.CreateDirectory(path);
            Directory.Delete(path);

        }



        //Create 20 folders A, B, C, ... T. In each folder there should be a file with name same as its parent folder 
        //and that file should contain current datetime stamp.
    }
    public void Folders()
    {
        var NewPath = @"E:\ASP.net\Rajantamang\Fundamental\TestFiles";
        for (char Letter = 'A'; Letter <= 'T'; Letter++)
        {
            string folderName = Letter.ToString();
            string path1 = $"{NewPath}\\"+ folderName;
            Directory.CreateDirectory(path1);
            //Directory.Delete(path1);
            string filename= $"{path1}\\" + ".txt";
            File.WriteAllText(filename, DateTime.Now.ToString());

        }

    }

}
