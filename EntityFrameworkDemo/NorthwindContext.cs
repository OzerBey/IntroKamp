using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo
{
    // veri tabanına baglantı açmamıza olanak veren yerdir 
    //uygulamamızdaki nesnelerimizle veri tabanındaki tabloları ilişkilendirmeye yarayan kısımdır
    //virtual keyword: Bir classını icinde yazılan method onu inherit eden (miras alan) class isterse o kodun içini değiştirebilir demektir
    public class NorthwindContext : DbContext
    {
        //sunucu bilgileri ve database ksımını tanıtma kısmı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //onConfiguring methodunu burada override (ezebiliriz)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
            // ters slash (\) alt satır temsil ettiği için ya arka arkaya \\ işareti koyarız  en baştan belirtmek istiyorsak string in basına @ işareti koyarak \ işaretini kod olarak tanımlama demiş oluruz
        }
        //veritabanındaki verileri bizim class (varlıklarımıza) eşitledigimiz prop kısmı
        public DbSet<Product> Products { get; set; } 
    }
}
