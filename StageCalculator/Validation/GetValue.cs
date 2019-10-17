using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StageCalculator.Validation
{
    static class GetValue
    {
        public static bool GetString( this string InputParam, out string OutString)
        {
            bool IsNullOrEmpty = string.IsNullOrEmpty(InputParam);
            bool IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(InputParam);
            
            if (!IsNullOrEmpty&&!IsNullOrWhiteSpace&&InputParam.Length>2)
            {
                OutString = InputParam;
                return true;
            }
            else
            {
               // MessageBox.Show($"String is fuuuu:","Please enter a value.");
                OutString = "";
                return false;
                
            }
        }
    }
}
