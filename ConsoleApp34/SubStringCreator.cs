namespace ConsoleApp34
{
    public class SubStringCreator
    {
        public int pFrom;
        public int pTo;

        public string Create(string function)
        {
            return function.Substring(pFrom, pTo - pFrom);
        }
    }
}
