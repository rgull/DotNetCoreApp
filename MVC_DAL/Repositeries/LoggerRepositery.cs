using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_DomainEntities;

namespace MVC_DAL
{
    public class LoggerRepositery : ILoggerRepositery
    {
        

        public LoggerRepositery()
        {
           
        }        

        public void AddLogger(string ErrorDesc, string ErrorStack)
        {
            try
            {
                Logger logger = new Logger();
                logger.ErrorDesc = ErrorDesc;
                logger.ErrorStack = ErrorStack;
                logger.ErrorDate = DateTime.Now;
               
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

    }
}
