using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_DomainEntities;
using MVC_DAL;
using System.Linq.Expressions;

namespace MVC_BLL
{
    public class AgentService : IAgentService
    {
        IAgentRepositery IAgentRepositery;

        public AgentService(IAgentRepositery IAR)
        {
            IAgentRepositery = IAR;
        }

        public int AddAgent(Agent agent)
        {
            try
            {
                return IAgentRepositery.AddAgent(agent);
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
                return IAgentRepositery.AgentsList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Agent> ListAgents(string sortField, bool sortAsscending, string searchString, int pageSize, int pageNo, int? agencyId)
        {
            try
            {
                var param = Expression.Parameter(typeof(Agent));

                switch (sortField)
                {
                    case "AgentId":
                        {
                            Expression<Func<Agent, int>> intSortExpression = null;
                            intSortExpression = Expression.Lambda<Func<Agent, int>>(Expression.Property(param, sortField), param);
                            return IAgentRepositery.ListAgents(intSortExpression, searchString, sortAsscending, pageSize, pageNo, agencyId);
                            
                        }
                       

                    default:
                        {
                            Expression<Func<Agent, string>> stringSortExpression = null;
                            stringSortExpression = Expression.Lambda<Func<Agent, string>>(Expression.Property(param, sortField), param);
                            return IAgentRepositery.ListAgents(stringSortExpression, searchString, sortAsscending, pageSize, pageNo, agencyId);
                            
                        }
                }

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
                return IAgentRepositery.ListAgentsCount(searchString, agencyId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Agent GetAgentById(int? Id)
        {
            try
            {
                return IAgentRepositery.GetAgentById(Id);
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
                return IAgentRepositery.DeleteAgent(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EditAgent(Agent agent)
        {
            try
            {
                return IAgentRepositery.EditAgent(agent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
