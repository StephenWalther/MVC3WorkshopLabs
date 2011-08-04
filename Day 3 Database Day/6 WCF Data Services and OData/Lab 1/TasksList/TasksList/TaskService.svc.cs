using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Data.Objects;
using TasksList.Models;
using System.Data.Entity.Infrastructure;

namespace TasksList
{
    public class TaskService : DataService<ObjectContext>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            // config.SetEntitySetAccessRule("MyEntityset", EntitySetRights.AllRead);
            // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
            config.SetEntitySetAccessRule("Tasks", EntitySetRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        }

        protected override ObjectContext CreateDataSource()
        {
            var context = new TasksListDB();
            return ((IObjectContextAdapter)context).ObjectContext;
        }

    }
}
