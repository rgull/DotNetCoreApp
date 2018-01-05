using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_DomainEntities;
using System.Linq.Expressions;

namespace MVC_DAL
{

    public interface IAgentRepositery
    {

        int AddAgent(Agent agent);

        int EditAgent(Agent agent);

        bool DeleteAgent(int? Id);

        Agent GetAgentById(int? Id);

        IEnumerable<Agent> ListAgents<TSortExpressType>(Expression<Func<Agent, TSortExpressType>> sortExpression, string searchString, bool sortAsscending, int pageSize, int pageNo, int? AgencyId);

        int ListAgentsCount(string searchString, int? AgencyId);

        IEnumerable<Agent> AgentsList();

    }

}
