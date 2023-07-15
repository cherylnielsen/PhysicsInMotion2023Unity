/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 14, 2023 
 * File: EquipmentControls.cs
 * 
 * Class: EquipmentControls
 * Purpose: Lets the user change lab equipment settings from a control pannel. 
 * 
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EquipmentControls : MonoBehaviour
{
    private enum EquipmentType
    {
        cart, ramp, sensor, none
    }

    private EquipmentType equipType;


    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

    }


    // For making dynamic GUI
    void OnGUI()
    {

    }


    }
