# IntroKamp
Camp works 
Description For Link Project

 ***Linq yapısı 
 
 Yazmış oldugum kodumda ;
 
 List<Category> categories = new List<Category>() 
 List<Product> products = new List<Product>()
 
 ile Category ve Product sınıfından liste tanımlayıp bunları çeşitli linq operasyonları yardımıyla farklı kullanımları
 denediğim örnek methodlar içermektedir.
 
 Linq in çeşitli methodları aşagıda anlatılmış ve kod içerisinde mevcuttur.
 Örnek Basit Linq yapısı : 
 .Where
 var result =products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList(); //p parametremiz burada products listesinde dolaşan
 geçici değişkenimizdir her p için p'nin birim fiyatı (UnitPrice) 5000 den büyük ve Stok adedi(UnitInStock) 3'ten büyük olanları
 Where anahatar kelimesi kullanarak elde edilen (ürün listesi döndürülen) yapıdır.
 
 .Any
 var result = products.Any(p => p.ProductName == "Acer Laptop") sonuc olarak ProductName Acer Laptop adında bir product(ürün) 
 varsa true yoksa false döndürür (Any bool yapıdadır)
 
 .Find
 var result =  products.Find(p => p.ProductId == 3) // details of product for find (üürn id si 3 olan ürünü döndürür)
 
 .FindAll
 var result = products.FindAll(p => p.ProductName.Contains("top")) FindAll methodu ise her p için ürün adı 'top' içeren her ürünü
 ürün listesi şeklinde geri döndüren yapı örnegidir
 
 azalan veya artan şekilde sorgu yazmak istersek ;
  var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice)
                .ThenByDescending(p => p.ProductName); //OrderBy(p=>p.UnitPrice) //return those contains the 'top' 
