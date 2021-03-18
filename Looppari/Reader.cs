using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looppari
{
    public class Reader
    {        
        /// <summary>
        /// Reads all the files given in parameter
        /// Calculates needed values to Result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ReadFiles(object sender, DoWorkEventArgs e)
        {
            object[] parameters = e.Argument as object[];
            if (parameters.Length == 0) e.Result = null;
            // Parameters
            var filePaths = (List<string>)parameters[0];
            var maximumRowsInShortFile = 300;
            var maximumRowsInMediumFile = 700;
            if (parameters.Length >= 2) int.TryParse(parameters[1].ToString(), out maximumRowsInShortFile);
            if (parameters.Length >= 3) int.TryParse(parameters[2].ToString(), out maximumRowsInMediumFile);

            var result = new ResultValues();
            result.AmountOfFiles = filePaths.Count;
            //loop all files
            foreach (var filePath in filePaths)
            {
                if (!File.Exists(filePath)) continue;

                string[] readText = File.ReadAllLines(filePath);
                var amountOfRowsInFile = readText.Length;
                result.AmountOfAllRows += amountOfRowsInFile;
                // Find out the longest file
                if (amountOfRowsInFile > result.MostRows)
                {
                    result.MostRows = amountOfRowsInFile;
                    result.MostRowsFileName = filePath;
                }

                if (amountOfRowsInFile < maximumRowsInShortFile) result.AmountOfShortFiles++;
                else if (amountOfRowsInFile >= maximumRowsInShortFile && amountOfRowsInFile < maximumRowsInMediumFile) result.AmountOfMediumFiles++;
                else result.AmountOfLongFiles++;

                foreach (string s in readText)
                {
                    if (s.TrimStart().StartsWith(("//")))
                    {
                        result.AmountOfAllCommentedRows++;
                        if (s.TrimStart().StartsWith("///"))
                            result.AmountOfAllMethodDescriptionRows++;
                        if (s.TrimEnd().EndsWith(";"))
                            result.AmountOfAllCommentedCodeRows++;

                    }
                }
            }

            result.AverageAmountOfRowsInFile = Math.Round((filePaths.Count == 0) ? 0 : (decimal)result.AmountOfAllRows / (decimal)filePaths.Count, 1);
            e.Result = result;
        }
    }
}

