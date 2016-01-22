using Business.RSS;
using Business.Util;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobWebsite.Sandbox
{
    public class InvokeTester
    {
        public void TryInvoke(string dllpath)
        {
            ImportFeed lo_feedimporter = new ImportFeed();
            Job[] jobs = new Job[1];
            IFeedConverter feedconverter = InvokeDLL.ExportType<IFeedConverter>(dllpath, "FeedConverter.TestConverter");
            Feed feed = new Feed();
            feed.id = 1;
            feed.url = new Uri("http://www.prospects.ac.uk/rss/All_graduate_jobs.rss");
            lo_feedimporter.Import(ref jobs, feed, feedconverter);
        }
    }
}
