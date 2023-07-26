/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 22, 2023  
 * File: Block.cs
 * 
 * Class: Block
 * Purpose: Stores and adjusts the settings for the block.
 **/

namespace LabEquipment
{
    public class Block : Equipment
    {
        // position, rotation, scale, id
        
        protected float minMass;
        protected float maxMass;
        protected string units;
        protected float mass;

        public Block() 
        { 
            initializeSettings();
        }

        public override void initializeSettings()
        {
            EquipmentName = "block";
            Description = "block";
            Category = "block";

            units = "kg";

            minMass  = 0.0f;
            maxMass = 20.0f;
            Mass = 2.0f;
        }

        public float Mass
        { 
            get { return mass; }

            set
            {
                if (value < minMass)
                {
                    mass = minMass;
                }
                else if (value > maxMass)
                {
                    mass = maxMass;
                }
                else
                {
                    mass = value;
                }
            }
        }

        public float MinMass 
        { 
            get { return minMass; }
        }
        public float MaxMass 
        { 
            get { return maxMass; } 
        }

        public string Units
        {
            get { return units; }
        }

    }
}