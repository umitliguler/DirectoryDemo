##  DirectoryDemo
# Klasörler oluşturup,  dizin taşıma işlemleri, oluşturulma zamanlarını belirleme


Adres ile belirtilen adreste bir klasör oluşturur ve bu klasör bilgilerini bir DirectoryInfo nesnesi olarak tutar.

Programımızın çalıştığı klasörde bir klasör oluşturmak için sadece klasörün adını yazmak yeterlidir. 

Örnekler:

```Directory.CreateDirectory(@"C:\WINDOWS\deneme");```

Bu kod C:\WINDOWS altında deneme isimli bir klasör oluşturur.

```Directory.CreateDirectory("deneme");```

Bu kod programın çalıştığı klasörde deneme isimli bir klasör oluşturur.

```Directory.CreateDirectory(@"..\deneme");```

Bu kod programın çalıştığı klasörün bir üst klasöründe deneme isimli bir klasör oluşturur.

```Directory.CreateDirectory(@"..\..\deneme");```

Bu kod programın çalıştığı klasörün iki üst klasöründe deneme isimli bir klasör oluşturur. .. sayıları bu şekilde artırılabilir.

Bu tür bir adres belirtme şekli bütün diğer metotlarda da geçerlidir.

Ayrıca bu ve diğer bütün metotlarda da adres diye tarif ettiğimiz veriye dosya/klasörün adı da dâhildir.

-----------------------------------------------------------------------------------------------------------------------------------
```string adres=@"C:\deneme";

DirectoryInfo d=new DirectoryInfo(adres);

d.Create();

DirectoryInfo alt=d.CreateSubdirectory("deneme2");

alt.CreateSubdirectory("deneme3");```

-----------------------------------------------------------------------------------------------------------------------------------
```using System;

using System.IO;

class FileInfoSinifi
{
   static void Main()
   {
      string adres=@"C:\WINDOWS\deneme.txt";
      FileInfo d=new FileInfo(adres);
      Console.WriteLine("Öznitelikler: "+d.Attributes);
      Console.WriteLine("Oluşturulma tarihi: "+d.CreationTime);
      Console.WriteLine("Var mı? "+d.Exists);
      Console.WriteLine("Uzantı: "+d.Extension);
      Console.WriteLine("Tam adres: "+d.FullName);
      Console.WriteLine("Son erişim zamanı: "+d.LastAccessTime);
      Console.WriteLine("Son değişiklik zamanı: "+d.LastWriteTime);
      Console.WriteLine("Boyut: "+d.Length);
      Console.WriteLine("Klasör adı: "+d.Name);
      Console.WriteLine("Bulunduğu klasör: "+d.DirectoryName);
   }
}```
------------------------------------------------------------------------------------------------------------------------------

```using System;
using System.IO;
class PathSinifi
{
   static void Main()
   {
      string adres=@"C:\dizin\deneme.txt";
      Console.WriteLine("Uzantı: "+Path.GetExtension(adres));
      string yeniAdres=Path.ChangeExtension(adres,"jpg");
      Console.WriteLine("Yeni uzantı: "+Path.GetExtension(yeniAdres));
      string adres2=@"C:\klasör";
      Console.WriteLine("Yeni adres: "+Path.Combine(adres,adres2));
      Console.WriteLine("Klasör: "+Path.GetDirectoryName(adres));
      Console.WriteLine("Dosya adı: "+Path.GetFileName(adres));
      Console.WriteLine("Uzantısız dosya adı: "+Path.GetFileNameWithoutExtension(adres));
      Console.WriteLine("Tam adres: "+Path.GetFullPath(adres));
      Console.WriteLine("Kök dizin: "+Path.GetPathRoot(adres));
      Console.WriteLine("Geçici dosya adı: "+Path.GetTempFileName());
      Console.WriteLine("Geçici dosya dizini: "+Path.GetTempPath());
      Console.WriteLine("Dosya uzantısı var mı? "+Path.HasExtension(adres));
      Console.WriteLine("Alt dizin ayıracı: "+Path.AltDirectorySeparatorChar);
      Console.WriteLine("Dizin ayıracı: "+Path.DirectorySeparatorChar);
      Console.Write("Geçersiz dosya adı karakterleri: ");
      char[] dizi=Path.GetInvalidFileNameChars();
      foreach(char b in dizi)
         Console.Write(b+" ");
      Console.Write("\nGeçersiz adres karakterleri: ");
      char[] dizi2=Path.GetInvalidPathChars();
      foreach(char b in dizi)
         Console.Write(b+" ");
      Console.WriteLine("\nAdres ayırıcı karakter: "+Path.PathSeparator);
      Console.WriteLine("Kök dizin ayıracı: "+Path.VolumeSeparatorChar);
   }
}```


@umitliguler :+1: This PR looks great - it's ready to using! :shipit:
