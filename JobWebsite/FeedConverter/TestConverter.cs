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
            Console.WriteLine(Id() + " called!");
            return new Job[1];
        }

        public string Id()
        {
            return "TestConverter";
        }
    }
}
