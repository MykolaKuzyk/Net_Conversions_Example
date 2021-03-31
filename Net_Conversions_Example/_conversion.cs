using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Conversions_Example
{
    class _conversion
    {
        static void StartConverting()
        {
            /* Byte */
            Convert.ToByte("10111", 2); // returns 23 - the first argument 10111 is the nuber to convert, second is its base 
            Convert.ToByte("11111111",2); // returns 255

            /* Short */
            Convert.ToInt16("111111111111111", 2); // returns 32767

            /* Int */
            Convert.ToInt32("11111111111111111111111111111"); //return 2147483647

        }


        static void CastingADecimal()
        {
            float myFloatValue = 10;
            int myIntValue = (int)myFloatValue;
            Console.WriteLine("myIntValue is " + myIntValue);

            int NewInt = 10;
            byte NewByte = (byte)NewInt;
            double myDouble = (double)NewByte;
            string myString = "false";
            myString = NewInt.ToString();
            short myShort = (short)NewInt;
            char myChar = 'x';
            long myLong = (long)NewInt;
            decimal myDecimal = (decimal)myLong;
            myString =  myString + 
                        NewInt + 
                        NewByte +
                        myDouble +
                        myChar;



        }
    }
}
