namespace DesignPatternsLibrary.Singleton
{
    public class Policy_ThreadSafe_Solution1
    {
        private static readonly object _lock = new object();

        private static Policy_ThreadSafe_Solution1 _instance;

        public static Policy_ThreadSafe_Solution1 Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Policy_ThreadSafe_Solution1();
                    }
                    return _instance;
                }
            }
        }

        public Policy_ThreadSafe_Solution1()
        {

        }
        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";

        public string GetInsuredName() => Insured;
    }

    public class Policy_ThreadSafe_Solution2
    {
        //private static readonly object _lock = new object();

        private static readonly Policy_ThreadSafe_Solution2 _instance = new Policy_ThreadSafe_Solution2();

        public static Policy_ThreadSafe_Solution2 Instance
        {
            get
            {
                return _instance;
            }
        }

        public Policy_ThreadSafe_Solution2()
        {

        }
        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";

        public string GetInsuredName() => Insured;
    }

    public class Policy_ThreadSafe_Final
    {
        public static Policy_ThreadSafe_Final Instance { get; } = new Policy_ThreadSafe_Final();

        public Policy_ThreadSafe_Final()
        {

        }

        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";

        public string GetInsuredName() => Insured;
    }


}
