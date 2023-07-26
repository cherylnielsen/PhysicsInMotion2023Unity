using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentTypes
{
    private List<string> equipmentTypeList;

    public EquipmentTypes()
    {
        equipmentTypeList = new List<string>();
    }

    public void add(string equipType)
    {
        equipmentTypeList.Add(equipType);
    }

    public void remove(string equipType) 
    {
        equipmentTypeList.Remove(equipType);
    }

    public void clear()
    {
        equipmentTypeList = new List<string>();
    }

    // returns -1 if equipment type does not exist
    public int getEquipmentTypeId(string equipType)
    {
        int id = equipmentTypeList.IndexOf(equipType);
        return id;
    }

    public bool contains(string equipType)
    {
        bool hasEquipmentType = equipmentTypeList.Contains(equipType);
        return hasEquipmentType;
    }

}
