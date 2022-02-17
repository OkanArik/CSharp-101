using System;

    namespace Operators
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //*****Atama ve İşlemli Atama Operatorleri(=, +=, -=, *=, /=)*****
                Console.WriteLine("*****Atama ve İşlemli Atama Operatorleri(=, +=, -=, *=, /=)*****");
                int x=12;
                Console.WriteLine("x:{0}",x);
                int y=45;
                Console.WriteLine("y:{0}",y);
                x=x+2;//(x=x+2)=(x+=2) burada görüldüğü gibi x=x+2 ile x+=2 aynı sonucu bize vermekte integer tipindeki x değişkenini 2 artırarak x değişkenine atamaktadır.x+=2 şeklindeki kullanıma işlemli atama denir.
                Console.WriteLine("x=x+2:{0}",x);
                x+=2;//(x+=2)=(x=x+2)
                Console.WriteLine("x+=2:{0}",x);
                y/=3;//Buradaki işlemli atamada integer tipindeki y değişkenindeki veriyi 3'e bölüyoruz ve y değişkenine atıyoruz.(y/=3)=(y/3)
                Console.WriteLine("y/=3:{0}",y);
                y=y/3;//(y/=3)=(y/3)
                Console.WriteLine("y=y/3:{0}",y);
                x*=2;//(x*=2)=(x=x*2)
                Console.WriteLine("x*=2:{0}",x);
                x=x*2;//(x*=2)=(x=x*2)
                Console.WriteLine("x=x*2:{0}",x);

                //*****Mantıksal Operatorler(||, &&, !)*****
                //(||:or:veya)(&&:and:ve)(!:not:değil)
                Console.WriteLine("*****Mantıksal Operatorler(||, &&, !)*****");
                bool isSuccess = true;
                bool isCompleted = false;
                Console.WriteLine("isSuccess:{0}",isSuccess);
                Console.WriteLine("isCompleted:{0}",isCompleted);
                Console.WriteLine("***isCompleted||isCompleted***");
                if (isSuccess||isCompleted)
                {
                   Console.WriteLine("We know that isSucces=true and isCompleted=false. isSuccess||isCompleted means that isSuccess or isCompleted.İf one of these is true , solution will be true  so the solution is true and we are reading this article from if block command at console:)For information: (1) true or ture = true (2) true or false = true (3) false or false = false");
                }
                Console.WriteLine("***isCompleted&&isCompleted***");
                if (isSuccess&&isCompleted)
                {
                  //Buradaki komutlar şu anki durumda yürütülmez çünkü isSuccess&&isCompleted=false olur ve else bloğundan devam edilir.
                }
                else
                {
                    Console.WriteLine("We know that isSucces=true and isCompleted=false. isSuccess&&isCompleted means that isSuccess and isCompleted.İf both of these is true , solution will be false  so the solution is false and we are reading this article from else block command line at console:)For information: (1) true and ture = true (2) true and false = false (3) false and false = false");
                }
                Console.WriteLine("***isCompleted&&!isCompleted***");
                if (isSuccess&&!isCompleted)
                {
                    Console.WriteLine("We know that isSucces=true and isCompleted=false. isSuccess&&!isCompleted means that isSuccess and (not)isCompleted.İf both of these is true , solution will be true  so the solution is true and we are reading this article from if block command line at console:)For information: (1)!false=true (2)!true=false");
                }

                //*****İlişkisel Operatorler(<,>,<=,>=,==,!=)******
                //(<:küçüktür)(>:büyüktür)(<=:küçük eşittir)(>=büyük eşittir)(==:eşittir)(!=:eşit değildir)
                Console.WriteLine("*****İlişkisel Operatorler(<,>,<=,>=,==,!=)******");
                int a=3;
                int b=4;
                bool result=a<b;
                Console.WriteLine("a:{0}",a);
                Console.WriteLine("b:{0}",b);
                Console.WriteLine("(a<b):{0}",result);
                result=a>b;
                Console.WriteLine("(a>b):{0}",result);
                result=a>=b;
                Console.WriteLine("(a>=b):{0}",result);
                result=a<=b;
                Console.WriteLine("(a<=b):{0}",result);
                result=a==b;
                Console.WriteLine("(a==b):{0}",result);
                result=a!=b;
                Console.WriteLine("(a!=b):{0}",result);

                //*****Aritmetik (+, -, *, /, %, ++, --)*****
                //(+:toplama)(-:çıkartma)(*:çarpma)(/:bölme)(%:mod alma)(++:bir arttırma)(--:bir azaltma)
                Console.WriteLine("*****Aritmetik (+, -, *, /, %, ++, --)*****");
                int number1=10;
                int number2=5;
                Console.WriteLine("number1:{0}",number1);
                Console.WriteLine("number2:{0}",number2);
                int result1=number1+number2;
                Console.WriteLine("number1+number2:{0}",result1);
                result1=number1-number2;
                Console.WriteLine("number1-number2:{0}",result1);
                result1=number1*number2;
                Console.WriteLine("number1*number2:{0}",result1);
                result1=number1/number2;
                Console.WriteLine("number1/number2:{0}",result1);
                result1=number1%number2;
                Console.WriteLine("number1%number2:{0}",result1);

                //*****Ön ek artırma işleci*****
                  //Sonucu, x++ aşağıdaki örnekte de x olduğu gibi işlemden önceki değeridir:
                  int number3 = 3;
                  Console.WriteLine("number3:{0}",number3);//output: 3
                  Console.WriteLine("number3++:{0}",number3++);// output: 3 
                  Console.WriteLine("number3:{0}",number3);// output: 4
                
                //*****Sonek artırma işleci*****
                  //Sonucu, ++x aşağıdaki örnekte de x olduğu gibi işlemden sonraki değeridir:
                  int number4 = 3;
                  Console.WriteLine("number4:{0}",number4);   // output: 3
                  Console.WriteLine("++number4:{0}",++number4); // output: 4
                  Console.WriteLine("number4:{0}",number4);   // output: 4

                
                //*****Sonek azaltma işleci*****
                  //Sonucu, x-- aşağıdaki örnekte de x olduğu gibi işlemden önceki değeridir:
                  int number5 = 3;
                  Console.WriteLine("number5:{0}",number5);   // output: 3
                  Console.WriteLine("number5--:{0}",number5--); // output: 3
                  Console.WriteLine("number5:{0}",number5);   // output: 2

                //*****Ön ek geri ödeme işleci*****
                  //Sonucu, --x aşağıdaki örnekte de x olduğu gibi işlemden sonraki değeridir:
                  int number6 = 3;
                  Console.WriteLine("number6:{0}",number6);   // output: 3
                  Console.WriteLine("--number6:{0}",--number6); // output: 2
                  Console.WriteLine("number6:{0}",number6);   // output: 2


                //*****%:mod alma*****
                Console.WriteLine("*****%:mod alma*****");
                int result2=20%3;
                Console.WriteLine("20%3:{0}",result2);
            }
        }
    }
//**********************************************************
   //Operators(Operatörler)
   //Uygulama içerisinden bir atama işlemi yada durum karşılaştırması yapmak istediğimizde operatörleri kullanırız. Bazen koşullara bağlı olarak çalıştırılacak kod bloğunun değişmesi gerekir. Karar yapıları ve operatörler birlikte kullanılarak bu sağlanabilir.
   //İşlevlerine göre operatörler aşağıdaki gibi kategorilendirilir.
   //-Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
   //-Mantıksal Operatörler (||, &&, !)
   //-İlişkisel Operatörler (==,!=, <, >, >=,<=)
   //-Aritmetik (+, -, *, /, %, ++, --)
//**********************************************************
   //multiply-line:çoklu satır
   //curly braces:süslü parantez
   //success:başarı
   //complete:tamamlamak,bitirmek
   //article:makale
   //result:sonuç