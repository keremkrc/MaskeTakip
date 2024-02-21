using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
        private IApplicantService _applicantService;
        public void GiveMask(Person person)
        {
            if (personManager.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
        }
    }
}
