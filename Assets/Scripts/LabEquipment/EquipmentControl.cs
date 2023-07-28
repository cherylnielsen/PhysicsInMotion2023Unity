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

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static EquipmentType;


public class EquipmentControl : MonoBehaviour
{
    [SerializeField] private LabEquipment equipment;
    [SerializeField] private EquipmentSetting equipmentSetting;
    [SerializeField] private Image controlPanel;
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshPro controlName;
    [SerializeField] private TextMeshPro controlUnits;
    [SerializeField] private TextMeshPro controlValue;
    [SerializeField] private Button reset;

    private int equipmentId;

    private bool showControlPanel;

    private void Awake()    
    {
        showControlPanel = false;
        controlPanel.gameObject.SetActive(false);
        equipmentSetting = equipment.GetComponent<EquipmentSetting>();

        // set the event actions for the controls in the control panel
        slider.onValueChanged.AddListener(setValue);
        reset.onClick.AddListener(resetToDefaultSettings);
    }

    
    public void initializeControlGUI()
    {
        showControlPanel = false;
        controlPanel.gameObject.SetActive(showControlPanel);

        // set the default values for the controls in the control panel
        controlName = equipmentSetting.Name();




    }


    private void resetToDefaultSettings()
    {
        throw new NotImplementedException();
    }


    private void setValue(float arg0)
    {
        throw new NotImplementedException();
    }


    void showControlGUI()
    {
        if (showControlPanel)
        {
            showControlPanel = false;
            controlPanel.gameObject.SetActive(showControlPanel);
        }
        else
        {
            showControlPanel = true;
            controlPanel.gameObject.SetActive(showControlPanel);
        }

    }


}

