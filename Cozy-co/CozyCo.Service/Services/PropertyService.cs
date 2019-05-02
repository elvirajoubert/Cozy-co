namespace CozyCo.Service.Services
{
    public interface IPropertyService
    {
        //Create Read Update Delete or RCUD


        Property GetById(int id);
        //ICollection<Property> GetByLandlordId(int landlordId);

        //Create
        Property Create(Property newProperty);

        //Update
        Property Update(Property updatedProperty);

        //Delete
        bool Delete(int id);
    }

    public class PropertyService
    {

    }
}
