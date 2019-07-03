namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class NullIterator : IIterator
    {
        public bool HasNext()
        {
            return false;
        }

        public object Next()
        {
            return null;
        }
    }
}