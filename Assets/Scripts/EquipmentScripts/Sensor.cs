/**
* MS Computer Science Graduate Project: Physics In Motion
* San Francisco State University, San Francisco, CA
* 
* Author: Cheryl Nielsen
* Version: July 22, 2023  
* File: Sensor.cs
* 
* Class: Sensor
* Purpose: Stores and adjusts the settings for the sensor.
* 
**/

namespace LabEquipment
{
    public class Sensor : Equipment
    {
        // position, rotation, scale, id

        private int dataRatePerSecond;
        private int maxDataRate;
        private int minDataRate;

        private string units;

        public Sensor() 
        {
            initializeSettings();
        }


        public override void initializeSettings()
        {
            EquipmentType = "sensor";
            Description = "sensor";
            Category = "sensor";

            units = "times per second";

            minDataRate = 1;
            maxDataRate = 20;
            DataRatePerSecond = minDataRate;
        }

        public int DataRatePerSecond
        { 
            get { return dataRatePerSecond; } 

            set
            {
                if(value < minDataRate) 
                {
                    dataRatePerSecond = minDataRate;
                }
                else if(value > maxDataRate)
                {
                    dataRatePerSecond = maxDataRate;
                }
                else
                {
                    dataRatePerSecond = value;
                }
            } 
        }

        public int MinDataRate
        { 
            get { return minDataRate; } 
        }

        public int MaxDataRate 
        { 
            get { return maxDataRate; } 
        }

        public string Units
        {
            get { return units; }
        }

    }
}