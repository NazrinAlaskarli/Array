namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FindFaktorial(number));

            Console.WriteLine(CheckPalindrome());

        }
        static int FindFaktorial(int number)
        {
            int product = 1;
            for (int i = number; i >= 1; i--)
            {
                product = product * i;
            }
            return product;
        }
        //static int PalindromeNumber(int number)
        //{
        //    int reversed = 0;
        //    int number2 = number;
        //    while (number2 > 0)
        //    {
        //        reversed=( reversed*10)+(number2%10);
        //        number2 /= 10;
        //    }
        //    if()




        static void CheckPalindrome(int number)
        {
            int rem = 0;
            int reversed = 0;
            while (number > 0)
            {
                rem = number % 10;
                rem = rem * 10 + rem;
            }
            if (number == reversed)
            {
                Console.WriteLine("eded palindromdur");

            }
            else
            {
                Console.WriteLine("eded palindrom deyil");
            }



        }
        int[] arr = { 1, 5, 3, 9 };
        int IndexOfMax = 0, IndexOfMin = 0;
        int[]max = arr [0];
        int[] min = arr [0];

        int temp;
        int


















































    }
}
}