using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using static EquipmentType;


/**
* MS Computer Science Graduate Project: Physics In Motion
* San Francisco State University, San Francisco, CA
* 
* Author: Cheryl Nielsen
* Version: July 22, 2023  
* File: Ramp.cs
* 
* Class: Ramp
* Purpose:  Stores and adjusts the settingsList for the adjustable ramp.
* 
**/


public class Ramp : LabEquipment
{
    // position, rotation, scale ??
    // mass, friction ??


    // add the default equipment settings for this type of lab equipment
    public override void InitializeSettings()
    {
        // name, units, minimum, maximum, initial value
        EquipmentSetting equipmentSetting = new EquipmentSetting("Mass", "kg", 0.0f, 20.0f, 2.0f);
        // add the setting to the dictionary of settings
        Settings.Add(equipmentSetting.Name, equipmentSetting);

        // name, units, minimum, maximum, initial value
        equipmentSetting = new EquipmentSetting("Incline", "degree", 0.0f, 60.0f, 15.0f);
        // add the setting to the dictionary of settings
        Settings.Add(equipmentSetting.Name, equipmentSetting);

        // name, units, minimum, maximum, initial value
        equipmentSetting = new EquipmentSetting("Length", "m", 0.0f, 1.0f, 0.0f);
        Settings.Add(equipmentSetting.Name, equipmentSetting);

        // name, units, minimum, maximum, initial value
        equipmentSetting = new EquipmentSetting("Friction", "", 0.0f, 2.0f, 0.0f);
        Settings.Add(equipmentSetting.Name, equipmentSetting); 
        
    }



}


