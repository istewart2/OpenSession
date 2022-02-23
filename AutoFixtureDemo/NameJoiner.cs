namespace AutoFixtureDemo
{
    public class NameJoiner
    {
        public string Join(string firstName, string lastName)
        {
            return firstName + ' ' + lastName;
        }

        public enum FormalTitle
        { 
            Dame,
            Dr,
            Lord,
            Madam,
            Professor,
            Sir
        }
    }
}
