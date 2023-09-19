# Inheritance_Virtual_Abstract
## C# Override Kullanım Kuralları
- Static ve Final olarak tanımlanmış metot yapıları override edilemez.
- Override işlemini uyguladığımız metodun erişim belirleyicisinin seviyesini düşüremeyiz fakat yükseltebiliriz.
- Üst sınıftan miras alınan bir metodun dönüş tipi veya parametrelerini değiştiremeyiz.
- Üst sınıf içerisinde yer alan private metotlar override işlemine tabi tutulmaz.
- Constructor (Kurucu / Yapıcı) metotlar override edilemez.
- Üst sınıfımızda yer alan ve alt sınıfımızda yer alacak override işlemi uygulayacağımız metot isimleri aynı olmalıdır.
- Override edeceğimiz metodu belirlerken virtual ve override anahtar sözcüklerini kullanmamız gerekiyor.

  ## Bilgi: Virtual olarak belirtilen metot yapıları kalıtım yolu ile aktarıldıkları sınıfların içerisinde override edilerek değiştirilebilirler. Eğer override işlemi uygulanmazsa üst sınıf içerisindeki yapısını koruyarak çalışmaya devam eder.

## Kod kalabalığını arttırmamak ve konuyu daha anlaşılır bir şekilde anlatmak için; sınıfları karışıklığa yer vermeyecek şekilde isimlendirip, konumuzun dışında olan kod satırlarına/bloklarına yer vermemeye çalışacağım.

  Örnek bir senaryo üzerinden gidecek olursak; User (kullanıcı), Category (kategori) ve Article (Makale) isimli sınıflarımızın olduğunu ve bu sınıfların Database sınıfından türetildiğini düşünelim.

public class Database
{
    public void Insert(string data)
    {
        Console.WriteLine("{0} Kaydedildi.", data);
    }
}
public class User : Database
{
}
public class Category : Database
{
}
public class Article : Database
{
}
Database sınıfı içerisindeki Insert() metodu kalıtım yolu ile User, Category ve Article sınıflarına aktarılacaktır.

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        user.Insert("Serdar_Yilmaz");
        Category category = new Category();
        category.Insert("Programlama");
        Article article = new Article();
        article.Insert("C# - Virtual Metotlar");
    }
}
Yukarıdaki konsol uygulamasının ekran çıktısı;

Serdar_Yilmaz Kaydedildi.
Programlama Kaydedildi.
C# - Virtual Metotlar Kaydedildi.
Press any key to continue . . .
Ancak biz User sınıfında Insert() metodunun kullanıcı adı kontrolü yaptıktan sonra veriyi kaydetmesini istiyor olabiliriz. Temel sınıf içerisindeki bir metodun gövdesini türetilmiş sınıflar içerisinde değiştirebilmek için Temel sınıf içerisindeki metodu virtual olarak tanımlamamız gerekir.

public class Database
{
    public virtual void Insert(string data)
    {
        Console.WriteLine("{0} Kaydedildi.", data);
    }
}
public class User : Database
{
    public override void Insert(string data)
    {
        if (data=="Serdar_Yilmaz")
        {
            Console.WriteLine("{0} Zaten Kayıtlı.", data);
        }
        else
        {
            base.Insert(data);
        }
    }
}
public class Category : Database
{
}
public class Article : Database
{
}
Database sınıfı içerisindeki Insert() metodu virtual olarak belirtildiği için User sınıfı içerisinde override edilerek gövdesi değiştirildi. override edilmiş bir metot içerisinden metodun orijinalini (temel sınıf içerisindeki halini) çağırabilmek için base anahtar sözcüğü kullanılır.

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        user.Insert("Serdar_Yilmaz");
        Category category = new Category();
        category.Insert("Programlama");
        Article article = new Article();
        article.Insert("C# - Virtual Metotlar");
    }
}
Konsol uygulamamızı tekrar çalıştıracak olursak ekran çıktısı aşağıdaki gibi olacaktır.
