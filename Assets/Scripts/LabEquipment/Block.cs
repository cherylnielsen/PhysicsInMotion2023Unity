/**
* MS Computer Science Graduate Project: Physics In Motion
* San Francisco State University, San Francisco, CA
* 
* Author: Cheryl Nielsen
* Version: July 22, 2023  
* File: Block.cs
* 
* Class: Block
* Purpose: Stores and adjusts the settingsList for the block.
**/

using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using static EquipmentType;


public class Block : LabEquipment
{
    // position, rotation, scale ??
    // mass, friction ??
   

    public override void InitializeSettings()
    {
        // add the default equipment settings for this type of lab equipment
        // name, units, minimum, maximum, initial value
        EquipmentSetting equipmentSetting = new EquipmentSetting("Mass", "kg", 0.0f, 20.0f, 2.0f);
        // add the setting to the list
        addSetting(equipmentSetting);

        // name, units, minimum, maximum, initial value
        equipmentSetting = new EquipmentSetting("Size", "m", 0.0f, 0.10f, 0.0f);
        addSetting(equipmentSetting);

        // name, units, minimum, maximum, initial value
        equipmentSetting = new EquipmentSetting("Friction", "", 0.0f, 2.0f, 0.0f);
        addSetting(equipmentSetting);

    }



 
}
