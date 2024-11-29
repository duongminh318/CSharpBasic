using System.IO;

// Ghi toàn bộ text vào file
File.WriteAllText("example.txt", "Hello, File!");

// Đọc toàn bộ nội dung từ file
string content = File.ReadAllText("example.txt");
Console.WriteLine(content);

// Ghi file theo dòng
using (StreamWriter writer = new StreamWriter("example.txt"))
{
    writer.WriteLine("Line 1");
    writer.WriteLine("Line 2");
}

// Đọc file theo dòng
using (StreamReader reader = new StreamReader("example.txt"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

// Ghi dữ liệu nhị phân
using (FileStream fs = new FileStream("example.bin", FileMode.Create))
{
    byte[] data = { 1, 2, 3, 4, 5 };
    fs.Write(data, 0, data.Length);
}

// Đọc dữ liệu nhị phân
using (FileStream fs = new FileStream("example.bin", FileMode.Open))
{
    byte[] data = new byte[fs.Length];
    fs.Read(data, 0, data.Length);
    Console.WriteLine(string.Join(", ", data));
}


// Ghi dữ liệu nhị phân
using (BinaryWriter writer = new BinaryWriter(File.Open("example.dat", FileMode.Create)))
{
    writer.Write(123);    // Ghi số nguyên
    writer.Write(45.67);  // Ghi số thực
    writer.Write("Hello"); // Ghi chuỗi
}

// Đọc dữ liệu nhị phân
using (BinaryReader reader = new BinaryReader(File.Open("example.dat", FileMode.Open)))
{
    int number = reader.ReadInt32();
    double value = reader.ReadDouble();
    string text = reader.ReadString();

    Console.WriteLine($"{number}, {value}, {text}");
}


string folderPath = "TestDirectory";

// Tạo thư mục nếu chưa tồn tại
if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine($"Thư mục '{folderPath}' đã được tạo.");
}
else
{
    Console.WriteLine($"Thư mục '{folderPath}' đã tồn tại.");
}

// Xóa thư mục
if (Directory.Exists(folderPath))
{
    Directory.Delete(folderPath, true); // Tham số `true` để xóa thư mục kèm nội dung bên trong
    Console.WriteLine($"Thư mục '{folderPath}' đã được xóa.");
}
else
{
    Console.WriteLine($"Thư mục '{folderPath}' không tồn tại.");
}

string[] files = Directory.GetFiles("TestDirectory");
foreach (string file in files)
{
    Console.WriteLine($"File: {file}");
}

string[] subDirs = Directory.GetDirectories("TestDirectory");
foreach (string dir in subDirs)
{
    Console.WriteLine($"Thư mục con: {dir}");
}

string sourceDir = "TestDirectory";
string destDir = "NewDirectory";

if (Directory.Exists(sourceDir))
{
    Directory.Move(sourceDir, destDir);
    Console.WriteLine($"Đã di chuyển thư mục từ '{sourceDir}' đến '{destDir}'.");
}

DirectoryInfo dirInfo = new DirectoryInfo("TestDirectory");
if (!dirInfo.Exists)
{
    dirInfo.Create();
    Console.WriteLine($"Thư mục '{dirInfo.FullName}' đã được tạo.");
}
if (dirInfo.Exists)
{
    Console.WriteLine($"Tên thư mục: {dirInfo.Name}");
    Console.WriteLine($"Đường dẫn đầy đủ: {dirInfo.FullName}");
    Console.WriteLine($"Thời gian tạo: {dirInfo.CreationTime}");
}

FileInfo[] files1 = dirInfo.GetFiles();
foreach (FileInfo file in files1)
{
    Console.WriteLine($"File: {file.Name} - Kích thước: {file.Length} bytes");
}


string rootDir = "RootDirectory";
string[] subDirs1 = { "SubDir1", "SubDir2", "SubDir3" };

Directory.CreateDirectory(rootDir);
foreach (string subDir in subDirs1)
{
    Directory.CreateDirectory(Path.Combine(rootDir, subDir));
}
Console.WriteLine("Cây thư mục đã được tạo.");
