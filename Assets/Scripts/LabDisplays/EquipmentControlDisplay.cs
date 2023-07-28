/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 14, 2023 
 * File: EquipmentControlDisplay.cs
 * 
 * Class: EquipmentControlDisplay
 * Purpose: Lets the user change lab equipment settingsList from a control pannel. 
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
using static EquipmentType;


public class EquipmentControlDisplay : MonoBehaviour
{

    [SerializeField] private GameObject[] equipControlPrefabs;
    [SerializeField] private TMP_Dropdown controlDropdown;

    private Image equipmentControlPanel;
    private GameObject newControl;

    private Dictionary<int, GameObject> equipmentControlList;

   



    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        
        equipmentControlList = new Dictionary<int, GameObject>();

        // setup the dropdown control list action for when a control is selected to display
        controlDropdown.onValueChanged.AddListener(ShowEquipmentControl);
    }


    public void AddEquipmentControl(LabEquipment equipment)
    {
        int equipmentId = (int)equipment.EquipmentID;
        TypeOfEquipment equipType = equipment.EquipType;
        newControl = Instantiate(equipControlPrefabs[(int)equipType]);

        switch (equipType)
        {
            case TypeOfEquipment.Block:
                newControl.GetComponent<Block>().initializeControlGUI(equipment);
                Debug.Log("new Block added to controls");
                break;

            case TypeOfEquipment.Ramp:
                newControl.GetComponent<Ramp>().initializeControlGUI(equipment);
                Debug.Log("new Block added to controls");
                break;
        }

        equipmentControlList[equipmentId] = newControl;

    }


    public void ShowEquipmentControl(int value)
    {
        if (equipmentId >= 0)
        {
            equipmentControlPanel.gameObject.SetActive(false);
            // need to remove current component and add in new component ????
            equipmentControlPanel.gameObject.SetActive(true);
            
        }

    }


    public bool ShowControl { get => showControl; set => showControl = value; }

}