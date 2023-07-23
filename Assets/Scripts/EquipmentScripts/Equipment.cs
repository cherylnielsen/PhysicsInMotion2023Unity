using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Rendering;

namespace LabEquipment
{
    public abstract class Equipment: MonoBehaviour {

        private int id;
        private string equipmentType;
        private string description;
        private string category;
        private Vector3 position;
        private Vector3 rotation;
        private Vector3 scale;

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

        public Vector3 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Vector3 Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        public Vector3 Scale
        {
            get { return scale; }
            set { scale = value; }
        }


    }
}