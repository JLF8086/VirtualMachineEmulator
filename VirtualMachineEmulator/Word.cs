using System;

namespace VirtualMachineEmulator
{
    public class Word{
    
        public string Value { get; set; }
        public bool IsOccupied { get; set; }

        public Word()
        {
            this.Value = "----";
        }

        public Word(string value)
        {
            this.Value = value;
        }

        public Word(int value)
            : this(value.ToString())
        {
        }

        public static Word operator +(Word word1, Word word2)
        {
            int op1, op2, sum;
            try
            {
                op1 = Convert.ToInt32(word1.Value, 16);
                op2 = Convert.ToInt32(word2.Value, 16);
                sum = op1 + op2;
            }
            catch (Exception)
            {
                throw;
            }
            return new Word(sum.ToString("X"));
        }

        public static Word operator -(Word word1, Word word2)
        {
            int op1, op2, difference;
            try
            {
                op1 = Convert.ToInt32(word1.Value, 16);
                op2 = Convert.ToInt32(word2.Value, 16);
                difference = op1 - op2;
            }
            catch (Exception)
            {
                throw;
            }
            return new Word(difference.ToString("X"));
        }

        public static bool operator >(Word word1, Word word2)
        {
            int op1, op2;
            try
            {
                op1 = Convert.ToInt32(word1.Value, 16);
                op2 = Convert.ToInt32(word2.Value, 16);
            }
            catch (Exception)
            {
                throw;
            }
            return op1 > op2;
        }

        public static bool operator <(Word word1, Word word2)
        {
            int op1, op2;
            try
            {
                op1 = Convert.ToInt32(word1.Value, 16);
                op2 = Convert.ToInt32(word2.Value, 16);
            }
            catch (Exception)
            {
                throw;
            }
            return op1 < op2;
        }

        public int ToHex(string number)
        {
            return Convert.ToInt32(number, 16);
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
