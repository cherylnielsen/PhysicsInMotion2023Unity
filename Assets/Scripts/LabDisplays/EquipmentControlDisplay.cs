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
    private bool showControl;
    private TypeOfEquipment equipType;
    private bool isControlAdded;
    private GameObject newControl;

    private Dictionary<int, GameObject> equipmentControlList;

    public bool IsControlAdded { get => isControlAdded; set => isControlAdded = value; }
    public TypeOfEquipment EquipType { get => equipType; set => equipType = value; }
    public bool ShowControl { get => showControl; set => showControl = value; }



    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        equipType = new TypeOfEquipment();
        equipType = TypeOfEquipment.None;
        IsControlAdded = false;
        equipmentControlPanel.gameObject.SetActive(IsControlAdded);
        
        // setup the dropdown control list action for when a control is selected to display
        controlDropdown.onValueChanged.AddListener(ShowEquipmentControl);
    }




    public void ShowEquipmentControl(int equipmentId)
    {
        equipType = (TypeOfEquipment)equipmentId;

        if (equipmentId >= 0)
        {
            equipmentControlPanel.gameObject.SetActive(false);
            // need to remove current component and add in new component ????
            equipmentControlPanel.gameObject.SetActive(true);
            equipType = TypeOfEquipment.None;
        }
        
    }


    public void AddEquipmentControl(GameObject equipment, TypeOfEquipment equip)
    {
        GameObject equipmentControl = Instantiate(equipControlPrefabs[(int)equip]);
        //int id = 0;
        equipmentControlList[id] = equipmentControl;

        Debug.Log("controls added to lab");
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