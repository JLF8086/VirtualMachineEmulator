using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMachineEmulator
{
    public class Cpu
    {
        private Memory memory;
        public Word PC { get; set; }
        public Word AX { get; set; }
        public Word CX { get; set; }
        public byte SF { get; set; }

        public Cpu(Memory memory)
        {
            this.memory = memory;
            this.PC = new Word(0);
            this.AX = new Word(0);
            this.CX = new Word(0);
            this.SF = 0;
        }

        public void ExecuteCommand(Word word)
        {
            string command = word.Value.Substring(0, 2);
            string operand = word.Value.Substring(2, 2);
            switch (command)
            {
                case "AD":
                    {
                        this.AX = this.AX + this.CX;
                        break;
                    }
                case "SB":
                    {
                        this.AX = this.AX - this.CX;
                        break;
                    }
                case "CM":
                    {
                        if (this.AX > this.CX)
                            this.SF = 0;
                        if (this.AX < this.CX)
                            this.SF = 2;
                        if (this.AX == this.CX)
                            this.SF = 1;
                        break;
                    }
                case "SA":
                    {
                        break;
                    }
                case "LA":
                    {
                        break;
                    }
                case "SC":
                    {
                        break;
                    }
                case "LC":
                    {
                        break;
                    }
                case "SG":
                    {
                        break;
                    }
                case "LG":
                    {
                        break;
                    }
                case "JM":
                    {
                        break;
                    }
                case "JE":
                    {
                        break;
                    }
                case "JN":
                    {
                        break;
                    }
                case "JA":
                    {
                        break;
                    }
                case "JB":
                    {
                        break;
                    }
                case "JG":
                    {
                        break;
                    }
                case "JL":
                    {
                        break;
                    }
                case "GD":
                    {
                        break;
                    }
                case "PD":
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }
    }
}
