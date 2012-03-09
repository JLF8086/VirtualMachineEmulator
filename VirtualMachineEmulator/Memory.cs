namespace VirtualMachineEmulator
{
    class Memory
    {
        private Word[,] words;

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
        
    }
}
