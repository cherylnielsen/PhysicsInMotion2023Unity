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
    private TypeOfEquipment equipType;

    protected List<EquipmentSetting> equipSettings;

    public abstract void initializeSettings(int equipID);
    public abstract void initializeControlGUI(LabEquipment equipment);


    public TypeOfEquipment EquipType { get => equipType; set => equipType = value; }
    public int EquipmentID { get => equipmentID; set => equipmentID = value; }
    public string EquipmentName { get => equipmentName; set => equipmentName = value; }
    public string Description { get => description; set => description = value; }
}
