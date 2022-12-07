
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if(numbers == "")
        {
            return 0;
        }
        else if (numbers.Contains(","))
        {
            var nums = numbers.Split(',');
            var total = 0;
            foreach (var n in nums)
            {
                total += int.Parse(n);
            }
            return total;
        }
        return int.Parse(numbers);
    }

}
