using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstruct;
/**interface kelime anlamı arayüz.İçersinde sadece metot imasazı tutar.
interfaceler belli metot imzalarını barındırırlar,birbirinin alternatifi olan sistemlerin farklı
implementasyon yapmalarını sağlarlar.İnterfaceler newlenemez ama referans tutucudurlar.
**/

public interface IApplicantService
{
    void ApplyForMask(Person person);
    List<Person> GetList();
    bool CheckPerson(Person person);
    
}
