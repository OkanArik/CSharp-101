## PROJE-1 : Console Telefon Rehberi Uygulaması


Yeni bir console uygulaması açarak telefon rehberi uygulaması yazınız. Uygulamada olması gereken özellikler aşağıdaki gibidir.
<br><br><br>



1)Telefon Numarası Kaydet
<br>
2)Telefon Numarası Sil
<br>
3) Telefon Numarası Güncelle
<br>
4) Rehber Listeleme (A-Z, Z-A seçimli)
<br> 
5) Rehberde Arama
<br>
6) Uygulamayı Kapat
<br>  


Açıklama:
<br>


Başlangıç olarak 5 kişinin numarasını varsayılan olarak ekleyiniz.                                              +
<br>

Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.
<br>

 Lütfen yapmak istediğiniz işlemi seçiniz :) <br>
 *******************************************<br>
 (1) Yeni Numara Kaydetmek<br>
 (2) Varolan Numarayı Silmek<br>
 (3) Varolan Numarayı Güncelleme<br>
 (4) Rehberi Listelemek<br>
 (5) Rehberde Arama Yapmak<br>
 (6) Telefon Rehberi Uygulamasını Kapat<br>

(1) Yeni Numara Kaydetmek<br>

 Lütfen isim giriniz             : <br>
 Lütfen soyisim giriniz          : <br>
 Lütfen telefon numarası giriniz : <br><br><br>
(2) Var olan Numarayı Silmek<br>


İsim ve soy isime göre arama yapılması yeterlidir.<br>



Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:<br>


Kullanıcıdan alınan girdi doğrultusunda rehberde bir kişi bulunamazsa:<br>



  Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.<br>
  * Silmeyi sonlandırmak için : (1)<br>
  * Yeniden denemek için      : (2)<br>


Rehberde uygun veri bulunursa:



  {} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)<br>
Not: Rehber uygun kriterlere uygun birden fazla kişi bulunursa ilk bulunan silinmeli.<br>


(3) Varolan Numarayı Güncelleme<br>


 Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:<br>


Kullanıcıdan alınan girdi doğrultusunda rehberde bir kişi bulunamazsa:<br>



 Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.<br>
 * Güncellemeyi sonlandırmak için    : (1)<br>
 * Yeniden denemek için              : (2)<br>


Rehberde uygun veri bulunursa güncelleme işlemi gerçekleştirilir.<br>



Not: Rehber uygun kriterlere uygun birden fazla kişi bulunursa ilk bulunan silinmeli.<br>


(4) Rehberi Listelemek<br>


Tüm rehber aşağıdaki formatta console'a listelenir.<br>



  Telefon Rehberi<br>
  **********************************************<br>
  isim: {}<br>
  Soyisim: {}<br>
  Telefon Numarası: {}<br>
  - <br>
  isim: {}<br>
  Soyisim: {}<br>
  Telefon Numarası: {}<br>
  .<br>
  .<br>


(5) Rehberde Arama Yapmak<br>


 Arama yapmak istediğiniz tipi seçiniz.<br>
 **********************************************<br>
 
 İsim veya soyisime göre arama yapmak için: (1)<br>
 Telefon numarasına göre arama yapmak için: (2)<br>


Arama sonucuna göre bulunan veriler aşağıdaki formatta gösterilmeli.<br>



 Arama Sonuçlarınız:<br>
 **********************************************<br>
 isim: {}<br>
 Soyisim: {}<br>
 Telefon Numarası: {}<br>
 - <br>
 isim: {}<br>
 Soyisim: {}<br>
 Telefon Numarası: {}<br>
 .<br>
 .<br>


** Her bir feature ayrı class/method kullanarak yapılmalıdır. Mümkün olduğunca sorumlulukları parçalanmalı ve kod okunabilir olmalıdır.<br><br><br><br><br>

Burada programımı çalıştırıp işlemlerin ilerleyişini görsel şekilde sizinle paylaşacağım:<br>
<br>
![t1](https://user-images.githubusercontent.com/89224500/154528543-72e4c2d8-15b3-4c6d-9acc-3bf0a6bb7318.png)
<br><br>
![t2](https://user-images.githubusercontent.com/89224500/154528584-e29b458f-00ed-48c8-8cab-681f9d1ddd48.png)
<br><br>
![t3](https://user-images.githubusercontent.com/89224500/154528600-cf7c7397-a040-46ff-97a6-119aab5bfe11.png)
<br><br>
![t4](https://user-images.githubusercontent.com/89224500/154528618-f140ec8f-bbcd-4d2b-8f4a-305901cb7908.png)
<br><br>
![t5](https://user-images.githubusercontent.com/89224500/154528644-bf849274-4541-462a-b0be-0fccc17ba375.png)
