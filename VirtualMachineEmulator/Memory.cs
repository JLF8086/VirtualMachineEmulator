namespace VirtualMachineEmulator
{

    public class Memory
    {
        private Word[,] words;
        public const int BLOCK_WORD_COUNT = 16;
        public const int REAL_MEMORY_BLOCK_COUNT = 16;
        public const int VIRTUAL_MEMORY_BLOCK_COUNT = 5;

        public static Memory RealMemory { get; private set; }
        static Memory()
        {
            RealMemory = new Memory(REAL_MEMORY_BLOCK_COUNT, BLOCK_WORD_COUNT);     
        }

        public Memory(int blockCount, int wordCount)
        {
            this.words = new Word[blockCount, wordCount];
            for (int i = 0; i < this.words.GetLength(0); i++)
            {
                for (int j = 0; j < this.words.GetLength(1); j++)
                {
                    this.words[i, j] = new Word();
                }
            }
        }

        public int BlockCount 
        { 
            get { return this.words.GetLength(0); }
        }

        public int WordCount
        {
            get { return this.words.GetLength(1); }
        }

        public Word this[int block, int word]
        {
            set { words[block, word] = value; }
            get { return words[block, word]; }
        }

        public void Write(string operand, string buffer)
        {
            int block = Word.HexToInt(operand[0].ToString());
            Word[] words = StringToWords(buffer);
            for (int i = 0; i < words.Length; i++)
                this.words[block, i] = words[i];

        }

        private Word[] StringToWords(string str)
        {
            string[] wordStrings = new string[Memory.BLOCK_WORD_COUNT];
            int i = 0;
            while (i < Memory.BLOCK_WORD_COUNT)
            {
                string word = str.Length >= 4 ? str.Substring(0, 4) : str.Substring(0, str.Length);
                wordStrings[i] = word;
                i++;
                str = str.Length >= 4 ? str.Substring(4, str.Length) : null;
                if (str == null)
                    break;
            }
            Word[] words = new Word[Memory.BLOCK_WORD_COUNT];
            for (int j = 0; j < Memory.BLOCK_WORD_COUNT; j++)
                words[j] = new Word(wordStrings[j]);
            return words;
        }
        
    }
}
