﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Host_API
{
    public partial class Form1 : Form
    {
        private static API DllInstance = new API();

        public Form1()
        {
            InitializeComponent();
#if DEBUG
            ResultTextBox.ForeColor = Color.Red;
            printResult("WARNING - YOU ARE USING DEBUG VERSION OF THIS TOOL!");
#else
            ResultTextBox.ForeColor = Color.Green;
            printResult("YOU ARE USING THE RELEASE VERSION OF THIS TOOL!");
#endif
        }

        private void printResult(string result)
        {
            ResultTextBox.Text += result + "\n";
            ResultTextBox.Select(ResultTextBox.Text.Length, 0);
            ResultTextBox.ScrollToCaret();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            ResultTextBox.ForeColor = Color.Black;
            string functionName = "Connect";
            string parameters = "TCP,"+IP_Textbox.Text+","+DB_UserTextbox.Text+","+ DB_PasswordTextboxx.Text;

            string result = DllInstance.APICall(functionName, parameters);
            printResult(result);
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            string functionName = "Disconnect";
            string parameters = "";

            string result = DllInstance.APICall(functionName, parameters);
            printResult(result);
        }

        private void IncrementCounterButton_Click(object sender, EventArgs e)
        {
            if (adapterCode_TextBox1.Text == "" || adapterType_TextBox1.Text == "")
            {
                printResult("Please complete all the required fields!");
                return;
            }

            string functionName = "IncrementCounter";
            string parameters = adapterCode_TextBox1.Text+","+adapterType_TextBox1.Text;

            string result = DllInstance.APICall(functionName, parameters);
            printResult(result);
        }

        private void setTemperatureButton_Click(object sender, EventArgs e)
        {
            if (adapterCode_TextBox2.Text == "" || adapterType_TextBox2.Text == "" || temperatureTextBox.Text == "")
            {
                printResult("Please complete all the required fields!");
                return;
            }

            string functionName = "UpdateTemperature";
            string parameters = adapterCode_TextBox2.Text + "," + adapterType_TextBox2.Text + "," + temperatureTextBox.Text;

            string result = DllInstance.APICall(functionName, parameters);
            printResult(result);
        }

        private void updateContactsButton_Click(object sender, EventArgs e)
        {
            if (adapterCode_TextBox3.Text == "" || adapterType_TextBox3.Text == "" || contactsTextBox.Text == "")
            {
                printResult("Please complete all the required fields!");
                return;
            }

            string functionName = "UpdateContacts";
            string parameters = adapterCode_TextBox3.Text + "," + adapterType_TextBox3.Text + "," + contactsTextBox.Text;

            string result = DllInstance.APICall(functionName, parameters);
            printResult(result);
        }
    }
}
