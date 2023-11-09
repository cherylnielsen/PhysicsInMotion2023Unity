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
        equipName = parentGUI.Find("EquipName").GetComponent<TextMeshPro>();
        controlName = parentGUI.Find("ControlName").GetComponent<TextMeshPro>();
        controlValue = parentGUI.Find("ControlValue").GetComponent<TextMeshPro>();

        // need to get slider 
        slider = parentGUI.GetComponent<Slider>();
        
    }

    public void InitializeControl(LabEquipment equipment, EquipmentSetting setting)
    {
        Debug.Log("InitializeControl");

        labEquipment = equipment;
        equipmentSetting = setting;

        // set up the GUI text
        equipName.text = equipment.EquipmentName;
        controlName.text = setting.Name + "(" + setting.Units + ")";
        controlValue.text = setting.Value.ToString();

        // set up the GUI slider control
        slider.minValue = setting.MinValue;
        slider.maxValue = setting.MaxValue;
        slider.value = setting.Value;

        // set the event action for the slider control
        slider.onValueChanged.AddListener(sliderAction);
    }


    private void sliderAction(float num)
    {
        equipmentSetting.Value = num;
        controlValue.text = num.ToString();
    }


}
