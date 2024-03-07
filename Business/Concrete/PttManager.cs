using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager: ISupplierService
    {
        private IApplicantService _applinactService;
        public PttManager(IApplicantService applicantService) //Constructor. (new yapıldığında çalısır)
        {
            _applinactService = applicantService;

        }
        public void GiveMask(Person person)
        {

            if (_applinactService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi.");

            }
        }

        public void GiveMask()
        {
            throw new NotImplementedException();
        }
    }
}
