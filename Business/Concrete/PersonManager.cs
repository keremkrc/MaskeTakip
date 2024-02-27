using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Çıplak Class Kalmasın
    
    public class PersonManager: IApplicantService
    {
        public void ApplyForMask(Person Person)
        {
            
                }
        public List<Person> GetList()
        {
            return null;
        }
        
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(123,"Kerem","Karaca",2003))).Result.Body.TCKimlikNoDogrulaResult;
        } 

    }
}
