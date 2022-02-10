class NearestThousands
{
    static void Main()
    {
        // input
        int number = 3750; 
        //  Declare variables
        decimal decimal_number = number;
        int roundedNumber = 0;
        
        // Conversions
        int previous_thousand = number / 1000 ;
        int thousand = previous_thousand * 1000;

        // Get last three digit of the input
        int last_three_digits =number - thousand ;

        // If the number's last three digits are greater than or equal to 500; it should "round up" the number.
        if (last_three_digits >= 500)
        {
            roundedNumber = (previous_thousand * 1000) + 1000;
        }
        // If the number's last three digits are less than 500; it should "round down" the number.
        else
        {
            roundedNumber = previous_thousand * 1000;
        }
        // If the number is less than 500; it should round up to 1000.
        if ( number < 500)
        {
            roundedNumber = 1000;
        }


        // Print Output
        System.Console.Write("Rounded number for ");
        System.Console.Write(number);
        System.Console.Write(" is: ");
        System.Console.Write(roundedNumber);
        System.Console.ReadKey();
    }
}