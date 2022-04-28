using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace Updater
{
    public class UpdateChecker
    {
        GitHubClient client;
        StampedValue<Release> release;

        public UpdateChecker()
        {
            var productHeader = new ProductHeaderValue("AutoHybernateAndWake", Environment.Version.ToString());
            client = new GitHubClient(productHeader);
        }

        public async Task<bool> LookForUpdateAsync(Version currentVersion)
        {
        
            if (latest.TagName != String.Format("{0}.{1}.{2}", currentVersion.Major, currentVersion.Minor, currentVersion.Revision))
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Update()
        {

        }

        Release GetLatest()
        {
            if(release == null)
            {
                var latest = client.Repository.Release.GetLatest(Convert.ToInt64(TextMaster.RepoID)).GetAwaiter().GetResult();
            }
        }
    }
}
