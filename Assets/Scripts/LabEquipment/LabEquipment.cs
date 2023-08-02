/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 22, 2023  
 * File: Cart.cs
 * 
 * Class: TypeOfEquipment
 * Purpose: Abstract class that stores and adjusts the settingsList generic to any lab equipment.
 *          All lab equipment inherit from this class.
 **/

using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using static EquipmentType;


public abstract class LabEquipment : MonoBehaviour 
{
    private int equipmentID;
    private string equipmentName;
    private string description;
    private EquipmentType equipType;

    private Dictionary<string, EquipmentSetting> equipSettings;
    private Dictionary<string, EquipmentSettingControl> equipSettingsControl;

    public abstract void updateSetting(string settingType, string key, string value);

    public abstract void removeSetting(string settingType, string key, string value);

    public abstract void addSetting(string settingType, string key, string value);

    public abstract void updateSettingControl(string settingType, string key, string value);

    public abstract void removeSettingControl(string settingType, string key, string value);

    public abstract void addSettingControl(string settingType, string key, string value);


    public EquipmentType EquipType { get => equipType; set => equipType = value; }
    public int EquipmentID { get => equipmentID; set => equipmentID = value; }
    public string EquipmentName { get => equipmentName; set => equipmentName = value; }
    public string Description { get => description; set => description = value; }
   

}
