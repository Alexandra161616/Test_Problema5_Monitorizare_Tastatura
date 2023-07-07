using System;
using System.Windows.Forms;

namespace Test_Problema5
{
    public partial class Form1 : Form
    {

        private LowLevelKeyboardListener _listener;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _listener = new LowLevelKeyboardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;

            _listener.HookKeyboard();
        }

        private void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            this.textBox1.Text += e.KeyPressed.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _listener.UnHookKeyboard();
        }
    }
}

