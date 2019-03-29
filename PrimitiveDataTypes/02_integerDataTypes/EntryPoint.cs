using System;

namespace _02_integerDataTypes
{
    class EntryPoint
    {
        static void Main()
        {
            int someInteger = 265;
            // maximum and minimum values an integer data type can hold
            int intMax = int.MaxValue;
            int intMin = int.MinValue;
            Console.WriteLine(intMax);
            Console.WriteLine(intMin);

            // unsigned (only positive numbers)
            uint someUInteger = 5;
            uint minUint = uint.MinValue;
            uint maxUint = uint.MaxValue;
            Console.WriteLine(minUint);
            Console.WriteLine(maxUint);

            Console.WriteLine(Math.Pow(2, 32));

            // 2^8 is max value (including 0... so 0 to 255)
            byte someByteNumber = 255;

            // short byte (-128 to 127)
            sbyte minSbyte = sbyte.MinValue;

            // 2^64 max value
            long maxLong = long.MaxValue;
            Console.WriteLine(maxLong);

            // unsigned long
            ulong maxUlong = ulong.MaxValue;
        }
    }
}
