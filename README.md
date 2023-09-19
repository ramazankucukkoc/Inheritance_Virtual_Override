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

![image](https://github.com/ramazankucukkoc/Inheritance_Virtual_Override/assets/79471806/257b949e-8e3e-4be8-bac7-51cf4f0faa14)
![image](https://github.com/ramazankucukkoc/Inheritance_Virtual_Override/assets/79471806/221a4772-4449-4974-b674-b0f533dd357f)
![image](https://github.com/ramazankucukkoc/Inheritance_Virtual_Override/assets/79471806/2b8ce16d-064a-43a3-abe6-8c0f045d77cc)
![image](https://github.com/ramazankucukkoc/Inheritance_Virtual_Override/assets/79471806/a03b4a76-4dd3-4c9e-98dd-4489f16777d3)


Kaynaklar : https://www.srdrylmz.com/c-virtual-metotlar/

