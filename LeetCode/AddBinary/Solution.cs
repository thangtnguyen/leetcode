namespace AddBinary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            string result = string.Empty;
            int aIndex = a.Length - 1;
            int bIndex = b.Length - 1;
            char carry = '0';

            while (aIndex >= 0 && bIndex >=0)
            {
                var binResult = Add(a[aIndex], b[bIndex], carry);
                if (binResult.Length == 2)
                {
                    result = result.Insert(0, binResult[1].ToString());
                    carry = binResult[0];
                }
                else
                {
                    result = result.Insert(0, binResult);
                    carry = '0';
                }
                --aIndex; 
                --bIndex;
            }

            int p = -1;
            string stringP = string.Empty;
            if (aIndex >= 0)
            {
                p = aIndex;
                stringP = a;
            }
            else if (bIndex >= 0)
            {
                p = bIndex;
                stringP = b;
            }
            while (p >= 0)
            {
                var binResult = Add('0', stringP[p], carry);
                if (binResult.Length == 2)
                {
                    result = result.Insert(0, binResult[1].ToString());
                    carry = binResult[0];
                }
                else
                {
                    result = result.Insert(0, binResult);
                    carry = '0';
                }
                --p;
            }
            if (carry == '1')
            {
                result = result.Insert(0, carry.ToString());
            }

            return result;
        }

        private string Add(char a,  char b, char carry = '0')
        {
            if (a == '0' && b == '0')
            {
                if (carry == '1')
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            else if (a == '1' && b == '1')
            {
                if (carry == '1')
                {
                    return "11";
                }
                else
                {
                    return "10";
                }
            }
            else
            {
                if (carry == '1')
                {
                    return "10";
                }
                else
                {
                    return "1";
                }
            }
        }
    }
}
