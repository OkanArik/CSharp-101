#     Yazılım , Kodlama ve İnternet Konseptleri
- Veriyi bir cihazdan, başka bir cihaza nasıl gönderiyoruz? -->Öncelikle belirtmek isterim ki internetin şifresi yoktur , internete bağlanmamızı sağlayan modemlerin şifresi vardır.Modem ismi `modulator` ve `demodulator` kelimelerinden gelmektedir.Modemlerle kablosuz(wireless) veya kablolu bağlantı sağlanabilmektedir.Kablosuz bağlantı imkanını modemlerdeki donanım olan `wireless ethernet kartı`(ağ kartı) sağlamaktadır.Cihazlarımızın module ettiği ve anten vasıtasıyla havaya saldığı sinyalleri alan modemler onları demodule edip içerisindeki bilgilere göre yönlendirme yapar aslında modemlere de birer router(yönledirici) gibi düşünebiliriz.

- `Router`: Türkçe kullanımı ile ‘yönlendirici’ olarak adlandırılan router, iki ağı birbiriyle güvenli bir biçimde haberleştirmek için kullanılan donanımsal cihazlardır.

- `Wi-Fi`:Wireless fidelity'nin kısaltması olan wi-fi kablosuz bağlantı noktasıdır.Bir modemimiz var ise cihazların wireless ile kendisine bağlanmasına izin veriyorsa bunun adına wi-fi deniyor.

- Ağ üzerinde veya ağlar arası bilgi iletiminin kontrolünü sağlayan protokol çifti vardır.Bu protokol çifti `TCP\IP` dir.`TCP` Transmission Control Protocol 'ün kısaltmasıdır.TCP Türkçe'ye iletim kontrol protokolü şeklinde çevrilebilir.TCP protokolünün yaptığı işlem, gönderilen isteklerin içerdiği verileri küçük paketler halinde iletilmesini sağlamak.TCP protokolünün çalışma mantığı üç başlıkta incelenebilir. Birinci aşamada hedefe bir bağlantı isteği gönderilir. İkinci aşamada bağlantının gerçekleştiği onaylanır ve veri transferi başlar. Üçüncü aşamada ise veri transferinin tamamlandığı taraflara iletilerek bağlantı sonlandırılır.`IP` ise Internet Protocol'ün kısaltmasıdır.IP adresi, interneti ya da TCP/IP protokolünü kullanan diğer paket anahtarlamalı ağlara bağlı cihazların, ağ üzerinden birbirleri ile veri alışverişi yapmak için kullandıkları adresdir.Her bir cihazın IP'si unique(eşsiz)'dir.

- Bir modem üzerinden cihazların bağlantı kurmasına ve dolayısıyla cihazların birbirleri ile iletişime geçebiliyor olmasına `network`(ağ) denir.

- Aynı ortamda bulanan cihazların aynı modem ile iletişim kurdukları durumda oluşan ağ `LAN (Local Area Network)` olarak isimlendirilir.

- Bir çok `LAN`'ın birbiri ile iletişimde olması sonucu oluşan ağ ise `WAN (Wide Area Network)` olarak adlandırılır. Bizim internet olarak adlandırdığımız şey aslında `WAN`'ın tamamıdır.

- İnternet üzerinde birbirlerine bağlanan her ağ'ın da iç IP'si vardır. Bunlara ağların dış IP'si denir. 

- İnternet üzerinde erişmek istediğimiz sitelere erişebilmek için tarayıcıya onların IP'lerini girmiyoruz. O sitelerin `Domain Name`'lerini giriyoruz. Bizim gündelik hayatta adres olarak söylediğimiz şey `(www.youtube.com)` aslında `Domain Name`'dir. Bir sitenin adresi onun IP'sidir. 

- Domain Name girildiği zaman onun IP'sini nasıl belirliyoruz? Burada devreye `DNS (Domain Name Server)` kavramı giriyor. DNS, biz tarayıcıda arama yaptığımız zaman Domain Name'i çözerek IP'ye yönlendiriyor.

- Bu kavramlar arasında bir şeyi yapmak isteyen kısıma `Client / İstemci` denir. İstemcilerin istekleri kısıma ise `Server / Sunucu` denir. Tarayıcı ile istediğimiz web sayfasını karşımıza getiren yapıya ise `HTTP / HTTPS` denir.

- Eğer biz kurduğumuz bir site üzerinden paylaştığımız belgeleri dış dünya ile paylaşırsak bu belgeleri tutan bilgisayara `Host` denir. Ama bilgisayarımızı kapattığımız zaman erişim kesilecektir. Burada devreye sürekli açık olan, iyi donanımlı bilgisayarlar, çok hızlı internet vb. şekilde normalden daha yüksek özellikli bilgisayarlara ihtiyaç duyulur. Bunları sağlayan yapılara-şirketlere `Hosting`'ler denir. Hosting'ler bizlere 7/24 erişim sağlanabilecek ortamları hizmet olarak sunarlar. İstersek kendimiz de hosting yapabileceğimiz makinaları oluşturabiliriz.

# Ders 2

- `Yazılım` nedir ? Yazılım, bizim bilgisayarlara yada elektronik cihazlara bir işi yaptırmak için kullandığımız kod parçacıklarıdır. Peki `Algoritma` nedir ? Algoritma, bir yapı oluşturacağımız zaman bu yapıyı en iyi nasıl yaparımın süreçlerini belirlediğimiz şeydir. Örnek olarak çay demleme işleminin de bir algoritması oluşturulabilir. Algoritmaların anlaşılmasını kolaylaştırmak için görsel öğelerden faydalanılır. Bunlara `Akış Diyagram`'ları denir. Oluşturduğumuz algoritmayı günlük dil ile yazılımsal bir şekilde açıklamak istersek buna da `Pseudo Code (Sahte Kod)` denir.

- Web uygulamalaları geliştirme teknolojileri 2 alana ayrılabilir. 
    
    1. `Frontend` Teknolojileri: Bir web sayfasına girdiğimizde gördüğümüz her şey Frontend'e bağlıdır. Bu alanda temel olarak `HTML-CSS-JavaScript` dilleri kullanılır.

    2. `Backend` Teknolojileri: Web sayfasında ekranda gördüğümüz yapıların anlam ve işlevsellik kazanmasını sağlayan alandır. Örnek olarak bir sayfaya üye girişi yaptığımız yerde kullanıcı adımızı ve şifremizi girdikten sonra 'Giriş Yap' butonuna tıkladığımızda Backend kısmı devreye girer. Eğer Backend kısmında bir işlem yazılmış olmasaydı sayfada herhangi bir değişiklik olmayacaktı. Bu alanda ise `C#-Java-Python-GO-JavaScript(Node.js)-Ruby` gibi diller sıklıkla kullanılıyor.

- Kişisel gelişimimizi test edebilmek ve öğrenim olarak bulunduğumuz konumu görebilmek için bazı *Online Çalışma ve Challenge Platform*ları bulunmaktadır. Bu platformlarda zaman gecirmek ve sürekli kendimizi sınamak bize oldukça fazla faydalı olacaktır. Bu platformlardan bazıları:

    1. `HackerRank`
    2. `Codility`
    3. `Project Euler`
    4. `LeetCode`
 
 # Ders 3
 
 - 'Yazılım nedir ?' sorusuna biraz daha detaylı bakalım. Sözlük anlamına yakın bir tanımlama yapmak istersek: 'Derlenmiş, kodlanmış komutlar dizisi.' şeklinde ifade edebiliriz. Yazılımın görevi aslında donanım ile insan arasında bir köprü kurmaktır. Yani bir şablon oluşturmak istersek:

        KULLANICI   -->     UYGULAMA    -->     iŞLETİM     -->     DONANIM
                    <--     YAZILIMI    <--     SİSTEMİ     <--     
                                   
    Şeklinde temsil edebiliriz. Yazılım kavramını 3'e ayırabiliriz.

    1. `Uygulama Yazılımları:` Notepad, VS Code, Ekran kaydetme uygulamaları gibi son kullanıcıya yakın olan yazılımlar. Belirli işletim sistemleri üzerinde çalışırlar.

    2. `Sistem Yazılımları:` Linux, Windows vb. şekilde işetim sistemleri örnek olarak verilebilir.

    3. `Zararlı Yazılımlar:` Diğer yazılımlardan farklı olarak son kullanıcıya kolaylık yerine tam tersi olarak zorluk oluşturmak için oluşturulan yazılımlardır.

# Bonus [VS Code]

- Kodlama yaparken veya editörde bir işimiz olduğunda olabildiğince mouse'u kullanmadan hareket etmeye çalışmalıyız. Bunun için VS Code içerisinde unutmamamız gereken ve en çok kullanılan kısayol tuşlarına bir bakalım:

    1. `ctrl` + `p`: Son kullandığımız dosyaları karşımıza çıkartır ve bu dosyalar arasında geçiş yapabilmemizi sağlar.

    2. `ctrl` + `W`: Ekranda açık olan dosyayı kapatır.

    3. `ctrl` + `B`: Editörün sağ-sol tarafında açık olan menü çubuğunu kapatır.

    4. `ctrl` + `enter`: İmlec satırda nerede olursa olsun, bir altta yeni satır açar.

    5. `ctrl` + `shift` + `L`: Seçilen kelime ile aynı olan diğer kelimelerin hepsini seçer.

    6. `ctrl` + `shift` + `P`: Ayarlar bölümüne hızlı bir şekilde ulaşmamızı sağlar.

    7. `ctrl` + `shift` + `ğ`: İmleçin üzerinde bulunduğu etiketin içerisindeki kodları gizler (Fold).
    
    8. `ctrl` + `shift` + `ü`: İmleçin üzerinde bulunduğu etiketin içerisindeki kodları açar (unFold).

    9. `alt` + `Z`: Dosyadaki yazıların hepsinin ekranda görünmesini sağlayacak şekilde formatlar. Veya taşmaları önemsemeden düz satır olarak formatlar.

    10. `alt` + `yukarı ok, aşağı ok`: Seçilen satırı-satırları yukarı veya aşağı şekilde taşımamızı sağlar. 

- Projelerimizde sık tekrar ettiğimiz yapıları bir kısayol şeklinde tanımlamak istersen, yazılan dile göre `Snippet`'lar tanımayabiliriz. Nasıl yapacağımızı bilmiyorsak `ctrl + shift + p` yaptıktan sonra arama yerine `Snippets` yazarız. Çıkan seçeneklerden `Preferences`'ı seçeriz. Sonrasında hangi dilde Snippet yazmak istiyorsak o dili seçeriz. Önümüze nasıl kullanılacağını örnekleyen bir yapı çıkacaktır. Buradan sonrasında kendi ihtiyaçlarımıza göre Snippet'lar tanımlayabiliriz. ***Snippet'ların öneminin farkında olmalıyız. Doğru kullanımlarda kodlama yaparken bizlere düşündüğümüzden daha fazla hız kazandıracaktır.***

- Font seçiminde yazılımcılar için en önemli nokta fontun `monospace` olmasıdır. Eğer font değiştirmek istersek seçeceğimiz font kesinlikle monospace olmalıdır. Monospace şu demektir. Her karakter aynı boyutta yer kaplar. Yani 'araba' ile '.....' ikiside 6 karakter olduğu için aynı alanı kaplamaktadır.

