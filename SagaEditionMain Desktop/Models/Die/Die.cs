namespace SagaEditionMain_Desktop.Models.Die
{
    class Die
    {

        private Random random = new Random(DateTime.Now.Day);
        public int Max { get; private set; }
        public Die(int max)
        {
            Max = max;
        }

        public int roll()
        {
            return random.Next(Max) + 1;
        }
    }

    public static class CommonDice
    {
        private static Die d20 = new Die(20);
        private static Die d12 = new Die(12);
        private static Die d10 = new Die(10);
        private static Die d8 = new Die(8);
        private static Die d6 = new Die(6);
        private static Die d4 = new Die(4);


        public static int rolld20()
        {
            return d20.roll();
        }
        public static int rolld12()
        {
            return d12.roll();
        }
        public static int rolld10()
        {
            return d10.roll();
        }
        public static int rolld8()
        {
            return d8.roll();
        }
        public static int rolld6()
        {
            return d6.roll();
        }
        public static int rolld4()
        {
            return d4.roll();
        }
    }
}
