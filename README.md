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
    <h1>Bir class-a necə iterational davranış qazandırılar?</h1>

    <p>
      Bir class-a iterative bir davranış qazandıra bilmək üçün o class-ın içərisində geriyə IEnumerator dönən və adı “GetEnumerator”olan bir metod olması gərəkir.
    </p>

    <div style="width: 100%; margin: 20px 0;">
      <img src="https://github.com/user-attachments/assets/b4c26055-b547-4a80-9640-4fff77ba36d1" alt="" style="width: 600px;">

    </div>
