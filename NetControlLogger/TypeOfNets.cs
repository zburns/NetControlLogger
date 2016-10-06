using System;
using System.Collections.Generic;
using System.Text;

namespace NetControlLogger
{
    class TypeOfNets
    {
        public string NetScriptDirectory = null;
        public string[] NetScripts = null;

        public TypeOfNets()
        {
            NetScriptDirectory = System.IO.Directory.GetCurrentDirectory() + "Net Scripts";
            
            if (!System.IO.Directory.Exists(NetScriptDirectory))
            {
                System.IO.Directory.CreateDirectory(NetScriptDirectory);
            }

            NetScripts = System.IO.Directory.GetFiles(NetScriptDirectory, "*Script*.txt");
        }
    }
}
