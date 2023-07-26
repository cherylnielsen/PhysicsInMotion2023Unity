/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 14, 2023 
 * File: EquipmentControlDisplay.cs
 * 
 * Class: EquipmentControlDisplay
 * Purpose: Lets the user change lab equipment settings from a control pannel. 
 * 
 **/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class EquipmentControlDisplay : MonoBehaviour
{
        
    [SerializeField] private TMP_Dropdown controlDropdown;
    [SerializeField] private List<GameObject> equipmentControls;

    /**
    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        controlDropdown.onValueChanged.AddListener(ShowEquipmentControls);
    }

    public void ShowEquipmentControls(int num)
    {
        Debug.Log("dropdown equipmentType: " + equipType.ToString());
    }
    **/



    
    public enum EquipmentType
    {
        none = 0, block, ramp, cart, sensor
    }

    private EquipmentType equipType;

    public EquipmentType EquipType
    {
        get { return equipType; }
        set { equipType = value; }
    }


    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        equipType = EquipmentType.none;
        controlDropdown.onValueChanged.AddListener(ShowEquipmentControls);
    }

    public void ShowEquipmentControls(int num)
    {
        equipType = (EquipmentType)num;
        Debug.Log("dropdown equipmentType: " + equipType.ToString());
    }
    


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
            
    }


}