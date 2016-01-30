using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace FeedConverter
{
    [Serializable]
    public class TestConverter : MarshalByRefObject, Business.RSS.IFeedConverter
    {
        public Job[] Convert(SyndicationFeed feed)
        {
            Job[] lo_jobs = new Job[feed.Items.Count()];
            int i = 0;
            foreach (SyndicationItem item in feed.Items)
            {
                lo_jobs[i] = new Job();
                lo_jobs[i].description = item.Summary.Text;
                lo_jobs[i].joblink = new Uri(item.Id);
                i++;
            }
       
            return lo_jobs;
        }

        public string Id()
        {
            return "TestConverter";
        }
    }
}


///(\d*)} group 1, for job id, taken from job link.