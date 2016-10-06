using System;
using System.Collections.Generic;
using System.Text;

namespace NetControlLogger
{
    class OnlineDatabase
    {
        static public string LookupInDatabase(string CallSign)
        {
            try
            {
                throw new System.NotImplementedException("Lookup via QRZ or FCC");
                
                //tie into the fcc database if there is a network connection - this is THE official place, and QRZ will actually let you add data whereas I'd like to be 100% legit

                return null;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
    }
}
