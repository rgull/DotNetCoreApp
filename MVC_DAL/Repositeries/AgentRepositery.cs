using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_DomainEntities;
using System.Linq.Expressions;

namespace MVC_DAL
{

    public class AgentRepositery : IAgentRepositery
    {        
        List<Agent> Agents;

        public AgentRepositery()
        {
            Agents = new List<Agent>
            {
                new Agent {
                    AgentId = 1,                  
                    FirstName = "Melissa",
                    LastName = "Crosby",                    
                    CompanyName = "Houses For Sale",
                    Ratings = 4.5,      
                    MobilePhone = " ",
                    OfficePhone = " ",        
                    Email = "user@house.forsale",
                    Description = "Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes. I strive to exceed expectations and never forget that I am always accountable to my clients. My objective is to establish relationships for life, not just for the current transaction.I enjoy assisting home buyers and sellers to get moved to a better place, one that is exciting.  ", 
                    Address1 = "Berkshire Hathaway HomeServices Elite Real Estate",                    
                    Address2 = " ",                   
                    ProfileImage = "//abc.png "
                },
                new Agent {
                    AgentId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    CompanyName = "Houses For Sale",
                    Ratings=5,
                    MobilePhone = " ",
                    OfficePhone = " ",
                    Email = "user@house.forsale",
                    Description = "Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes. I strive to exceed expectations and never forget that I am always accountable to my clients. My objective is to establish relationships for life, not just for the current transaction.I enjoy assisting home buyers and sellers to get moved to a better place, one that is exciting.  ",
                    Address1 = "Berkshire Hathaway HomeServices Elite Real Estate",
                    Address2 = " ",
                    ProfileImage = "//abc.png "
                }
            };

        }

        public int AddAgent(Agent Agent)
        {
            try
            {
                //if agent already exists then return -1
                if (Agents.Where(x => x.FirstName == Agent.FirstName ).Count() > 0)
                {
                    return -1;
                }
                else
                {
                    Agents.Add(Agent);                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Agent.AgentId;
        }

        public int EditAgent(Agent newAgent)
        {
            try
            {
                Agent CurrentAgent = Agents.Find(x=> x.AgentId == newAgent.AgentId);

                CurrentAgent.FirstName = newAgent.FirstName;
                
                CurrentAgent.LastName = newAgent.LastName;
                
                CurrentAgent.CompanyName = newAgent.CompanyName;
               
                CurrentAgent.MobilePhone = newAgent.MobilePhone;
                CurrentAgent.OfficePhone = newAgent.OfficePhone;
                CurrentAgent.Email = newAgent.Email;
                CurrentAgent.Description = newAgent.Description;
                

                CurrentAgent.Address1 = newAgent.Address1;
               
                CurrentAgent.Address2 = newAgent.Address2;
               
                CurrentAgent.ProfileImage = newAgent.ProfileImage;
                
                return newAgent.AgentId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteAgent(int? Id)
        {
            try
            {
                //Deleting Info from "AgencyProperties" table
                

                //Deleting Info from "Agents" table
                Agent Agent = Agents.Where(x => x.AgentId == Id).FirstOrDefault();
                if (Agent != null)
                    Agents.Remove(Agent);

              
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Agent GetAgentById(int? id)
        {
            try
            {
                return Agents.Find(x => x.AgentId == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Agent> ListAgents<TSortExpressType>(Expression<Func<Agent, TSortExpressType>> sortExpression, string searchString, bool sortAsscending, int pageSize, int pageNo, int? agencyId)
        {
            try
            {
                IQueryable<Agent> query = null;

                int skipRecords = pageNo <= 1 ? 0 : (pageNo - 1) * pageSize;

               

                //Searching Against Name
                if (searchString != null && !string.IsNullOrEmpty(searchString.Trim()))
                    query = query.Where(s => s.FirstName.ToUpper().Contains(searchString.ToUpper().Trim()) || s.LastName.ToUpper().Contains(searchString.ToUpper().Trim()));

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

        public int ListAgentsCount(string searchString, int? agencyId)
        {
            try
            {
                IQueryable<Agent> query = null;

               
                //Searching Against Name
                if (searchString != null && !string.IsNullOrEmpty(searchString.Trim()))
                    query = query.Where(s => s.FirstName.ToUpper().Contains(searchString.ToUpper().Trim()) || s.LastName.ToUpper().Contains(searchString.ToUpper().Trim()));

                return query.Count();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Agent> AgentsList()
        {
            try
            {
                return Agents.OrderByDescending(x => x.AgentId).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
