/**
* MS Computer Science Graduate Project: Physics In Motion
* San Francisco State University, San Francisco, CA
* 
* Author: Cheryl Nielsen
* Version: July 22, 2023  
* File: Cart.cs
* 
* Class: EquipmentType
* Purpose: Enumeration class for type of equipment, for easier programming
* 
**/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class EquipmentType
{
    public enum eType
    {
        // the default of none is used to signal no equipent has been chosen
        None = -1, Block, Ramp
    }

    private eType equipType;

    public eType EquipType
    {
        get { return equipType; }
        set { equipType = value; }
    }

    public bool IsDefined(string equipment)
    {
        return Enum.IsDefined(typeof(eType), equipment);
    }

}
