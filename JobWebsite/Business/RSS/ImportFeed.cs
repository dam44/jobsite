using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq;
using System.Web;
using JobWebsite.Models;
using Model;

namespace Business.RSS
{
    public class ImportFeed
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public int Import(ref Job[] ao_jobs, Feed ao_feed, IFeedConverter ao_converter)
        {
            return DoImport(ref ao_jobs, ao_feed.url, ao_converter);
        }

        private int DoImport(ref Job[] ao_jobs, Uri ao_url, IFeedConverter ao_converter)
        {
            try
            {
                SyndicationFeed lo_feed = new SyndicationFeed();
                RSSReader.ReadFeed(ao_url, ref lo_feed);
                ao_jobs = ao_converter.Convert(lo_feed);
                return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
    }
}
