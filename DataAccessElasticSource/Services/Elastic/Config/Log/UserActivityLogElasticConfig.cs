using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Services.Elastic.Config.Log
{
    public class UserActivityLogElasticConfig : IElasticConfig
    {
        string IElasticConfig.IndexName => DataAccessElasticSource.Properties.Resources.ResourceManager.GetString("UserActivityLogIndexName");

        string IElasticConfig.ElastisearchUrl => DataAccessElasticSource.Properties.Resources.ResourceManager.GetString("ElasticsearchUrl");
    }
}
