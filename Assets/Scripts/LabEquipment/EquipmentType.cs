/**
* MS Computer Science Graduate Project: Physics In Motion
* San Francisco State University, San Francisco, CA
* 
* Author: Cheryl Nielsen
* Version: July 22, 2023  
* File: Cart.cs
* 
* Class: EquipmentType
* Purpose: 
* 
**/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


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
