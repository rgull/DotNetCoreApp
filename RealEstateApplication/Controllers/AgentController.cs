using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_DomainEntities;
using MVC_BLL;
using MVC_Common;

namespace RealEstateApplication.Controllers
{
    public class AgentController : Controller
    {
       
        private IAgentService IAgentService;
        private IPropertyService IPropertyService;
        private ILoggerService ILoggerService;
        public AgentController(IAgentService IAgent, IPropertyService IPS, ILoggerService ILog)
        {
            IAgentService = IAgent;           
            IPropertyService = IPS;
            ILoggerService = ILog;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}