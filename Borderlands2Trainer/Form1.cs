using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Threading;
using System.Runtime.InteropServices;

namespace Borderlands2Trainer
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);



        Mem meme = new Mem();
        public static string health = "Borderlands2.exe+0x016887B8,2C,19C,168,1B4,6C";
        public static string money = "Borderlands2.exe+0x016A9F5C,0,AC,6C,194,2A0";
        public static string ultimate = "Borderlands2.exe+0x016A4838,CC,264,344,1AC,6C";
        public static string BadassTokens = "Borderlands2.exe+0x0164EE28,4,CC,88,4C,38,C54";
        public static string SkillPoints = "Borderlands2.exe+0x016887B8,14,A4,AC,18,1C4,4,274";
        public static string yAxis = "Borderlands2.exe+0x015BBCF8,E50,38,C4,68";
        public static string XP = "Borderlands2.exe+0x016A9F5C,0,194,3B0,1A8,6C";
        public static string Nades = "Borderlands2.exe+0x016887B8,2C,198,168,1AC,28,1AC,28,1A4,6AC";
        public static string xAxis = "Borderlands2.exe+0x016894F8,64";
        public static string zAxis = "Borderlands2.exe+0x0165D1A0,2A8,1E8,4,3C,F0,1EC,60";
        //weapons//
        public static string smg = "Borderlands2.exe+0x0168CA34,50,18,0,73C,0,BAC";
        public static string shotgun = "Borderlands2.exe+0x016887B8,2C,1B0,168,1A0,6AC";
        public static string rifle = "Borderlands2.exe+0x016887B8,2C,1B8,28,188,6C";
        public static string sniper = "Borderlands2.exe+0x016887B8,2C,1A0,28,1B0,42C";
        public static string pistol = "Borderlands2.exe+0x01655768,198,364,18C,20,340,1B0,6AC";
        public static string noReload = "Borderlands2.exe+0x016887B8,28,198,14,144,3E4,0,A28";
        public bool PO = false;
        public bool threads = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread numbers = new Thread(numcalc);
            numbers.Start();
            Thread sniperAMMO = new Thread(sniperammo);
            sniperAMMO.Start();
            Thread shotgunAMMO = new Thread(shotgunammo);
            shotgunAMMO.Start();
            Thread smgAMMO = new Thread(smgammo);
            smgAMMO.Start();
            Thread pistolAMMO = new Thread(pistolammo);
            pistolAMMO.Start();
            Thread rifleAMMO = new Thread(rifleammo);
            rifleAMMO.Start();
            Thread rapidFIRE = new Thread(rapidfire);
            rapidFIRE.Start();
            Thread health = new Thread(hp);
            health.Start();
            Thread Ultimate = new Thread(ult);
            Ultimate.Start();
            Thread higher = new Thread(UP);
            higher.Start();
            Thread BC = new Thread(BACK);
            BC.Start();
            Thread forward = new Thread(FOR);
            forward.Start();
            Thread LW = new Thread(LEFT);
            LW.Start();
            Thread RW = new Thread(RIGHT);
            RW.Start();
            Thread DW = new Thread(DOWN);
            DW.Start();

            int PID = meme.GetProcIdFromName("Borderlands2");
            if (PID > 0)
            {
                
                meme.OpenProcess(PID);
                label16.Text = PID.ToString();
                
               

            }
            else
            {
                MessageBox.Show("process is not open, try the attach button");
                
            }
        }
        private void RIGHT()
        {
            while (threads == true)
            {
                if (checkBox9.Checked)
                {
                    if (GetAsyncKeyState(Keys.N) < 0)
                    {
                        float xPos = meme.ReadFloat(xAxis);
                        float newyPos = xPos + 100;
                        meme.WriteMemory(xAxis, "float", newyPos.ToString());
                    }
                    Thread.Sleep(10);
                }
                Thread.Sleep(100);
            }
        }
        private void UP()
        {
            while (threads == true)
            {
                if (checkBox9.Checked)
                {
                    if (GetAsyncKeyState(Keys.Z)<0)
                    {
                        float yPos = meme.ReadFloat(yAxis);
                        float newyPos = yPos + 100;
                        meme.WriteMemory(yAxis, "float", newyPos.ToString());
                    }
                    Thread.Sleep(10);
                }
                Thread.Sleep(100);
            }
        }
        private void FOR()
        {
            while (threads == true)
            {
                if (checkBox9.Checked)
                {
                    if (GetAsyncKeyState(Keys.C) < 0)
                    {
                        float zPos = meme.ReadFloat(zAxis);
                        float newyPos = zPos + 100;
                        meme.WriteMemory(zAxis, "float", newyPos.ToString());
                    }
                    Thread.Sleep(10);
                }
                Thread.Sleep(100);
            }

        }
        private void DOWN()
        {
            while (threads == true)
            {
                if (checkBox9.Checked)
                {
                    if (GetAsyncKeyState(Keys.X) < 0)
                    {
                        float yPos = meme.ReadFloat(yAxis);
                        float newyPos = yPos - 75;
                        meme.WriteMemory(yAxis, "float", newyPos.ToString());
                    }
                    Thread.Sleep(10);
                }
                Thread.Sleep(100);
            }

        }
        private void LEFT()
        {
            while (threads == true)
            {
                if (checkBox9.Checked)
                {
                    if (GetAsyncKeyState(Keys.B) < 0)
                    {
                        float xPos = meme.ReadFloat(xAxis);
                        float newyPos = xPos - 100;
                        meme.WriteMemory(xAxis, "float", newyPos.ToString());
                    }
                    Thread.Sleep(100);
                }
                Thread.Sleep(100);
            }
        }
        private void BACK()
        {
            while (threads == true)
            {
                if (checkBox9.Checked)
                {
                    if (GetAsyncKeyState(Keys.V) < 0)
                    {
                        float zPos = meme.ReadFloat(zAxis);
                        float newyPos = zPos - 100;
                        meme.WriteMemory(zAxis, "float", newyPos.ToString());
                    }
                    Thread.Sleep(100);
                }
                Thread.Sleep(100);
            }
        }
        private void ult()
        {
            while (threads == true)
            {
                if (checkBox7.Checked)
                {
                    meme.WriteMemory(ultimate, "float", "0");
                    Thread.Sleep(100);
                }
                Thread.Sleep(137);
            }
        }
        private void hp()
        {
            while (threads == true)
            {
                if (checkBox1.Checked)
                {
                    meme.WriteMemory(health, "float", "1337");
                    Thread.Sleep(137);
                }
                Thread.Sleep(137);
            }
        }
        private void rifleammo()
        {
            while (threads == true)
            {
                if (checkBox8.Checked)
                {
                    meme.WriteMemory(rifle, "float", "1337");
                    Thread.Sleep(137);
                }
                Thread.Sleep(137);
            }
        }

        private void sniperammo()
        {
            while (threads == true)
            {
                if (checkBox3.Checked)
                {
                    meme.WriteMemory(sniper, "float", "1337");
                    Thread.Sleep(137);
                }
                Thread.Sleep(137);
            }
        }
        private void smgammo()
        {
            while (threads == true)
            {
                if (checkBox4.Checked)
                {
                    meme.WriteMemory(smg, "float", "1337");
                    Thread.Sleep(137);
                }
                Thread.Sleep(137);
            }
        }
        private void rapidfire()
        {
            while (threads == true)
            {
                if (checkBox2.Checked)
                {
                    meme.WriteMemory(noReload, "float", "1337");
                    Thread.Sleep(137);
                }
                Thread.Sleep(137);
            }
        }

        private void shotgunammo()
        {
            while (threads == true)
            {
                if (checkBox5.Checked)
                {
                    meme.WriteMemory(shotgun, "float", "1337");
                    Thread.Sleep(137);
                }
                Thread.Sleep(137);
            }
        }
        private void pistolammo()
        {
            while (threads == true)
            {
                if (checkBox6.Checked)
                {
                    meme.WriteMemory(pistol, "float", "1337");
                    Thread.Sleep(137);
                }
                Thread.Sleep(137);
            }
        }
        private void numcalc()
        {
            while (threads == true)
            {
                label10.Text = meme.ReadFloat(yAxis).ToString();
                label11.Text = meme.ReadFloat(xAxis).ToString();
                label12.Text = meme.ReadFloat(zAxis).ToString();

                Thread.Sleep(100);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int PID = meme.GetProcIdFromName("Borderlands2");
            if (PID > 0 )
            {
                MessageBox.Show("Found process, now attaching..");
                meme.OpenProcess(PID);
                PO = false;
                
            }
            else
            {
                MessageBox.Show("Couldn't find process");
                PO = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a number");
            }
            else
            {
                meme.WriteMemory(money, "int", textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("enter a number first");
            }
            else
            {
                float beforexp = meme.ReadFloat(XP);
                float afterXP = beforexp + float.Parse(textBox2.Text);
                meme.WriteMemory(XP, "float", afterXP.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("enter a number (float)");
            }
            else
            {
                meme.WriteMemory(yAxis, "float", textBox3.Text);
            }
               
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            threads = false;
            PO = false;
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("enter a number");

            }
            else
            {
                meme.WriteMemory(BadassTokens, "int", textBox6.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("enter a number");

            }
            else
            {
                meme.WriteMemory(SkillPoints, "int", textBox7.Text);
            }
        }
    }
}
