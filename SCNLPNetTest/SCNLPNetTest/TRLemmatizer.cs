using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkishDisambiguator;

namespace SCNLPNetTest
{
    class TRLemmatizer
    {
        TurkishLemmatizer tz;
        public TRLemmatizer()
        {
            tz = new TurkishLemmatizer(); 
        }
        public string getLemmas(string str)
        {
            return tz.Lemmatize(str);
        }
    }
}
