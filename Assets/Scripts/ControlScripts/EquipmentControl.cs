using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LabEquipment
{
    public abstract class EquipmentControl : MonoBehaviour
    {
        // setup gui
        // initialize gui with equipment settings
        // save settings to equipment

        // The equipment associated with this control
        [SerializeField] protected GameObject equipmentObj;
        protected bool hideControls;


        // Awake is called when the script instance is being loaded
        private void Awake()
        {
            //equipment = equipmentObj.GetComponent<Equipment>() as Sensor;
            initializeControls();
        }


        // Some basic GUI default items

        public abstract void initializeControls();

        public abstract void showControls();


        

    }

}