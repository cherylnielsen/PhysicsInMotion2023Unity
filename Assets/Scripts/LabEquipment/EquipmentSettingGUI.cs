using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentSettingGUI : MonoBehaviour
{
    Slider slider;
    TextMeshPro settingName;
    TextMeshPro units;
    TextMeshPro value;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void InitializeGUI(LabEquipment labEquipment, EquipmentSetting setting)
    {
        // initialize the GUI 
        settingName.GetComponent<TextMeshPro>().text = setting.Name;
        units.GetComponent<TextMeshPro>().text = setting.Units;
        value.GetComponent<TextMeshPro>().text = setting.Value.ToString();

        // set the event actions for the controls in the control panel
        slider.onValueChanged.AddListener(sliderAction);

    }


    private void sliderAction(float num)
    {
        value.GetComponent<TextMeshPro>().text = num.ToString();
    }


}
