using CozyCo.Domain.Models;
using System.Collections.Generic;

namespace CozyCo.Service.Services
{
    public interface IPropertyService
    {
        //Create Read Update Delete or RCUD


        Property GetById(int id);
        ICollection<Property> GetAllProperties();

        //Create
        Property Create(Property newProperty);

        //Update
        Property Update(Property updatedProperty);

        //Delete
        bool Delete(int id);
    }

    public class PropertyService : IPropertyService

    {
        private readonly IPropertyRepository _propertyRepository;  //--> null

        //Added  a dependency to the constructor
        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository; //-->not be null
        }

        public ICollection<Property> GetProperties()
        {
            return _propertyRepository.GetAllProperties();
        }
        public Property Create(Property newProperty)
        {

            //Can add more logic to veify a new property before creating
            return _propertyRepository.Create(newProperty);
        }

        public bool Delete(int id)
        {
            return _propertyRepository.Delete(id);
        }

        public Property GetById(int id)
        {
            return _propertyRepository.GetById(id);
        }

        public Property Update(Property updatedProperty)
        {
            return _propertyRepository.Update(updatedProperty);
        }
    }
}
