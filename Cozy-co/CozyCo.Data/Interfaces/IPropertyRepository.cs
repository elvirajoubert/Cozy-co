using CozyCo.Domain.Models;
using System.Collections.Generic;

namespace CozyCo.Data.Interfaces
{
    public interface IPropertyRepository
    {
        Property GetById(int ind);
        public ICollection<Property> GetAllProperties()
        {
            using (var context = new CozyCoDbCOntext())
            {

                return context.Properties.


            }
        }
    }
    public Property Create(Property newProperty)
    {

    }
    public Property Update(Property updatedProperty)
    {

    }
}
