using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoBuyer
{
    public class JDBuyerJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            while (true)
            {
                JDBuyer.ToClick();
            }
        }
    }
}
