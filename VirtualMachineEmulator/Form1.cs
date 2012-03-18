using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirtualMachineEmulator
{
    public partial class Form1 : Form
    {
        private VirtualMachine vm;
        public Form1()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Form1());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void FillVirtualMemory()
        {
            VirtualMemoryGridView.Rows.Clear();
            VirtualMemoryGridView.Columns.Clear();
            Memory mem = vm.Memory;
            for (Int16 i = 0; i < mem.WordCount; i++)
            {
                VirtualMemoryGridView.Columns.Add(i.ToString("X"), i.ToString("X"));
                VirtualMemoryGridView.Columns[i].DisplayIndex = i;
            }
            for (Int16 i = 0; i < mem.BlockCount; i++)
            {
                string[] rowValues = new string[mem.WordCount];
                for (Int16 j = 0; j < mem.WordCount; j++)
                {
                    if(!(mem[i,j].ToString() == "----"))
                        rowValues[j] = mem[i, j].ToString();
                }
                VirtualMemoryGridView.Rows.Add(rowValues);
                VirtualMemoryGridView.Rows[i].HeaderCell.Value = i.ToString("X");

            }
        }

        private void FillVirtualMemoryGrid()
        {
            Memory mem = vm.Memory;
            for (Int16 i = 0; i < mem.BlockCount; i++)
            {
                string[] rowValues = new string[mem.WordCount];
                for (Int16 j = 0; j < mem.WordCount; j++)
                {
                    if (!(mem[i, j].ToString() == "----"))
                        rowValues[j] = mem[i, j].ToString();
                }
                VirtualMemoryGridView.Rows[i].SetValues(rowValues);
                VirtualMemoryGridView.Rows[i].HeaderCell.Value = i.ToString("X");

            }
        }

        private void FillRealMemory()
        {
            RealMemoryGridView.Rows.Clear();
            RealMemoryGridView.Columns.Clear();
            for (Int16 i = 0; i < RealMachine.Memory.WordCount; i++)
            {
                RealMemoryGridView.Columns.Add(i.ToString("X"), i.ToString("X"));
                RealMemoryGridView.Columns[i].DisplayIndex = i;
            }
            for (Int16 i = 0; i < RealMachine.Memory.BlockCount; i++)
            {
                string[] rowValues = new string[RealMachine.Memory.WordCount];
                for (Int16 j = 0; j < RealMachine.Memory.WordCount; j++)
                {
                    if (!(RealMachine.Memory[i, j].ToString() == "----"))
                        rowValues[j] = RealMachine.Memory[i, j].ToString();
                }
                RealMemoryGridView.Rows.Add(rowValues);
                RealMemoryGridView.Rows[i].HeaderCell.Value = i.ToString("X");
            }
        }

        private void FillRealMemoryGrid()
        {
            vm.MapBlocks();
            for (Int16 i = 0; i < RealMachine.Memory.BlockCount; i++)
            {
                string[] rowValues = new string[RealMachine.Memory.WordCount];
                for (Int16 j = 0; j < RealMachine.Memory.WordCount; j++)
                {
                    if (!(RealMachine.Memory[i, j].ToString() == "----"))
                        rowValues[j] = RealMachine.Memory[i, j].ToString();
                }
                RealMemoryGridView.Rows[i].SetValues(rowValues);
                RealMemoryGridView.Rows[i].HeaderCell.Value = i.ToString("X");
            }
        }

        private void PrepareForInput()
        {
            inputTextBox.Enabled = true;
            executeNextButton.Enabled = false;
            executeAllButton.Enabled = false;
            enterInputButton.Enabled = true;
        }

        private void PrInt16Buffer()
        {
            outputTextBox.Text += vm.Io.Buffer;
            outputTextBox.Text += "\r\n";
        }

        private void FillRegisters()
        {
            labelAX.Text = "AX = " + vm.Cpu.AX.ToString();
            labelCX.Text = "CX = " + vm.Cpu.CX.ToString();
            labelPC.Text = "PC = " + vm.Cpu.PC.ToString("X");
            labelSF.Text = "SF = " + vm.Cpu.SF.ToString();
            labelPTR.Text = "PTR = " + RealMachine.PTR.ToString("X");
        }

        private void SetNextCommandLabel()
        {
            nextCommandLabel.Text = "Next command = " + vm.Cpu.NextCommand();
        }

        private void vmTaskFinishHandler()
        {
            executeAllButton.Enabled = false;
            executeNextButton.Enabled = false;
            nextCommandLabel.Text = "Next command = <none>";
            taskNameLabel.Text = "Current task = <none>";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Word.HexToInt("FFFF").ToString());
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                vm = new VirtualMachine(openFileDialog1.FileName);
                executeNextButton.Enabled = true;
                executeAllButton.Enabled = true;
                FillVirtualMemory();
                FillRealMemory();
                FillRegisters();
                SetNextCommandLabel();
                outputTextBox.Text = String.Empty;
                taskNameLabel.Text = "Current task = " + openFileDialog1.FileName.Split('\\').Last();
                this.vm.Cpu.CommandExecuted += new VMEventHandler(FillRegisters);
                this.vm.Cpu.CommandExecuted += new VMEventHandler(FillVirtualMemoryGrid);
                this.vm.Cpu.CommandExecuted += new VMEventHandler(FillRealMemoryGrid);
                this.vm.Cpu.CommandExecuted += new VMEventHandler(SetNextCommandLabel);
                this.vm.Io.InputRequested += new VMEventHandler(PrepareForInput);
                this.vm.Io.OutputRequested += new VMEventHandler(PrInt16Buffer);
                this.vm.VMTaskFinished += new VMEventHandler(vmTaskFinishHandler);
                this.vm.CheckIfInputNext();
            }
        }

        private void executeNextButton_Click(object sender, EventArgs e)
        {
            this.vm.ExecuteNext();
        }

        private void enterInputButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == String.Empty)
                return;
            this.vm.Io.Buffer = inputTextBox.Text;
            executeAllButton.Enabled = true;
            executeNextButton.Enabled = true;
            inputTextBox.Enabled = false;
            enterInputButton.Enabled = false;
            inputTextBox.Text = String.Empty;
            this.vm.ExecuteNext();
        }

        private void executeAllButton_Click(object sender, EventArgs e)
        {
            this.vm.ExecuteAll();
        }  
    }
}
