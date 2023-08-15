using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossplatformTestToolKit.Modules
{
    public class DllFileOperator
    {
        /// <summary>
        /// This PUBLIC method check folder A and folder B and compare the dll file name to look for the ones that only exist in folder A but missing in folder B
        /// </summary>
        /// <param name="folderA"></param>
        /// <param name="folderB"></param>
        public void DllExistInFolderAButNotInFolderB(string folderA, string folderB)
        {
            List<string> filesInA = GetDllFiles(folderA);
            List<string> filesInB = GetDllFiles(folderB);

            Console.WriteLine("DLL files present in A but not in B: ");
            int count = 0;

            foreach (string file in filesInA.Except(filesInB))
            {
                Console.WriteLine(file);
                count++;
            }
            Console.WriteLine("Result: There are " + count + " DLL files that present in A but not in B");
        }

        /// <summary>
        /// This PRIVATE method check a directory and returns a list of dll files under it.
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns>list of dll file name string</returns>
        private List<string> GetDllFiles(string folderPath)
        {
            List<string> dllFiles = new List<string>();
            string[] files = Directory.GetFiles(folderPath, "*.dll");
            foreach (string file in files)
            {
                dllFiles.Add(Path.GetFileName(file));
            }
            return dllFiles;
        }
    }
}
