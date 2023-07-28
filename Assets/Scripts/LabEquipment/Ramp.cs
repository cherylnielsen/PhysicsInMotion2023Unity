


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

    private EquipmentSetting angleOfIncline;
    private EquipmentSetting frictionCoefficient;


    public override void initializeSettings(int equipID)
    {
        EquipmentID = equipID;
        EquipType = TypeOfEquipment.Ramp;
        EquipmentName = EquipType.ToString() + "_" + EquipmentID;
        Description = EquipType.ToString();

        // units, minimum, maximum, initial value
        AngleOfIncline = new EquipmentSetting("Angle of Incline", "degree", 0.0f, 90.0f, 15.0f);
        FrictionCoefficient = new EquipmentSetting("Coefficient of Friction", "", 0.0f, 2.0f, 0.0f);

        // add the settingsList to the list
        equipSettings.Add(AngleOfIncline);
        equipSettings.Add(FrictionCoefficient);
    }


    public override void initializeControlGUI(LabEquipment equipment)
    {
        throw new System.NotImplementedException();
    }


    public EquipmentSetting AngleOfIncline { get => angleOfIncline; set => angleOfIncline = value; }
    public EquipmentSetting FrictionCoefficient { get => frictionCoefficient; set => frictionCoefficient = value; }

}


