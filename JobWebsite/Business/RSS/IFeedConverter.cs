using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace Business.RSS
{
    public interface IFeedConverter
    {
        string Id();
        Job[] Convert(SyndicationFeed feed);
    }
}
