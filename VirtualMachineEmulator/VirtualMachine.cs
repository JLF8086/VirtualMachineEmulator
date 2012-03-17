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
        public static int BlockOffset = 0;

        public VirtualMachine(string fileName)
        {
            memory = new Memory(Memory.VIRTUAL_MEMORY_BLOCK_COUNT, Memory.BLOCK_WORD_COUNT);
            this.task = new TaskLoader(fileName, memory);
            task.Load();
            cpu = new Cpu(memory, this);
            io = new IO();
            BlockOffset += Memory.VIRTUAL_MEMORY_BLOCK_COUNT;
            this.MapBlocks();
        }

        public void MapBlocks()
        {
            int rmblock;
            for (int i = 0; i < BlockOffset; i++)
            {
                rmblock = Word.HexToInt(RealMachine.Memory[RealMachine.PTR, i].Value);
                for (int j = 0; j < Memory.BLOCK_WORD_COUNT; j++)
                {
                    RealMachine.Memory[rmblock, j] = this.memory[i, j];
                }            
            }
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
    }
}
