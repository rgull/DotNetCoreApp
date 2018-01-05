using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_DomainEntities;
using MVC_Common;
using System.Linq.Expressions;


namespace MVC_DAL
{
    public class PropertyRepositery : IPropertyRepositery
    {

        List<Property> Properties;

        public PropertyRepositery()
        {
            Properties = new List<Property>
            {
                new Property {
                     PropertyId = 1,
                     Title = "5160 Alzeda Dr",
                     Description = "La Mesa, CA 91941",
                     Price = 1265000 ,
                     PropertyTypeId = 1,
                     Bathrooms = 5,
                     Bedrooms = 6,
                     Area = 5656,
                     Ratings = 4,
                     Featured = true,
                     Latitude = "3.5 ",
                     Longitude = "4.6 ",
                     PropertyImage = "",
                     PropertyTypes = new PropertyType
                     {
                          PropertyTypeId = 1,
                          PropertyTypeName = "Commercial",
                     }
                },
                new Property {
                     PropertyId = 2,
                     Title = "5160 Alzeda Dr",
                     Description = "La Mesa, CA 91941",
                     Price = 1265000 ,
                     PropertyTypeId = 1,
                     Bathrooms = 5,
                     Bedrooms = 6,
                     Area = 5656,
                     Ratings = 4,
                     Featured = true,
                     Latitude = "3.5 ",
                     Longitude = "4.6 ",
                     PropertyImage = "",
                     PropertyTypes = new PropertyType
                     {
                          PropertyTypeId = 1,
                          PropertyTypeName = "Commercial",
                     }
                },
                new Property {
                     PropertyId = 3,
                     Title = "5160 Alzeda Dr",
                     Description = "La Mesa, CA 91941",
                     Price = 1265000 ,
                     PropertyTypeId = 1,
                     Bathrooms = 5,
                     Bedrooms = 6,
                     Area = 5656,
                     Ratings = 4,
                     Featured = true,
                     Latitude = "3.5 ",
                     Longitude = "4.6 ",
                     PropertyImage = "",
                     PropertyTypes = new PropertyType
                     {
                          PropertyTypeId = 1,
                          PropertyTypeName = "Commercial",
                     }
                },
                new Property {
                     PropertyId = 4,
                     Title = "5160 Alzeda Dr",
                     Description = "La Mesa, CA 91941",
                     Price = 1265000 ,
                     PropertyTypeId = 1,
                     Bathrooms = 5,
                     Bedrooms = 6,
                     Area = 5656,
                     Ratings = 4,
                     Featured = true,
                     Latitude = "3.5 ",
                     Longitude = "4.6 ",
                     PropertyImage = "",
                     PropertyTypes = new PropertyType
                     {
                          PropertyTypeId = 1,
                          PropertyTypeName = "Commercial",
                     }
                },
                new Property {
                     PropertyId = 5,
                     Title = "5160 Alzeda Dr",
                     Description = "La Mesa, CA 91941",
                     Price = 1265000 ,
                     PropertyTypeId = 1,
                     Bathrooms = 5,
                     Bedrooms = 6,
                     Area = 5656,
                     Ratings = 4,
                     Featured = true,
                     Latitude = "3.5 ",
                     Longitude = "4.6 ",
                     PropertyImage = "",
                     PropertyTypes = new PropertyType
                     {
                          PropertyTypeId = 1,
                          PropertyTypeName = "Commercial",
                     }
                }
            };             
        }

        #region Properties

        public int AddProperty(Property property)
        {
            try
            {
                //if Property already exists then return -1
                if (Properties.Where(x => x.Title == property.Title || x.Title_Fr == property.Title_Fr).Count() > 0)
                {
                    return -1;
                }
                else
                {
                    //Adding record into "Properties" table 
                    Properties.Add(property);
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return property.PropertyId;
        }

        public int EditProperty(Property newProperty)
        {
            try
            {
                Property CurrentProperty = Properties.Find(x=>x.PropertyTypeId == newProperty.PropertyId);

                if (CurrentProperty != null)
                {
                    CurrentProperty.Title = newProperty.Title;
                    CurrentProperty.Title_Fr = newProperty.Title_Fr;
                    CurrentProperty.Description = newProperty.Description;
                    CurrentProperty.Description_Fr = newProperty.Description_Fr;
                    CurrentProperty.Price = newProperty.Price;
                    CurrentProperty.PropertyTypeId = newProperty.PropertyTypeId;
                    

                    CurrentProperty.Bathrooms = newProperty.Bathrooms;
                    CurrentProperty.Bedrooms = newProperty.Bedrooms;
                    CurrentProperty.Area = newProperty.Area;
                    CurrentProperty.Ratings = newProperty.Ratings;
                    CurrentProperty.Featured = newProperty.Featured;
                    CurrentProperty.LocationSearch = newProperty.LocationSearch;

                    CurrentProperty.Latitude = newProperty.Latitude;
                    CurrentProperty.Longitude = newProperty.Longitude;
                    
                }

                return newProperty.PropertyId;
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
                //Deleting Info from "Property" table
                Property property = Properties.Where(x => x.PropertyId == Id).FirstOrDefault();
                if (property != null)
                    Properties.Remove(property);
                return true;
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
                return Properties.Find(x => x.PropertyId == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Property> ListProperties<TSortExpressType>(Expression<Func<Property, TSortExpressType>> sortExpression, string searchString,
                                                                      bool sortAsscending, int pageSize, int pageNo, int? agentId,
                                                                      int? propertyTypeId, int? contractTypeId, int? locationId, int? subLocationId,
                                                                      int? districtId, int? priceTo, int? priceFrom, bool isFeatured)
        {
            try
            {
                IQueryable<Property> query = null;

                int skipRecords = pageNo <= 1 ? 0 : (pageNo - 1) * pageSize;

                //Get Properties Against Specific PropertyTypeId
                if (propertyTypeId != null && propertyTypeId > 0)
                    query = query.Where(x => x.PropertyTypeId == propertyTypeId);

                //Get Properties Against Specific Price From
                if (priceFrom != null && priceFrom > 0)
                    query = query.Where(x => x.Price >= priceFrom);

                //Get Properties Against Specific Price To
                if (priceTo != null && priceTo > 0)
                    query = query.Where(x => x.Price <= priceTo);

                //Get Feature Properties
                if (isFeatured)
                    query = query.Where(x => x.Featured == true);

                //Searching Against Name
                if (searchString != null && !string.IsNullOrEmpty(searchString.Trim()))
                    query = query.Where(s => s.Title.ToUpper().Contains(searchString.ToUpper().Trim()) || s.Title_Fr.ToUpper().Contains(searchString.ToUpper().Trim()));

                //Sorting
                if (sortAsscending)
                    query = query.OrderBy(sortExpression).Skip(skipRecords).Take(pageSize);
                else
                    query = query.OrderByDescending(sortExpression).Skip(skipRecords).Take(pageSize);

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

         public int ListPropertiesCount(string searchString, int? agentId, int? propertyTypeId, int? contractTypeId, int? locationId,
                                       int? subLocationId, int? districtId, int? priceTo, int? priceFrom, bool isFeatured)
        {
            try
            {
                IQueryable<Property> query = null;

                query = Properties.AsQueryable();
                //Get Properties Against Specific Price From
                if (priceFrom != null && priceFrom > 0)
                    query = query.Where(x => x.Price >= priceFrom);

                //Get Properties Against Specific Price To
                if (priceTo != null && priceTo > 0)
                    query = query.Where(x => x.Price <= priceTo);

                //Get Feature Properties
                if (isFeatured)
                    query = query.Where(x => x.Featured == true);

                //Searching Against Name
                if (searchString != null && !string.IsNullOrEmpty(searchString.Trim()))
                    query = query.Where(s => s.Title.ToUpper().Contains(searchString.ToUpper().Trim()) || s.Title_Fr.ToUpper().Contains(searchString.ToUpper().Trim()));

                return query.Count();
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
                return Properties.ToList();
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
                return Properties.OrderByDescending(x => x.PropertyId).Where(x => x.PropertyTypeId == (int) PropertyTypesEnum.Building_Area).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion 

        

        
        

    }

}
