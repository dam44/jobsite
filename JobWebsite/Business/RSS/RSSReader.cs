using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;

namespace Business
{
    public class RSSReader
    {
        public static int ReadFeed(Uri ao_uri, ref SyndicationFeed ao_feed)
        {
            try
            {
                XmlReader reader = XmlReader.Create(ao_uri.ToString());
                ao_feed = SyndicationFeed.Load(reader);
                reader.Close();
                return 1;

            }
            catch (Exception e)
            {
                return -1;
            }
        }
    }
}

