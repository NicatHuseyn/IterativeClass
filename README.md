<h1>Özəl İteration Class-ı yaratmaq</h1>

<h3>İlk olaraq <strong>İteration nədir?</strong></h3>

 <p>
      Məsələn, bir problem həll etmək üçün birdən çox addımın həyata keçirilməsi
      bir iteration-dur. Çünkü burada bir təkrar vardır. Yəni bir əməliyyatın
      addımları əlaqəli olur, bir öncəki addım bir sonrakı addımla əlaqəli olur.
      Məsələni kompüter elmləri ilə əlaqələndirsək, hər bir döngüdəki keçiş
      iteration məntiqi ilə dəyərləndirilir. Hansı sahə olursa olsun, iteration
      məntiqi hər zaman öncəki addımlardan əldə edilən nəticələri istifadə
      edərək bir sonrakı addıma keçməkdir.
    </p>

 <h3>C# tərəfdən iteration məntiqi</h3>
    <p>
      C# proqramlaşdırma dili nöqteyi-nəzərdən iteration array-lər yaxud
      collection-larla eyni bir anlayışa sahibdir. Bir array yaxud collection
      iteration-a məruz qala bilən bir strukturdur və bu strukturlar üzərində
      iteration vasitəsilə addım-addım elementləri göstərib əməliyyatlarımızı
      edə bilərik.
    </p>
    <p>
      <strong> Bəs for, while, foreach döngüləri bir iteration-durmu? </strong>
    </p>
    <p>
      Proqramlaşdırmada iteration məntiqində çalışan struktur sadəcə foreach-dir. For və While döngüləri döngüdür, lakin iteration məntiqində çalışmırlar. Bunlar bir şərtə görə çalışan strukturlardır, amma iteration fərqli bir məntiqdir.
    </p>
    <hr>
    <h1>IEnumerable və IEnumerator</h1>
    <p>
      IEnumerable bir class-a iteration məntiqi qazandıran, GetEnumeration metounu özündə saxlayan interface-dir.
      <br>
      IEnumerator interface-i isə bir class-ın iterational davranışında hansı qanunların keçərli olacağını müəyyən edir. Yəni hər bir addımda necə bir data işi görəcəyini müəyyən edirik. 
      <br>
      Indi isə bir class-a necə iterational bir davranış qazandırılacağına baxaq.
    </p>

   <hr>
    <h1>Bir class-a necə iterative davranış qazandırılar?</h1>

   <p>
      Bir class-a iterative bir davranış qazandıra bilmək üçün o class-ın içərisində geriyə IEnumerator dönən və adı “GetEnumerator”olan bir metod olması gərəkir.
    </p>

   <div style="width: 100%; margin: 20px 0;">
      <img src="https://github.com/user-attachments/assets/b4c26055-b547-4a80-9640-4fff77ba36d1" alt="" style="width: 600px;">
   </div>

   <p>
      Belə bir metodu özündə saxlayan class-lar C#-da iterativ davranış ortaya
      qoyan bir class olaraq bəyan edilirlər
      <strong>və sadəcə o halda foreach ilə istifadə edililə bilirlər.</strong>
    </p>
    <br />
    <p>
      GetEnumerator() metodu geriyə bir Enumerator dönür, yəni bir iterative bir
      davranış dönür, iterative davarnışın qanunlarını dönür.<br />
      <strong>Bəs bu metodun içərisində nə edəcəyik?</strong><br />
      Bu metodun içərisində geriyə bir enumerator, yəni iterativ davranışının
      qanunlarını müəyyən edən bir obyekt dönməliyik.
      <br />
      <strong
        >Yuxarıdakı kodda görüldüyü kimi İenumerator istifadə edərsək, foreach
        döngüsündəki iteration zamanı item-ları object olaraq əldə
        edəcəyik.</strong
      >
      <br>

   Əgər ki, object yerinə tip güvənli bir şəkildə davranış ortaya qoymaq lazımdırsa, generic olan IEnumerator<T> interfeysini istifadə etməkdir.
   </p>

   <div style="width: 100%; margin: 20px 0">
      <img src="https://github.com/user-attachments/assets/40229908-63f6-48d7-8190-11f9e3e7902d" alt="" style="width: 600px" />
   </div>
   <strong>Burada metod adı mütləq GetEnumerator() olmalıdır.</strong>


   ## IEnumerable interface
   <h1>IEnumerable interface</h1>

   <p>
      Bu interface-nin generic və non-generic olmaqla 2 yerə ayrılır. <br>
İEnumerable interfeysi, içərisində “GetEnumerator” metodu saxlayır. Yəni bir class-a iteration davranışını qazandıran bir interfeysdir. AMMA “GetEnumerator” metodunun maula implementaion-undakı ola biləcək insan xətalarından bizləri qurtarır və bir yandan da bu implementation sayəsində baxan kimi hansı class-ın iteration edilə bilməsini anlamaq olur. Generic tipdə, verilən tipə görə bir davranış olur, amma non-genericdə isə object tipində bir çalışma olur.

   </p>

   <br>

   <h1>IEnumerator Interface</h1>
    <div style="width: 100%; margin: 20px 0">
      <img src="https://github.com/user-attachments/assets/4e9ee537-9965-4a64-bcd7-a142c6f9ee48" alt="" style="width: 600px" />
   </div>
    <p>
      IEnumerator interfeysinin generic və non-generic olmaqla 2 növü vardır. IEnumerator interfesyi bir class-ın iteration qanunlarını müəyyən etməyimizə imkan verir. Bir class-ın iterativ bir davranış edə bilməsi üçün onun mütləq İEnumerable interfeysindən implement edilmısi məcburi deyil, IEnumerator interfeysindən də implement edilə bilər. Yuxarıdakı koddan görüldüyü kimi bəzi member-larımız vardır.
    </p>

   <div style="width: 100%; margin: 20px 0">
      <img src="https://github.com/user-attachments/assets/2d6729eb-1b07-4d39-a523-4011eb23f7b7" alt="" style="width: 600px" />
   </div>

   <ul>
      <li><strong>Current:</strong> iterative addımda, o anda hansı halda olduğunu ifadə edir. Soruce-nin hansı qaynağı gətirmək istədyimizi ifadə edir.</li>
      <li><strong>MoveNext():</strong> iteration zamanı, bir sonrakı addımda hansı dəyərin gətiriləcəyini ifadə edir.</li>
      <li><strong>Reset(): </strong>iteration-ı başa qaytardıqda nələr olacağını ifadə edir.</li>
    </ul>

   <p>
      Burada gördüyümüz kimi özəl bir iterativ bir struktur yaratmış oluruq. <br>
Bundan sonra gəlib aşağıdakı kimi yazdığımız custom iteration-ı istifadə edə bilərik

   </p>

   <div style="width: 100%; margin: 20px 0">
      <img src="https://github.com/user-attachments/assets/b774dcdf-e705-4b97-a81f-d6db73f68a21" alt="" style="width: 600px" />
  </div>
