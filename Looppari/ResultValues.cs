using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looppari
{
    public class ResultValues
    {
        public int AmountOfFiles { get; set; } = 0;
        public int MostRows { get; set; } = 0;
        public string MostRowsFileName { get; set; } = "";
        public int AmountOfShortFiles { get; set; } = 0;
        public int AmountOfMediumFiles { get; set; } = 0;
        public int AmountOfLongFiles { get; set; } = 0;
        public int AmountOfAllRows { get; set; } = 0;
        public int AmountOfAllCommentedRows { get; set; } = 0;
        public int AmountOfAllMethodDescriptionRows { get; set; } = 0;
        public int AmountOfAllCommentedCodeRows { get; set; } = 0;
        public decimal AverageAmountOfRowsInFile { get; set; } = 0;
    }
}
