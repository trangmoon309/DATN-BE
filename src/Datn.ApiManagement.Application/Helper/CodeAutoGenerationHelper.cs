using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn.ApiManagement.Helpers
{
    public static class CodeAutoGenerationHelper
    {
        public static string GetNextCode<T>(List<T> listItems, string prefix, int codeLength)
        {
            var firstItem = listItems.FirstOrDefault();
            var isHasIsDeletedProperty = false;
            var isHasCodeProperty = false;

            if(firstItem != null)
            {
                if (firstItem.GetType().GetProperty("IsDeleted") != null) isHasIsDeletedProperty = true;
                if (firstItem.GetType().GetProperty("Code") != null) isHasCodeProperty = true;
            }

            var lastItem = listItems.WhereIf(isHasIsDeletedProperty, x => !Convert.ToBoolean(x.GetType().GetProperty("IsDeleted").GetValue(x)))
                                    .WhereIf(isHasCodeProperty,x => x.GetType().GetProperty("Code").GetValue(x).ToString().Substring(0, prefix.Length) == prefix)
                                    .OrderByDescending(x => Convert.ToInt32(x.GetType().GetProperty("Code").GetValue(x).ToString().Substring(prefix.Length)))
                                    .FirstOrDefault();

            if (lastItem != null)
            {
                var lastItemCode = lastItem.GetType().GetProperty("Code").GetValue(lastItem).ToString();

                if(lastItemCode.Length == (prefix.Length + codeLength))
                {
                    int lastCode = 0;
                    if (int.TryParse(lastItemCode.Remove(0, prefix.Length), out lastCode))
                    {
                        int nextCode = lastCode + 1;

                        string zeroPrefix = "";
                        for (int i = 1; i <= codeLength - 1; i++)
                        {
                            if (nextCode < Math.Pow(10, i))
                            {
                                for (int j = 1; j <= codeLength - i; j++)
                                {
                                    zeroPrefix += "0";
                                }

                                return prefix + zeroPrefix + nextCode;
                            }
                        }
                    }
                }
            }

            var preZeros = string.Empty;
            for (int i = 0; i < codeLength - 1; i++) preZeros += "0";
            return prefix + preZeros + "1";
        }
    }
}
