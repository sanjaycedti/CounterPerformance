using System.Text;

namespace CounterPerformance;

public static class Counter
{
    public static string Increment(ReadOnlySpan<char> input)
    {
        // input == "K202300001";
        // Increment the last 5 digits
        var length = input.Length - 1;
        while (length >= 0)
        {
            var c = input[length];
            if (!(c >= '0' && c <= '9'))
            {
                break;
            }

            length--;
        }

        var num = input.Length - length - 1;
        
        var sb = new StringBuilder(input.Length);
        sb.Append(input.Slice(0, input.Length - num));
        var last5 = input.Slice(input.Length - num);
        var number = int.Parse(last5);
        sb.Append((number + 1).ToString().PadLeft(5, '0'));
        return sb.ToString();
    }

    public static string IncrementSpan(ReadOnlySpan<char> input)
    {
        // input == "K202300001";
        // Increment the last n digits using Span and ReadOnlySpan with minimal memory allocations
        var length = input.Length - 1;
        while (length >= 0)
        {
            var c = input[length];
            if (!(c >= '0' && c <= '9'))
            {
                break;
            }

            length--;
        }

        var num = input.Length - length - 1;
        Span<char> span = stackalloc char[input.Length];
        input.CopyTo(span);
        var last5 = input.Slice(input.Length - num);
        var number = int.Parse(last5);

        number++;

        var i = input.Length;
        while (i-- > num)
        {
            span[i] = (char)((number % 10) + 48);
            number /= 10;
        }

        // Console.WriteLine(span.Length); 

        return new string(span);
    }
}

