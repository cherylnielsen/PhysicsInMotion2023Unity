/**
* MS Computer Science Graduate Project: Physics In Motion
* San Francisco State University, San Francisco, CA
* 
* Author: Cheryl Nielsen
* Version: July 22, 2023  
* File: Ramp.cs
* 
* Class: Ramp
* Purpose:  Stores and adjusts the settings for the adjustable ramp.
* 
**/

namespace LabEquipment
{
    public class Ramp : Equipment
    {
        // position, rotation, scale, id

        private float angleOfIncline;
        private float minAngle;
        private float maxAngle;

        private float frictionCoeficient;
        private float minFriction;
        private float maxFriction;

        private string units;

        public Ramp() 
        {
            initializeSettings();
        }

        public override void initializeSettings()
        {
            EquipmentType = "ramp";
            Description = "ramp";
            Category = "ramp";

            units = "degrees";
            
            minAngle = 0.0f;
            maxAngle = 60.0f;
            AngleOfIncline = minAngle;
            
            minFriction = 0.0f;
            maxFriction = 2.0f;
            FrictionCoeficient = minFriction;
        }

        public float AngleOfIncline
        { 
            get { return angleOfIncline; } 

            set
            {
                if (value < minAngle)
                {
                    angleOfIncline = minAngle;
                }
                else if (value > maxAngle)
                {
                    angleOfIncline = maxAngle;
                }
                else
                {
                    angleOfIncline = value;
                }
            }
            
        }

        public float MinAngle
        {
            get { return minAngle; }
        }

        public float MaxAngle
        {
            get { return maxAngle; }
        }

        public float FrictionCoeficient
        {
            get { return frictionCoeficient; }

            set
            {
                if (value < minFriction)
                {
                    frictionCoeficient = minFriction;
                }
                else if (value > maxFriction)
                {
                    frictionCoeficient = maxFriction;
                }
                else
                {
                    frictionCoeficient = value;
                }
            }

        }

        public float MinFriction
        {
            get { return minFriction; }
        }

        public float MaxFriction
        {
            get { return maxFriction; }
        }

        public string Units
        {
            get { return units; }
        }

    }

}
