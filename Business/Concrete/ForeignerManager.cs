using Business.Abstract;
using Business.Adapters;
using Business.Adapters.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        MerniceAdapter merniceAdapter = new MerniceAdapter();
        //Sonarcube kod kalitesi kontrolü için
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            return merniceAdapter.CheckIfReal(person);
        }

        public List<Person> Getperson()
        {
            throw new NotImplementedException();
        }
    }
}
