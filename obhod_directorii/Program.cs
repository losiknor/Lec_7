// Посмотреть и запомнить информацию о файлах, хранящихся в директории.
// string path = "C:/_moi/GB/Знакомство с языками программирования/Лекции/Lec_7/perebor_bukv";
// DirectoryInfo di = new DirectoryInfo(path); System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();
// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }
// Обход каталога с рекурсией
void CatalogInfo(string path, string ident = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{ident}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, ident + " ");
    }
    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{ident}{files[i].Name}");
    }
}
string path = @"C:/_moi/Б А Р Д Ы";
CatalogInfo(path);