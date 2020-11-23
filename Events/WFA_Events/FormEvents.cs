using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenHardwareMonitor.Hardware;
using System.Diagnostics;

namespace WFA_Events
{
    public partial class FormEvents : Form
    {
        public String topo_temperature = "";

        public FormEvents()
        {
            InitializeComponent();

        }

        private void FormEvents_Load(object sender, EventArgs e)
        {
            CheckTemperature();
        }

        public void CheckTemperature()
        {
            // add CPU and GPU as hardware
            Computer computer = new Computer() { GPUEnabled = true }; // , MainboardEnabled = true,CPUEnabled = true,  GPUEnabled = true 
            computer.Open();

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                //if( Convert.ToString(hardware.Name) == "Intel Core i9-9900K" )
                //{
                    textBoxTitleHardware.Text = Convert.ToString(hardware.HardwareType);

                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        //topo_temperature += Convert.ToString(sensor.SensorType);
                        // Celsius is default unit
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            if (Convert.ToString(sensor.Value.ToString()) != "")
                            {
                                topo_temperature += Convert.ToString(sensor.Value.ToString()+"°C");
                            }
                           
                        }

                    }
                //}
                
            }

            computer.Close();
            richTextBoxMain.Text = topo_temperature;
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            CheckTemperature();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
