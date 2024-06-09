namespace MethodsExercise
{
    public class Program
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }
        public static int Modulus(int x, int y)
        {
            return x % y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("I will show you some numbers!");

            int added = Add(1, 3, 5, 7, 9);
            int sub = Subtract(6, 2);
            int mult = Multiply(8, 11);
            int div = Divide(12, 3);
            int mod = Modulus(14, 3);

            Console.WriteLine($"1 + 3 + 5 + 7 + 9 = {added}");
            Console.WriteLine($"6 - 2 = {sub}");
            Console.WriteLine($"8 * 11 = {mult}");
            Console.WriteLine($"14 / 3 = {div}");
            Console.WriteLine($"14 % 3 = {mod}");

            Console.WriteLine("Now, what is your name?");

            var name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! What's your favorite color?");

            var color = Console.ReadLine();

            Console.WriteLine($"Great! I like {color} too. How about a favorite food?");

            var food = Console.ReadLine();

            Console.WriteLine("Yum! Two more things. Tell me your favorite season.");

            var season = Console.ReadLine();

            Console.WriteLine("Fantastic. Finally, please share a book you enjoy.");

            var book = Console.ReadLine();

            Console.WriteLine("Amazing! I've written a story about you.\n" +
                $"Once there was a human named {name}. {name} loved eating {color} {food}.\n" +
                $"But one unusually cold {season} day, {name} couldn't find any {food}!\n" +
                $"{name} also couldn't find any {color} food at all! So {name} wandered around downtown.\n" +
                $"After what seemed like forever, {name} gave up and grabbed a less delightful snack.\n" +
                $"Then they happened across a bookstore. Much to {name}'s surprise, there was a book signing event for {book}!\n" +
                $"{book} was {name}'s favorite book. 'OMG, what luck!' they thought to themselves.\n" +
                $"In the end, {name} couldn't eat any {color} {food} today. But they had the next best thing: a signed copy of {book}.\n" +
                $"And {name} lived happily ever after 'till the end of their days.");

            Console.WriteLine("So, what did you think? Did I get it right? Please answer yes or no.");

            var like = Console.ReadLine();

            if (like == "no")
            {
                Console.WriteLine($"Oh! I'm sorry, {name}. I'll do better next time!");
             }
            else if (like == "yes")
            {
                Console.WriteLine($"Amazing! Thank you, {name}! Your praise makes this bot happy!");
             }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand. Well, thanks and see you next time!");
            }

        }
    }
}
