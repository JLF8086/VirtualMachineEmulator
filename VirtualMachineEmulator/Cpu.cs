using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace VirtualMachineEmulator
{
    public class CPU
    {
        Hashtable registers = new Hashtable() 
        { 
            {"AX", new Word(0)},
            {"CX", new Word(0)},
            {"PC", new Word(0)},
            {"SF", new Word(0)}
        };

        public CPU()
        {

        }

        public void ExecuteCommand(Word command, VirtualMachine vm)
        {
            int block = 0, word = 0;
            string cmd = command.Value.Substring(0, 2);
            if (cmd != "AD" && cmd != "SU" && cmd != "CM")
            {
                block = Int32.Parse(command.Value[2].ToString(), System.Globalization.NumberStyles.HexNumber);
                word = Int32.Parse(command.Value[3].ToString(), System.Globalization.NumberStyles.HexNumber);
            }
            switch (cmd)
            {
                case "AD": Add(vm); IncrementPC(); break;
                case "SU": Sub(vm); IncrementPC(); break;
                case "CM": Compare(vm); IncrementPC(); break;
                case "JM": Jump(block, word, vm); break;
                case "JE": JumpIfEqual(block, word, vm); break;
                case "JN": JumpIfNotEqual(block, word, vm); break;
                case "JA": JumpIfAbove(block, word, vm); break;
                case "JB": JumpIfBelow(block, word, vm); break;
                case "JG": JumpIfGreaterOrEqual(block, word, vm); break;
                case "JL": JumpIfLesserOrEqual(block, word, vm); break;
                case "SA": SetAX(block, word, vm); IncrementPC(); break;
                case "LA": LoadAX(block, word, vm); IncrementPC(); break;
                case "SC": SetCX(block, word, vm); IncrementPC(); break;
                case "LC": LoadCX(block, word, vm); IncrementPC(); break;
                case "GD": GetData(block, word, vm); IncrementPC(); break;
                case "PD": PutData(block, word, vm); IncrementPC(); break;
                case "$0": IncrementPC(); break;
                default: throw new ArgumentException();
            }
        }

        private void PutData(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void GetData(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void LoadCX(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void SetCX(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void LoadAX(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void SetAX(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void JumpIfLesserOrEqual(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void JumpIfGreaterOrEqual(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void JumpIfBelow(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void JumpIfAbove(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void JumpIfNotEqual(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void JumpIfEqual(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void Jump(int block, int word, VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void Compare(VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void Sub(VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void Add(VirtualMachine vm)
        {
            throw new NotImplementedException();
        }

        private void IncrementPC()
        {
            throw new NotImplementedException();
        }

    }
}
