/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 22, 2023  
 * File: Cart.cs
 * 
 * Class: eType
 * Purpose: Abstract class that stores and adjusts the settingsList generic to any lab equipment.
 *          All lab equipment inherit from this class.
 **/

using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEditor;
using UnityEngine;
using static EquipmentType;


public abstract class LabEquipment : MonoBehaviour 
{
    private int equipmentID;
    private string equipmentName;
    private string description;
    private eType equipType;

    private Dictionary<string, EquipmentSetting> settings;

    public void Initialize(int id, eType type)
    {
        EquipmentID = id;
        EquipType = type;
        EquipmentName = EquipType.ToString() + "_" + id;
        Description = EquipType.ToString();
    }

    public abstract void InitializeSettings();

    // warning: replaces current equipment setting with that name, without notice
    public bool addSetting(EquipmentSetting equipmentSetting)
    {
        settings.Add(equipmentSetting.Name, equipmentSetting);
        return true;
    }

    public bool removeSetting(string equipmentSettingName)
    {
        if (settings.ContainsKey(equipmentSettingName))
        {
            settings.Remove(equipmentSettingName);
            return true;
        }

        return false;
    }

    public EquipmentSetting getSetting(string equipmentSettingName)
    {
        if(settings.ContainsKey(equipmentSettingName))
        {
            return settings[equipmentSettingName];
        }    

        return null;
    }


    // Getters and Setters

    public eType EquipType { get => equipType; set => equipType = value; }
    public int EquipmentID { get => equipmentID; set => equipmentID = value; }
    public string EquipmentName { get => equipmentName; set => equipmentName = value; }
    public string Description { get => description; set => description = value; }
    
}
