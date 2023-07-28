/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 26, 2023  
 * File: EquipmentControl.cs
 * 
 * Class: EquipmentControl
 * Purpose: A control pannel for an item of equipment that is in the lab room.
 * The control pannel lets the user choose the settiings for that equipment item.
 * 
 * 
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public abstract class EquipmentControl : MonoBehaviour
{
    // setup default event notifications
    // setup default gui items
    // give any equipment associated with this control a handle to this control
    // do not give this access to the equipment directly, can be part of multiple equipments

    [SerializeField] private Image controlPanel;


    // Awake is called when the script instance is being loaded
    private void Awake()
    {            
        initializeControl();
        //displayControl();
    }
                

    public abstract void initializeControl();



        

}

