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

    // units, range of values, and initial value
    private EquipmentSetting mass;
    private EquipmentSetting friction;


    public void initializeSettings()
    {
        EquipmentID = equipID;
        EquipType = TypeOfEquipment.Block;
        EquipmentName = EquipType.ToString() + "_" + equipID;
        Description = EquipType.ToString();

        // units, minimum, maximum, initial value
        Mass = new EquipmentSetting("Mass", "kg", 0.0f, 20.0f, 2.0f);
        // units, minimum, maximum, initial value
        Friction = new EquipmentSetting("Friction", "", 0.0f, 2.0f, 0.0f);

        // add the settingsList to the list
        EquipSettings.Add(Mass);
        EquipSettings.Add(Friction);
    }


    public override void updateSetting(string settingType, string key, string value)
    {
        throw new System.NotImplementedException();
    }

    public override void removeSetting(string settingType, string key, string value)
    {
        throw new System.NotImplementedException();
    }

    public override void addSetting(string settingType, string key, string value)
    {
        throw new System.NotImplementedException();
    }

    public override void updateSettingControl(string settingType, string key, string value)
    {
        throw new System.NotImplementedException();
    }

    public override void removeSettingControl(string settingType, string key, string value)
    {
        throw new System.NotImplementedException();
    }

    public override void addSettingControl(string settingType, string key, string value)
    {
        throw new System.NotImplementedException();
    }
}
