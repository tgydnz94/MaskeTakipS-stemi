using Business.Abstract;
using Business.Adapters.Interfaces;
using Entities.Concrete;
using MerniceServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        private IMerniceAdapter merniceAdapter;
        public void ApplyForMask(Person person)
        {

        }

        public bool CheckPerson(Person person)
        {
            //mernis kontrolü yapılacak
            //KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            //  return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalId,Ad:person.FirstName,Soyad:person.LastName,person.DatOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
            return merniceAdapter.CheckIfReal(person);
        }

        public List<Person> Getperson()
        {
            return null;
        }
    }
}
