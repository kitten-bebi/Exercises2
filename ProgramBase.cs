internal class ProgramBase
{
    static void Main()
    {
        Console.WriteLine("17 Check Number in Array ---");


        int[] nums = [1, 5, 8, 10, 25, 30];
        Console.WriteLine("Array: [{0}]", string.Join(", ", nums));


        Console.Write("Enter a number to search: ");
        int searchNum = Convert.ToInt32(Console.ReadLine());

        bool exists = nums.Contains(searchNum);

        if (exists)
        {
            Console.WriteLine($"The number {searchNum} is present in the array.");
        }
        else
        {
            Console.WriteLine($"The number {searchNum} is NOT present in the array.");
        }

        Console.ReadLine();
    }
    static void main()
    {
        Console.WriteLine("17 Check Number in Array ---");


        int[] nums = [1, 5, 8, 10, 25, 30];
        Console.WriteLine("Array: [{0}]", string.Join(", ", nums));


        Console.Write("Enter a number to search: ");
        int searchNum = Convert.ToInt32(Console.ReadLine());

        bool exists = nums.Contains(searchNum);

        if (exists)
        {
            Console.WriteLine($"The number {searchNum} is present in the array.");
        }
        else
        {
            Console.WriteLine($"The number {searchNum} is NOT present in the array.");
        }

        Console.ReadLine();
    }
}