using Business.Adapters.Interfaces;
using Entities.Concrete;
using MerniceServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters
{
    public class MerniceAdapter : IMerniceAdapter
    {
        public bool CheckIfReal(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalId, Ad: person.FirstName, Soyad: person.LastName, person.DatOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
