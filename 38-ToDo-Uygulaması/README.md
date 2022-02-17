
<h2>PROJE-2 : Console ToDo Uygulaması</h2>
  <br><br><br>


Yeni bir console uygulaması açarak bir 3 kolondan oluşan bir TODO uygulaması yazınız. Uygulamada olması gereken özellikler aşağıdaki gibidir.<br>



Kart Ekle<br><br><br>
Kart Güncelle<br><br>
Kart Sil<br>
Kart Taşı<br>
Board Listeleme<br>


Kart İçeriği:<br>



Baslık<br>
Icerik<br>
Atanan Kisi (Takım üyelerişnden biri olmalı)<br>
Büyüklük (XS, S, M, L, XL)<br>


Açıklama:<br>



Board TODO - IN PROGRESS - DONE kolonlarından oluşmalı.<br>


Varsayılan olarak bir board tanımlı olmalı ve 3 tane de kart barındırmalı.(Kartlar herhangi bir line'da yani kolonda olabilir.)<br>


Kartlar ancak takımdan birine atanabilir. Takımdaki kişiler ise varsayılan olarak tanımlanmalı. Takım üyeleri Dictionary kullanılarak key-value pair şeklinde yada bir sınıf aracılığıyla tutulabilir. Kartlara atama yapılırken takım üyeleri ID leri ile atanacak. Yani kullanılacak ypının mutlaka bir ID içermesi gerekir.<br>


Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.<br>


  Lütfen yapmak istediğiniz işlemi seçiniz :) <br>
  *******************************************<br>
  (1) Board Listelemek<br>
  (2) Board'a Kart Eklemek<br>
  (3) Board'dan Kart Silmek<br>
  (4) Kart Taşımak
<br>

(1) Board Listelemek<br>


 TODO Line<br>
 ************************<br>
 Başlık      :<br>
 İçerik      :<br>
 Atanan Kişi :<br>
 Büyüklük    :<br>
 -<br>
 Başlık      :<br>
 İçerik      :<br>
 Atanan Kişi :<br>
 Büyüklük    :<br>
 
 
 IN PROGRESS Line<br>
 ************************<br>
 Başlık      :<br>
 İçerik      :<br>
 Atanan Kişi :<br>
 Büyüklük    :<br>
 -<br>
 Başlık      :<br>
 İçerik      :<br>
 Atanan Kişi :<br>
 Büyüklük    :<br>


 DONE Line<br>
 ************************<br>
 ~ BOŞ ~<br>


(2) Board'a Kart Eklemek<br>


 Başlık Giriniz                                  :<br> 
 İçerik Giriniz                                  :<br>
 Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :<br>
 Kişi Seçiniz                                    :<br>
**Büyüklükler Enum olarak saklanmalı. Kart üzerinde gösterilirken XS olarak gösterilmeli. Giriş yapılırken kullanıcıdan 1 alınmalıdır.<br>



**Takım üyeleri mevcut bir listede daha tanımlanmış olamlıdır.(Program içerisinde dinamik tanımlanmasına gerek yok.) Kart tanımlarken takım üyesinin ID'si istenmeli. Tanımlı bir ID değilse "Hatalı girişler yaptınız!" uyarısı ile işlem iptal edilebilir.<br>



(3) Board'a Kart Silmek<br>


 Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.<br>
 Lütfen kart başlığını yazınız:  <br>


Kart bulunamaz ise:<br>



 Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.<br>
 * Silmeyi sonlandırmak için : (1)<br>
 * Yeniden denemek için : (2)<br>
** Aynı isimde birden fazla kart bulunursa her ikisi de silinebilir.<br>



(4) Kart Taşımak<br>


 Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.<br>
 Lütfen kart başlığını yazınız:  <br>


Kart bulunamaz ise:<br>



 Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.<br>
 * İşlemi sonlandırmak için : (1)<br>
 * Yeniden denemek için : (2)<br>


Kart bulunur ise:<br>



 Bulunan Kart Bilgileri:<br>
 **************************************<br>
 Başlık      :<br>
 İçerik      :<br>
 Atanan Kişi :<br>
 Büyüklük    :<br>
 Line        :<br>

 Lütfen taşımak istediğiniz Line'ı seçiniz: <br>
 (1) TODO<br>
 (2) IN PROGRESS<br>
 (3) DONE<br>
** Doğru bir seçim yapılırsa board listelenerek (1) Board Listelemek kullanılarak kullanıcıya gösterilir. Seçim doğru değil ise "Hatalı bir seçim yaptınız!" bilgisi ile işlem sonlandırılabilir.<br>


NOT: Uygulamanın yapısı genel olarak aşağıdaki gibi olmalıdır:<br>


Board 3 tane Line dan oluşur.<br>
Her bir line bir kart listesi tutar<br>
Kart ların büyüklükleri pre-defined olan bir enum'da tutulur.<br>
Kart sadece takım üyelerinden birine atanabilir.<br>
Takım üyeleri daha önceden varsayıla olarak tanımlanmış bir listede olmalı. Struct, class yada bir koleksiyon kullanılabilir.<br>


<h2>Proje'ye yaptığım eklemeler:</h2><br>

-->Board'ımdaki kartlardan istediğimi seçim istediğim özelliğini güncelleyebiliyorum.<br>
-->To Do Uygulamama kapatma seçeneği koydum ve ben kapatma seçeneğimi seçmedikçe işlemimi tamamladıkça uygulamamın ana ekranına dönüş yapıyor ve seçimimi bekliyor.<br><br><br>

Burada programımı çalıştırıp işlemlerin ilerleyişini görsel şekilde sizinle paylaşacağım:<br><br>
![t1](https://user-images.githubusercontent.com/89224500/154561704-c8b892fb-eb6f-4cdf-bb2b-a16fd6247f74.png)
<br>
![t2](https://user-images.githubusercontent.com/89224500/154561715-656c8a61-b340-4da1-83bf-6c91b4868d88.png)
<br>
![t3](https://user-images.githubusercontent.com/89224500/154561725-da7f6374-b6ed-4014-939f-567eeda40fcf.png)
<br>
![t4](https://user-images.githubusercontent.com/89224500/154561750-77fab7f1-cbd0-4f87-8008-a0ba59767fed.png)
<br>
![t5](https://user-images.githubusercontent.com/89224500/154561765-89fd3782-fa4b-4ac7-845b-b8ccedf9d229.png)
<br>
![t6](https://user-images.githubusercontent.com/89224500/154561796-64da5c33-be1e-4574-8d50-e95b22cb29ee.png)
<br>


