using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMachineEmulator
{
    

    class VirtualMachine
    {
        const int VM_BLOCK_COUNT = 5;
        const int BLOCK_WORD_COUNT = 16;
        private CPU cpu = new CPU();
        private Memory memory = new Memory(5, 16);

        void ExecuteNextTask()
        {
        }

    }
}
