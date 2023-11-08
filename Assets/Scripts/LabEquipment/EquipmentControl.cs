using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class EquipmentControl : MonoBehaviour
{
    LabEquipment labEquipment;
    EquipmentSetting equipmentSetting;
    Transform parentGUI;
    TextMeshPro equipName;
    TextMeshPro controlName;
    TextMeshPro controlValue;
    Slider slider;

    public void Awake()
    {
        //this.gameObject.SetActive(false);
        parentGUI = this.gameObject.transform;
        equipName = parentGUI.Find("EquipName").gameObject.GetComponent<TextMeshPro>();
        controlName = parentGUI.Find("ControlName").gameObject.GetComponent<TextMeshPro>();
        controlValue = parentGUI.Find("ControlValue").gameObject.GetComponent<TextMeshPro>();

        // need to get slider 
    }

    private void InitializeControl(LabEquipment equipment, EquipmentSetting setting)
    {
        Debug.Log("InitializeControl");

        labEquipment = equipment;
        equipmentSetting = setting;

        // initialize the GUI 
        equipName.text = equipment.EquipmentName;
        controlName.text = setting.Name + "(" + setting.Units + ")";
        controlValue.text = setting.Value.ToString();


        // slider.minValue = setting.Min;
        //slider.maxValue = setting.Max;
        // slider.value = setting.Value;

        // set the event actions for the controls in the control panel
        // slider.onValueChanged.AddListener(sliderAction);
    }


    private void sliderAction(float num)
    {
        equipmentSetting.Value = num;
        //controlValue.GetComponent<TextMeshPro>().text = num.ToString();
    }


}
