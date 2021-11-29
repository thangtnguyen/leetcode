namespace AccountsMerge
{
    internal class Solution
    {
        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            // Converts to List of Accounts
            var accountList = ConvertToAccounts(accounts);

            // Merges 
            var mergedAccount = MergeAccounts(accountList);

            // Converts to List of string with sorted emails
            return ConvertToList(mergedAccount);
        }

        private IList<IList<string>> ConvertToList(IList<Account> accounts)
        {
            IList<IList<string>> result = new List<IList<string>>();

            foreach (var account in accounts)
            {
                List<string> stringAccount = new List<string>();
                stringAccount.Add(account.Name);
                var emailList = account.Emails.ToList();
                emailList.Sort(StringComparer.Ordinal);
                stringAccount.AddRange(emailList);
                result.Add(stringAccount);
            }

            return result;
        }

        private IList<Account> MergeAccounts(IList<Account> accounts)
        {
            IList<Account> result = new List<Account>();
            var handledList = new List<Account>();

            foreach (var account in accounts)
            {
                if (!handledList.Contains(account))
                {
                    var sameNameAccounts = accounts.Where(p => p.Name == account.Name && p != account);
                    if (sameNameAccounts.Any())
                    {

                        int i = 0;

                        while (i < sameNameAccounts.Count())
                        {
                            var account2 = sameNameAccounts.ElementAt(i);
                            if (!handledList.Contains(account2) && account.Emails.Overlaps(account2.Emails))
                            {
                                account.Emails.UnionWith(account2.Emails);
                                handledList.Add(account2);
                                i = 0;
                            }
                            else
                            {
                                ++i;
                            }
                        }
                    }

                    result.Add(account);
                    handledList.Add(account);
                }
            }

            return result;
        }

        private IList<Account> ConvertToAccounts(IList<IList<string>> accounts)
        {
            List<Account> result = new List<Account>();

            foreach (var account in accounts)
            {
                var name = account[0];
                var emails = account.Skip(1).ToList();
                result.Add(new Account(name, emails));
            }

            return result;
        }
    }
}
