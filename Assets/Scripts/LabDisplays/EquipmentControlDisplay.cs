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
    private List<GameObject> equipmentControlList;

    [SerializeField] private GameObject equipControlPrefab;
    [SerializeField] private Button controlButton;
    [SerializeField] private Image mainControlPanel;

    private bool showControls;
    public bool ShowControls { get => showControls; set => showControls = value; }


    // Awake is called when the script instance is being loaded
    private void Awake()
    {        
        equipmentControlList = new List<GameObject>();
        showControls = false;
        mainControlPanel.gameObject.SetActive(showControls);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideSelectedEquipControls(Button button)
    {
        // To Be Done
        string text = button.GetComponent<TextMeshPro>().text;
        int id = 0;
    }

    public void AddEquipmentControls(LabEquipment equipment)
    {
        foreach (KeyValuePair<string, EquipmentSetting> entry in equipment.Settings)
        {
            GameObject control = Instantiate(equipControlPrefab);
            control.transform.SetParent(mainControlPanel.transform, false);            
            equipmentControlList.Add(control);
        }

        if(showControls == false & equipmentControlList.Count > 0)
        {
            showControls = true;
            mainControlPanel.gameObject.SetActive(showControls);
        }
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