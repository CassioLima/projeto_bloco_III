using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Services.Elastic.Config.Log
{
    public class SystemActivityLogElasticConfig : IElasticConfig
    {
        string IElasticConfig.IndexName => DataAccessElasticSource.Properties.Resources.ResourceManager.GetString("SystemActivityLogIndexName");

        string IElasticConfig.ElastisearchUrl => DataAccessElasticSource.Properties.Resources.ResourceManager.GetString("ElasticsearchUrl");
    }
}
