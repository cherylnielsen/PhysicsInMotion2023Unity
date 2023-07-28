


using Unity.VisualScripting;
using UnityEngine.PlayerLoop;
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
public class EquipmentSetting
{
    string units;
    float max;
    float min;
    float value;

    public EquipmentSetting() { }

    public EquipmentSetting(string theUnits, float minimum, float maximum, float initialValue)
    {
        Units = theUnits;
        Max = maximum;
        Min = minimum;
        Value = initialValue;
    }

    public void initialize(string theUnits, float minimum, float maximum, float initialValue)
    {
        Units = theUnits;
        Max = maximum;
        Min = minimum;
        Value = initialValue;
    }

    public string Units { get => units; set => units = value; }
    public float Max { get => max; set => max = value; }
    public float Min { get => min; set => min = value; }
    public float Value { get => value; set => this.value = value; }
}
