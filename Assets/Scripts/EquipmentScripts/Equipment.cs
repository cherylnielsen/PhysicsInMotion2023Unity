/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 22, 2023  
 * File: Cart.cs
 * 
 * Class: Equipment
 * Purpose: Abstract class that stores and adjusts the settings generic to any lab equipment.
 *          All lab equipment inherit from this class.
 **/

using UnityEngine;

namespace LabEquipment
{
    public abstract class Equipment: MonoBehaviour {

        private int id;
        private string equipmentType;
        private string description;
        private string category;

        public abstract void initializeSettings();


        public int Id 
        { 
            get { return id; } 
            set { id = value; } 
        }

        public string EquipmentType
        {
            get { return equipmentType; }
            set { equipmentType = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }


    }
}