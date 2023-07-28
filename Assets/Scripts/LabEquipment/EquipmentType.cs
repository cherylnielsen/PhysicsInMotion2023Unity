using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class EquipmentType
{
    public enum TypeOfEquipment
    {
        None = -1, Block = 0, Ramp //, Cart, Sensor
    }

    private TypeOfEquipment equipType;

    public TypeOfEquipment EquipType
    {
        get { return equipType; }
        set { equipType = value; }
    }

    public bool contains(string equipment)
    {
        return Enum.IsDefined(typeof(TypeOfEquipment), equipment);
    }

}
