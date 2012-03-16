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
            Memory mem = vm.Memory;
            for (int i = 0; i < mem.WordCount; i++)
            {
                VirtualMemoryGridView.Columns.Add(i.ToString("X"), i.ToString("X"));
                VirtualMemoryGridView.Columns[i].DisplayIndex = i;
            }
            for (int i = 0; i < mem.BlockCount; i++)
            {
                string[] rowValues = new string[mem.WordCount];
                for (int j = 0; j < mem.WordCount; j++)
                {
                    if(!(mem[i,j].ToString() == "----"))
                        rowValues[j] = mem[i, j].ToString();
                }
                VirtualMemoryGridView.Rows.Add(rowValues);
                VirtualMemoryGridView.Rows[i].HeaderCell.Value = i.ToString("X");

            }
        }

        private void FillMemoryGrid()
        {
            Memory mem = vm.Memory;
            for (int i = 0; i < mem.BlockCount; i++)
            {
                string[] rowValues = new string[mem.WordCount];
                for (int j = 0; j < mem.WordCount; j++)
                {
                    if (!(mem[i, j].ToString() == "----"))
                        rowValues[j] = mem[i, j].ToString();
                }
                VirtualMemoryGridView.Rows[i].SetValues(rowValues);
                VirtualMemoryGridView.Rows[i].HeaderCell.Value = i.ToString("X");

            }
        }

        private void FillRegisters()
        {
            labelAX.Text = "AX = " + vm.Cpu.AX.ToString();
            labelCX.Text = "CX = " + vm.Cpu.CX.ToString();
            labelPC.Text = "PC = " + vm.Cpu.PC.ToString();
            labelSF.Text = "SF = " + vm.Cpu.SF.ToString();
        }

        private void SetTaskName()
        {
            nextCommandLabel.Text = vm.Cpu.NextCommand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                vm = new VirtualMachine(openFileDialog1.FileName);
                FillVirtualMemory();
                FillRegisters();
                SetTaskName();
                taskNameLabel.Text = "Current task = " + openFileDialog1.FileName.Split('\\').Last();
                this.vm.Cpu.CommandExecuted += new VMEventHandler(FillRegisters);
                this.vm.Cpu.CommandExecuted += new VMEventHandler(FillMemoryGrid);
                this.vm.Cpu.CommandExecuted += new VMEventHandler(SetTaskName);
            }
        }

        private void executeNextButton_Click(object sender, EventArgs e)
        {
            vm.ExecuteNext();
            
        }


        
    }
}
