using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace VirtualMachineEmulator
{
    public class VirtualMachine
    {
        private Cpu cpu;
        private IO io;
        private Memory memory;
        private TaskLoader task;
        private Word[] pageTable;

        public VirtualMachine(string fileName)
        {
            memory = new Memory(Memory.VIRTUAL_MEMORY_BLOCK_COUNT, Memory.BLOCK_WORD_COUNT);
            this.task = new TaskLoader(fileName, memory);
            task.Load();
            cpu = new Cpu(memory, this);
            io = new IO();
        }
        public void CheckIfInputNext()
        {
            if (cpu.NextCommand().Substring(0, 2) == "GD")
                io.ReadBuffer();
        }

        public void ExecuteNext()
        {
            cpu.ExecuteNext();
            CheckIfInputNext();

        }

        public Memory Memory
        {
            get { return memory; }
        }

        

        public IO Io
        {
            get { return io; }
        }

        public Cpu Cpu
        {
            get { return cpu; }
        }

        /*private Word[] InitPageTable()
        {
            ArrayList blocks = new ArrayList(memory.BlockCount);
            for (int i = 0; i < memory.BlockCount; i++)
            {
                blocks.Add(i);
            }
            Random rand = new Random();
            Word[] pageTable = new Word[Memory.BLOCK_WORD_COUNT];
            for (int i = 0; i < Memory.BLOCK_WORD_COUNT; i++)
            {
                int cell = (int)blocks[rand.Next(blocks.Count)];
                blocks.Remove(cell);
                pageTable[i] = new Word(cell);
            }
            return pageTable;
        }*/ //bbs
    }
}
