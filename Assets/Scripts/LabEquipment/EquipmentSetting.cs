


using System;
/**
* MS Computer Science Graduate Project: Physics In Motion
* San Francisco State University, San Francisco, CA
* 
* Author: Cheryl Nielsen
* Version: July 22, 2023  
* File: Cart.cs
* 
* Class: EquipmentSetting
* Purpose: Abstract class that stores and adjusts the settingsList generic to any lab equipment.
*          All lab equipment inherit from this class.
**/
public class EquipmentSetting
{
    // name = what is being set, the name of this group of settings
    private string name;
    // the units for this setting, needed for data, math, graphs, diagrams, etc
    private string units;
    // the maximum value that this setting will alow to be set
    private float maxValue;
    // the minimum value that this setting will alow to be set
    private float minValue;
    // the initial or current value of the setting
    private float value;

    public EquipmentSetting(EquipmentSetting equipSetting)
    {
        Name = equipSetting.Name;
        Units = equipSetting.Units;
        MinValue = equipSetting.MinValue;
        MaxValue = equipSetting.MaxValue;
        Value = equipSetting.MinValue;
    }


    // full initializing constructor
    public EquipmentSetting(string name, string units, float minValue, float maxValue, float value)
    {
        Name = name;
        Units = units;
        MinValue = minValue;
        MaxValue = maxValue;
        Value = value;
    }



    // standard getters and setters
    public string Name { get => name; set => name = value; }
    public string Units { get => units; set => units = value; }
    public float MaxValue { get => maxValue; set => maxValue = value; }
    public float MinValue { get => minValue; set => minValue = value; }
    
    public float Value 
    {
        get { return value; }

        set
        {
            if(MinValue <= value && value <= MaxValue)
            {
                this.value = value;
            }
            else
            {
                this.value = MinValue;
            }
            
        }
    }

    
}
