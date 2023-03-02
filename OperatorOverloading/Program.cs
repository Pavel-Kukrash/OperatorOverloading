
Counter counter1 = new Counter(25);
Counter counter2 = new Counter(72);

bool result = counter1 > counter2;
Counter sum = counter1 + counter2;

Console.WriteLine($"Output: result = {result}, sum = {sum.Value}");

Console.ReadKey();

public class Counter
{
    public int Value { get; set; }
	public Counter(int value) => Value = value;
	
	// for sum
	public static Counter operator +(Counter counter1, Counter counter2)
	{
		return new Counter(counter1.Value + counter2.Value);
	}

    // for result

    public static bool operator >(Counter counter1, Counter counter2)
    {
        return counter1.Value > counter2.Value;
    }

    public static bool operator <(Counter counter1, Counter counter2)
    {
        return counter1.Value < counter2.Value;
    }

}
