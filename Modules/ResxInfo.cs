using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CrossplatformTestToolKit.Modules
{
    /// <summary>
    /// This class is used to contain methods concerning resx info
    /// </summary>
    public class ResxInfo
    {
        /// <summary>
        /// This method is used to get the count of data in a resx translation file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public int GetDataCount(string path)
        {
            string resFilePath = path;
            int count = 0;
            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    // Looking for the start of an element named "data"
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "data")
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
