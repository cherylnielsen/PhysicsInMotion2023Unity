


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
    private float max;
    // the minimum value that this setting will alow to be set
    private float min;
    // the initial or current value of the setting
    private float value;


    // empty constructor
    public EquipmentSetting() { }


    // full initializing constructor
    public EquipmentSetting(string name, string units, float min, float max, float value)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Units = units ?? throw new ArgumentNullException(nameof(units));
        Min = min;
        Max = max;
        Value = value;
    }


    // standard getters and setters
    public string Name { get => name; set => name = value; }
    public string Units { get => units; set => units = value; }
    public float Max { get => max; set => max = value; }
    public float Min { get => min; set => min = value; }
    
    public float Value 
    {
        get { return value; }

        set
        {
            if(Min <= value && value <= Max)
            {
                this.value = value;
            }
            else
            {
                this.value = Min;
            }
            
        }
    }

    
}
