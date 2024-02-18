using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager :ISupplierService 
    {
        private IApplicantService _applicantService; //dependency injection. pttmanager bagımlı oldugu sınıf yerine o sınıfın interface yazıyoruz.


        public PttManager(IApplicantService applicantService)  //constructor. oluşturucu demek. pttmanager new yapıldıgında calısır.
        {
            _applicantService = applicantService;
        }


        //Bu kod bir C# sınıfında bir constructor (kurucu metot) tanımlamasını göstermektedir.

        //    PttManager adında bir sınıf tanımlanıyor.Bu sınıfın içinde _applicantService adında bir IApplicantService tipinde özel(private) bir üye değişken(field) tanımlanmış.

        //    Daha sonra, PttManager sınıfının bir constructor'ı tanımlanmış. Constructor, bir sınıf örneği oluşturulurken çağrılan ve sınıfın başlangıç durumunu belirleyen bir metottur. Bu constructor, bir IApplicantService türünde bir parametre alıyor ve aldığı bu parametreyi _applicantService adlı özel üye değişkene atıyor.

        //    Yani, PttManager sınıfı, IApplicantService arayüzünü kullanan bir servis alıyor ve bu servisi _applicantService adlı özel bir üye değişkende saklıyor.Bu, bağımlılık enjeksiyonu(dependency injection) desenini uygulamanın bir parçası olabilir.Bu desen, kodun daha test edilebilir, esnek ve bakımı kolay hale gelmesine yardımcı olur.




        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person)== true)
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }

        // interfaceler belirli metot imzalarını barındırırlar. birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını saglarlar.

        //sonarqube yazılım kalite ölcer aracı var incele..
    }
}
