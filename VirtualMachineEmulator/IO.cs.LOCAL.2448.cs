using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMachineEmulator
{
    public class IO
    {
        private string buffer;
        public const int BUFF_SIZE = 10;
        public event VMEventHandler StartedWriting;
        public event VMEventHandler WaitingForInput;

        public string Buffer
        {
            set
            {
                if (value.Length > BUFF_SIZE * 4)
                {
                    buffer = value.Substring(0, BUFF_SIZE);
                }
                else
                {
                    buffer = value;
                }
            }
            get
            {
                return buffer;
            }
        }

        public void Flush()
        {
            buffer = "";
        }

        public void WriteBuffer()
        {
            StartedWriting();
        }

        public void ReadBuffer()
        {
            WaitingForInput();
        }
    }
}
