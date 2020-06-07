using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoBuyer
{
    public class BuyerQuartz
    {
        public async Task CreateAJobAsync() 
        {
            IScheduler scheduler;
            //调度器工厂
            ISchedulerFactory factory;

            //创建一个调度器
            factory = new StdSchedulerFactory();
            scheduler = await factory.GetScheduler();


            IJobDetail job = JobBuilder.Create<JDBuyerJob>().WithIdentity("job1", "group1").Build();
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .WithCronSchedule("58 59 09 * * ? *")
                //.WithCronSchedule("00 17 23 * * ? *")
                .Build();

            await scheduler.ScheduleJob(job, trigger);
            //5、开始执行
            await scheduler.Start();


            //if (scheduler != null)
            //{
            //    await scheduler.Shutdown(true);
            //}
        }

        //public void s()
        //{
        //    IScheduler scheduler;
        //    //调度器工厂
        //    ISchedulerFactory factory;

        //    //创建一个调度器
        //    factory = new StdSchedulerFactory();
        //    scheduler = await factory.GetScheduler();


        //    IJobDetail job = JobBuilder.Create<JDBuyerJob>().WithIdentity("job1", "group1").Build();
        //    ITrigger trigger = TriggerBuilder.Create()
        //        .WithIdentity("trigger1", "group1")
        //        .WithCronSchedule("58 59 23 * * ? *")
        //        //.WithCronSchedule("00 17 23 * * ? *")
        //        .Build();

        //    await scheduler.ScheduleJob(job, trigger);
        //    //5、开始执行
        //    await scheduler.Start();


        //    //if (scheduler != null)
        //    //{
        //    //    await scheduler.Shutdown(true);
        //    //}
        //}

    }
}
