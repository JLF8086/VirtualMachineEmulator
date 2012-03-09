using System;

namespace VirtualMachineEmulator
{
    public class Word
    {
        public string Value { get; set; }

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
                op1 = Convert.ToInt32(word1.Value);
                op2 = Convert.ToInt32(word2.Value);
                sum = op1 + op2;
            }
            catch (Exception)
            {
                throw;
            }
            return new Word(sum);
        }

        public static Word operator -(Word word1, Word word2)
        {
            int op1, op2, difference;
            try
            {
                op1 = Convert.ToInt32(word1.Value);
                op2 = Convert.ToInt32(word2.Value);
                difference = op1 - op2;
            }
            catch (Exception)
            {
                throw;
            }
            return new Word(difference);
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
