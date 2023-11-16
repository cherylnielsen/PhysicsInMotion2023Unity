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
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static EquipmentType;


public class EquipmentControlDisplay : MonoBehaviour
{
    [SerializeField] private Button controlButton;
    [SerializeField] private Image mainControlPanel;
    [SerializeField] private GameObject equipControlPrefab;

    private List<GameObject> equipmentControlList;

    private bool showControls;
    public bool ShowControls { get => showControls; set => showControls = value; }
    public List<GameObject> EquipmentControlList { get => equipmentControlList; set => equipmentControlList = value; }


    // Awake is called when the script instance is being loaded
    private void Awake()
    {        
        EquipmentControlList = new List<GameObject>();
        showControls = false;
        mainControlPanel.gameObject.SetActive(showControls);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideSelectedEquipControls()
    {
        // To Be Done
        
    }

    public void AddEquipmentControls(LabEquipment equipment)
    {
        foreach (KeyValuePair<string, EquipmentSetting> entry in equipment.Settings)
        {
            GameObject control = Instantiate(equipControlPrefab);
            control.transform.SetParent(mainControlPanel.transform, false);            
            EquipmentControlList.Add(control);
        }

        if(showControls == false & EquipmentControlList.Count > 0)
        {
            showControls = true;
            mainControlPanel.gameObject.SetActive(showControls);
        }

        Debug.Log("count equipment control list " + EquipmentControlList.Count);
    }


    public void ShowEquipmentControls()
    {
        if (ShowControls)
        {
            ShowControls = false;
            mainControlPanel.gameObject.SetActive(ShowControls);
        }
        else
        {
            ShowControls = true;
            mainControlPanel.gameObject.SetActive(ShowControls);
        }

    }



}