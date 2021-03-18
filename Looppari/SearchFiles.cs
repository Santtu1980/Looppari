using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looppari
{
    public class SearchFiles
    {
        /// <summary>
        /// Number of all files looped throught.
        /// Does NOT contain ignored folders.
        /// </summary>
        public int AllFilesFound { get; set; } = 0;
        /// <summary>
        /// Number of files ignored in bin folders
        /// </summary>
        public int AllBinFolderFilesIgnored { get; set; } = 0;
        /// <summary>
        /// Number of files ignored in obj folders
        /// </summary>
        public int AllObjFolderFilesIgnored { get; set; } = 0;
        /// <summary>
        /// Number of designer files
        /// </summary>
        public int AllDesignerFilesIgnored { get; set; } = 0;
        /// <summary>
        /// Loop all folders recursive and adds all .cs-filepaths to return array.
        /// </summary>
        /// <param name="sDir">Root folder</param>
        /// <param name="ignoreBin">if true, skip folders that contains bin in folder path</param>
        /// <param name="ignoreObj">if true, skip folders that contains obj in folder path</param>
        /// <returns></returns>
        public List<string> DirSearch(string sDir, bool ignoreBin, bool ignoreObj, bool ignoreDesigner)
        {
            List<string> PathsToAllCsFilesFound = new List<string>();
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        if (ignoreBin && f.ToUpper().Contains("BIN"))
                        {
                            AllBinFolderFilesIgnored++;
                            continue; 
                        }
                        if (ignoreObj && f.ToUpper().Contains("OBJ"))
                        {
                            AllObjFolderFilesIgnored++;
                            continue;
                        }
                        if(ignoreDesigner && f.ToUpper().EndsWith(".DESIGNER.CS"))
                        {
                            AllDesignerFilesIgnored++;
                            continue;
                        }

                        if (Path.GetExtension(f).Equals(".cs"))
                            PathsToAllCsFilesFound.Add(f);
                        AllFilesFound++;
                    }
                    DirSearch(d, ignoreBin, ignoreObj, ignoreDesigner);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return PathsToAllCsFilesFound;
        }
    }
}
