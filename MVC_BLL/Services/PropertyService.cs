using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MVC_DomainEntities;
using MVC_DAL;

namespace MVC_BLL
{
    public class PropertyService : IPropertyService
    {
        IPropertyRepositery IPropertyRepositery;

        public PropertyService(IPropertyRepositery IPR)
        {
            IPropertyRepositery = IPR;
        }

        #region Properties

        public int AddProperty(Property property)
        {
            try
            {
                return IPropertyRepositery.AddProperty(property);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EditProperty(Property property)
        {
            try
            {
                return IPropertyRepositery.EditProperty(property);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteProperty(int? Id)
        {
            try
            {
                return IPropertyRepositery.DeleteProperty(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Property GetPropertyById(int? id)
        {
            try
            {
                return IPropertyRepositery.GetPropertyById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Property> ListProperties(string sortField, bool sortAsscending, string searchString, int pageSize, int pageNo, int? agentId,
                                                    int? propertyTypeId, int? contractTypeId, int? locationId, int? subLocationId, int? districtId, int? priceTo,
                                                    int? priceFrom, bool isFeatured)
        {
            try
            {
                var param = Expression.Parameter(typeof(Property));

                switch (sortField)
                {
                    case "PropertyId":
                    case "PropertyTypeId":
                    case "ContractTypeId":
                    case "Price":
                        Expression<Func<Property, int>> intSortExpression = null;
                        intSortExpression = Expression.Lambda<Func<Property, int>>(Expression.Property(param, sortField), param);
                        return IPropertyRepositery.ListProperties(intSortExpression, searchString, sortAsscending, pageSize, pageNo, agentId,
                                                                  propertyTypeId, contractTypeId, locationId, subLocationId, districtId, priceTo, priceFrom, isFeatured);
                        

                    default:
                        Expression<Func<Property, string>> stringSortExpression = null;
                        stringSortExpression = Expression.Lambda<Func<Property, string>>(Expression.Property(param, sortField), param);
                        return IPropertyRepositery.ListProperties(stringSortExpression, searchString, sortAsscending, pageSize, pageNo, agentId,
                                                                  propertyTypeId, contractTypeId, locationId, subLocationId, districtId, priceTo, priceFrom, isFeatured);
                        
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ListPropertiesCount(string searchString, int? agentId, int? propertyTypeId, int? contractTypeId, int? locationId, int? subLocationId,
                                       int? districtId, int? priceTo, int? priceFrom, bool isFeatured)
        {
            try
            {
                return IPropertyRepositery.ListPropertiesCount(searchString, agentId, propertyTypeId, contractTypeId, locationId, subLocationId,
                                                               districtId, priceTo, priceFrom, isFeatured);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Property> PropertiesList()
        {
            try
            {
                return IPropertyRepositery.PropertiesList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Property> BuildingsList()
        {
            try
            {
                return IPropertyRepositery.BuildingsList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        
    }

}
