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


using Palmmedia.ReportGenerator.Core;
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
    [SerializeField] private Image equipControlSubPanel;

    private Dictionary<int, GameObject> equipmentControlList;
    private GameObject newControl;


    // Awake is called when the script instance is being loaded
    private void Awake()
    {        
        equipmentControlList = new Dictionary<int, GameObject>();

        // setup the dropdown control list action for when a control is selected to display
        controlDropdown.onValueChanged.AddListener(ShowEquipmentControl);
    }


    public void AddEquipmentControl(LabEquipment equipment)
    {
        foreach (KeyValuePair<string, EquipmentSetting> entry in equipment.Settings)
        {
            newControl = Instantiate(equipControlPrefabs[(int)equipment.EquipType]);
            newControl.SetActive(false);
            InitializeControlGUI(newControl, equipment, equipment.EquipType);
            int id = equipment.EquipmentID;
            equipmentControlList[id] = newControl;
            Debug.Log("added " + entry.Key + " controls");
        }

        
        
        Debug.Log("added equipment setting controls");

    }


    private void InitializeControlGUI(GameObject newControl, LabEquipment labEquipment, eType equipType)
    {
        //Slider slider;
        //TextMeshPro controlName;
        //TextMeshPro controlUnits;
        //TextMeshPro controlValue;
        //Button reset;

        
        // initialize the GUI 
        // controlName.GetComponent<TextMeshPro>().text = settings.Name;
        // controlUnits.GetComponent<TextMeshPro>().text = settings.Units;
        // controlValue.GetComponent<TextMeshPro>().text = settings.Value.ToString();


        // set the event actions for the controls in the control panel
        // slider.onValueChanged.AddListener(sliderAction);
        // reset.onClick.AddListener(resetToDefaultSettings);
    }

    public void ShowEquipmentControl(int num)
    {
        if (num >= 0)
        {
            equipmentControlList[num].SetActive(true);

        }
        else
        {
            equipmentControlList[num].SetActive(false);
        }
        
    }


}