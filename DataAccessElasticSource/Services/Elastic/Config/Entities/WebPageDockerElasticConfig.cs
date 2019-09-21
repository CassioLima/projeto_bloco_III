using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Services.Elastic.Config.Entities
{
    public class WebPageDockerElasticConfig : IElasticConfig
    {
        string IElasticConfig.IndexName => DataAccessElasticSource.Properties.Resources.ResourceManager.GetString("WebPageIndexName");

        string IElasticConfig.ElastisearchUrl => DataAccessElasticSource.Properties.Resources.ResourceManager.GetString("ElasticDockerComposeUrl");
    }
}
