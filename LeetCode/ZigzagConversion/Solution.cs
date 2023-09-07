using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagConversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            List<List<string>> list = new List<List<string>>();

            int rowIndex = 0; // < numRows - 1
            int columnIndex = 0; // < numRows
            int group = 2 * (numRows - 1);
            List<string> charList = new List<string>();

            if (numRows > 1) 
            {
                for (int j = 0; j < s.Length; j++)
                {
                    int currentRowIndex = rowIndex % (numRows - 1);
                    if (currentRowIndex == 0)
                    {
                        if (columnIndex == 0)
                        {
                            charList = new List<string>(numRows)
                        {
                            s[j].ToString()
                        };
                            ++columnIndex;
                            if (j == s.Length - 1)
                            {
                                for (int k = columnIndex; k < numRows; k++)
                                {
                                    charList.Add(string.Empty);
                                }
                                list.Add(charList);
                            }
                        }
                        else if (columnIndex == numRows - 1)
                        {
                            charList.Add(s[j].ToString());
                            columnIndex = 0;
                            ++rowIndex;
                            list.Add(charList);
                        }
                        else
                        {
                            charList.Add(s[j].ToString());
                            ++columnIndex;
                            if (j == s.Length - 1)
                            {
                                for (int k = columnIndex; k < numRows; k++)
                                {
                                    charList.Add(string.Empty);
                                }
                                list.Add(charList);
                            }
                        }
                    }
                    else
                    {
                        charList = new List<string>(numRows);
                        for (int i = 0; i < numRows; i++)
                        {
                            if (i == numRows - 1 - (currentRowIndex))
                            {
                                charList.Add(s[j].ToString());
                            }
                            else
                            {
                                charList.Add(string.Empty);
                            }
                        }
                        list.Add(charList);
                        ++rowIndex;
                    }
                }

                StringBuilder result = new StringBuilder();
                for (int i = 0; i < numRows; i++)
                {
                    foreach (var item in list)
                    {
                        result.Append(item[i]);
                    }
                }

                return result.ToString();
            }
            else
            {
                return s;
            }
        }
    }
}
