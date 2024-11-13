# Öğrenci ve Sınıflar Projesi

Bu proje, öğrenciler ve sınıflar arasındaki ilişkiyi temsil eden basit bir C# konsol uygulamasıdır. LINQ kullanılarak öğrencilerin sınıflarla eşleştirilmesi sağlanır ve her sınıfa ait öğrenciler listelenerek konsola yazdırılır.

## Proje Yapısı

- **Students**: Öğrencileri temsil eden sınıf. Her öğrencinin benzersiz bir `StudentId` kimliği, bir `StudentName` (öğrenci adı) ve bir `ClassId` (sınıf kimliği) özelliği bulunmaktadır.
- **Classes**: Sınıfları temsil eden sınıf. Her sınıfın benzersiz bir `ClassId` kimliği ve `ClassName` (sınıf adı) özelliği bulunmaktadır.
- **Program**: Ana sınıf, `students` ve `classes` listelerini oluşturur ve `GroupJoin` işlemi ile her sınıf için öğrencileri gruplar.

## Kodun Çalışma Mantığı

1. **Öğrenciler Listesi**: `Students` sınıfından oluşturulan liste, öğrencilerin `StudentId`, `StudentName` ve `ClassId` özelliklerini içerir.
2. **Sınıflar Listesi**: `Classes` sınıfından oluşturulan liste, her sınıfın `ClassId` ve `ClassName` özelliklerini içerir.
3. **LINQ Kullanarak Eşleştirme**: `GroupJoin` işlemi ile `classes` ve `students` listeleri `ClassId` üzerinden birleştirilir ve her sınıfa ait öğrenciler gruplandırılır.
4. **Konsola Yazdırma**: Her sınıfın adı ve o sınıfa kayıtlı öğrencilerin isimleri konsola yazdırılır.

## Örnek Çıktı

```plaintext
Sınıf Adı: Matematik
Öğrenci adı: Ali

Sınıf Adı: Türkçe
Öğrenci adı: Ali

Sınıf Adı: Kimya
Öğrenci adı: Ali
