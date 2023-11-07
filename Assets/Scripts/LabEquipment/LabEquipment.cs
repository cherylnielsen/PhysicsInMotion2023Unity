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
        EquipmentName = EquipType.ToString() + "_" + EquipmentID;
        Description = EquipType.ToString();

        settings = new Dictionary<string, EquipmentSetting>();
        InitializeSettings();
    }

    // add the default equipment settings for this type of lab equipment
    public abstract void InitializeSettings();


    // Getters and Setters

    public Dictionary<string, EquipmentSetting> Settings { get { return settings; } }
    public eType EquipType { get => equipType; private set => equipType = value; }
    public int EquipmentID { get => equipmentID; set => equipmentID = value; }
    public string EquipmentName { get => equipmentName; set => equipmentName = value; }
    public string Description { get => description; set => description = value; }
    
}
