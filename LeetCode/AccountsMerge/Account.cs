namespace AccountsMerge
{
    public class Account
    {
        public string Name { get; set; }
        public HashSet<string> Emails { get; set; }

        public Account(string name, IList<string> emails)
        {
            Name = name;
            Emails = new HashSet<string>(emails);
        }
    }
}
