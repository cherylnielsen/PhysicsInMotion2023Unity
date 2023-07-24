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
        protected Equipment equipment;
        
        // Some basic GUI default items
         


        public abstract void initializeControls();


        

    }

}