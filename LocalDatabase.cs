using System;
using System.Collections.Generic;
using System.Text;

namespace NetControlLogger
{
    class LocalDatabase
    {
        static public string LookupInDatabase(string CallSign)
        {
            try
            {
                if (!System.IO.File.Exists("NetControlCheckIns.txt"))
                {
                    System.IO.TextWriter output = System.IO.File.CreateText("NetControlCheckIns.txt");
                    output.WriteLine("; This file is created automatically if one doesn't exist.  You can keep deleting it, but it will keep coming back!");
                    output.WriteLine("; ");
                    output.WriteLine("; The purpose of this file is to simply track the check-ins to your net.");
                    output.WriteLine("; This is a tab-delimited file. And lines with comments start with a ';', otherwise, the file is simply tab delimited as follows...");
                    output.WriteLine("; CallSign\tTactical Call Sign\tName\tStatus\tLocation\tNotes");
                    output.WriteLine("N8ZAK\t\tZachary Burns\tFixed\tPerrysburg, OH\tNickname: Zack");
                    output.Flush();
                    output.Close();
                    output.Dispose();
                    output = null;
                    return null;
                }
                else
                {
                    System.IO.TextReader input = System.IO.File.OpenText("NetControlCheckIns.txt");
                    string[] parse = null;
                    string[] foundline = null;
                    //handle this based on format
                    string line = null;
                    while ((line=input.ReadLine())!=null)
                    {
                        foundline = null;
                        if (!line.Contains(";"))
                        {
                            parse = line.Split('\t');
                            if (parse.Length == 6)
                            {
                                //ok - looks good
                                if (CallSign.ToUpper() == parse[0].ToUpper())
                                {
                                    foundline = parse;
                                    break;
                                }
                            }
                        }
                    }
                    input.Close();
                    input.Dispose();
                    input = null;

                    if (foundline != null)
                        return foundline[0].ToUpper();
                    else
                        return null;
                }
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
    }
}
