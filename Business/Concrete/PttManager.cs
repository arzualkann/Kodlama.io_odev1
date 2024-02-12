using Business.Abstruct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager:ISupplierService
{
    //dependency injection
    private IApplicantService _applicantService; //fieldlar classın içinde altçizgiyle yazılır.
    public PttManager(IApplicantService applicantService) //Constructor new lendiğinde çalışır
    {
        _applicantService = applicantService;
    }
    public void GiveMask(Person person)
    {
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine(person.FirstName + "için maske verildi");
        }
        else
        {
            Console.WriteLine("maske verilmedi");
        }
    }
}
