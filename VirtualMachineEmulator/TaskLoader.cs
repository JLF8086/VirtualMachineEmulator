using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMachineEmulator
{
    class TaskLoader    //Loads task into memory
    {
        private Memory memory;
        public TaskLoader(Memory memory, string fileName)
        {
            this.memory = memory;
        }
    }
}
