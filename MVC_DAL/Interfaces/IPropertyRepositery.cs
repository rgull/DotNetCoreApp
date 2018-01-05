using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_DomainEntities;
using System.Linq.Expressions;

namespace MVC_DAL
{
    public interface IPropertyRepositery
    {

        #region Properties

        int AddProperty(Property property);

        int EditProperty(Property newProperty);

        bool DeleteProperty(int? Id);

        Property GetPropertyById(int? id);

        IEnumerable<Property> ListProperties<TSortExpressType>(Expression<Func<Property, TSortExpressType>> sortExpression, string searchString, bool sortAsscending, 
                                                                int pageSize, int pageNo, int? agentId, int? propertyTypeId, int? contractTypeId, int? locationId, 
                                                                int? subLocationId, int? districtId, int? priceTo, int? priceFrom, bool isFeatured);

        int ListPropertiesCount(string searchString, int? agentId, int? propertyTypeId, int? contractTypeId, int? locationId,
                                int? subLocationId, int? districtId, int? priceTo, int? priceFrom, bool isFeatured);

        IEnumerable<Property> PropertiesList();

        IEnumerable<Property> BuildingsList();

        #endregion
        
      

    }

}
