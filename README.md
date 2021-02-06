# TopDownShootingGame2D
Unity'de kendimi geliştirebilmek, yeni bilgiler öğrenebilmek ve öğrendiğim bilgileri de uygulayabilmek için yaptığım küçük çaplı bir projedir.
Henüz tam olarak bitmemiş bir proje olsa da genel yapı itibariyle oyunu anlatayım:

Oyunumuzda 2 adet ana obje bulunmakta biri Player (kullanıcının kontrol ettiği) diğeri ise Enemy (kullanıcının yok etmesi gereken) objelerdir.
Bu iki obje şu mantıkla hareketlerini gerçekleştirmektedirler:

Player: mouse Cursor'una göre bir doğrultu alır ve W tuşu ile o doğrultuda ileri, S tuşu ile o doğrultuda geriye doğru hareket etmektedir.
Aynı zamanda player objesinin görünümü için kullandığım hazır 4 farklı sprite ile bu hareketin animasyonu da bulunmaktadır.

Enemy: Player'ın doğrultusunda göre doğrultulanmakta ve o yöne doğru otomatik olarak hareket etmektedir.(bir nevi takip etmektedir.)
Yine aynı şekilde Enemy objesinin de 4 adet sprite'ı ile uzay gemisinin animasyonu oluşturulmuştur.

Oyun, Player objesinin tüm Enemy Objelerini yok etmesi amacı üzerine kuruldur. Bu amaç doğrulutsunuda Player'ın bir adet ışın kılcı vardır ve mouse sol click ile bu kılıç aktif hale gelmektedir.
Işın kılıcının da soldan sağa doğru dönüş hareketi bir animasyon olarak yerine getirilmiştir. Burada ışın kılıcının soldan sağa savrulma animasyonunu farklı sprite'lardan ziyade animatör penceresinde elimden geldiğince kendim gerçekleştirmeye çalıştım.

Işın kılıcı soldan sağa doğru olan hareketi boyunca temas ettiği Enemy objelerini yok etmekte ve bunun sonucunda yok oluşu belirtmek için bir patlama animasyonu da ekranda belirmektedir.
Patlama animasyonu da 8 adet hazır sprite ile oluşturulmuştur ve Enemy objelerinin yok oluşu ile tetiklenmektedir.

Oyunun genel mantığı anlatıldığı şekildedir.Çok klasik ve oynarken eğlendirebilecek türde bir Top Down Shotting oyunudur. 
Oyunun henüz tamamlanmamış ve olması gereken kısımları da mevcut (Level Tasarımı, Player Can sayacı, Puan Sayacı, Game Over Ekranı, Level Geçiş Ekranı gibi.)
Fakat belirttiğim gibi farklı kaynaklardan da yararlanarak kendimi geliştirmek için yaptığım ufak çaplı bir projeydi. Teşekkürler.

Oyun içi Görseller:



 # Start
![Start](https://user-images.githubusercontent.com/44782947/107117672-fd575000-688c-11eb-9773-23c20c684157.png)


# Attack
![Attack1LaserSword](https://user-images.githubusercontent.com/44782947/107117654-ddc02780-688c-11eb-9b3e-fb5aeb53e1ac.png)


# Destroy
![Attack2Destroy](https://user-images.githubusercontent.com/44782947/107117684-13fda700-688d-11eb-91de-af1b8c01b101.png)


# End of the Game
![End](https://user-images.githubusercontent.com/44782947/107117687-1b24b500-688d-11eb-8327-0f49ce098d4e.png)


