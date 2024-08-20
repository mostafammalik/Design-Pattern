namespace Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AccessToBankAccount Access = new AccessToBankAccount();    not allowed now 

            AccessToBankAccount acc = AccessToBankAccount.CreateObject();
            acc.id = 15;
            AccessToBankAccount acc2 = AccessToBankAccount.CreateObject();
            Console.WriteLine(acc2.id);

        }
    }


    public class AccessToBankAccount
        

    {
        public int id = 0;
        private static AccessToBankAccount _access;
        private AccessToBankAccount() //prevent using new KeyWord
        {

        }

        public static AccessToBankAccount CreateObject()
        {
            if (_access == null)
            {
                _access = new AccessToBankAccount();
            }
            return _access;
        }

    }
}
