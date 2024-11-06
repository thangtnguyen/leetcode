namespace StringToInteger
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            string trimmedValue = s.Trim();

            if (trimmedValue.Length == 0) return 0;

            bool isNegattive = trimmedValue[0] == '-';
                        
            Stack<int> stack = new Stack<int>();
            int i = 0;
            while (i < trimmedValue.Length)
            {
                if (i == 0 && (trimmedValue[i] == '-' || trimmedValue[i] == '+'))
                {
                    i++;
                    continue;
                }

                if (char.IsDigit(trimmedValue[i]))
                {
                    int value = Convert.ToInt32(trimmedValue[i].ToString());
                    if (value != 0 || stack.Count != 0)
                    {
                        stack.Push(value);                        
                    }
                    i++;
                }
                else
                {
                    break;
                }
            }

            long temp = 0;
            int numberOfDigits = stack.Count;
            for (int j = 0; j < numberOfDigits; j++)
            {
                temp += (long)(stack.Pop() * Math.Pow(10, j));
                if (temp > int.MaxValue)
                {
                    temp = int.MaxValue;
                    break;
                }
            }

            temp = (isNegattive ? -temp : temp);
            temp = (temp < int.MinValue ? int.MinValue : temp);

            return (int)temp;
        }
    }
}
