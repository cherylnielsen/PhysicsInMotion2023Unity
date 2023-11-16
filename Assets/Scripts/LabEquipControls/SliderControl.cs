using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : EquipmentControl
{
    TextMeshPro equipName;
    TextMeshPro controlName;
    TextMeshPro controlValue;
    Slider slider;


    public void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void InitializeControl(LabEquipment equipment, EquipmentSetting setting)
    {
        Debug.Log("InitializeControl");

        labEquipment = equipment;
        equipmentSetting = setting;
        TextMeshPro[] texts = this.GetComponents<TextMeshPro>();
        slider = this.GetComponent<Slider>();

        // set up the GUI text
        equipName.text = equipment.EquipmentName;
        controlName.text = setting.Name + "(" + setting.Units + ")";
        controlValue.text = setting.Value.ToString();

        // set up the GUI slider control
        slider.minValue = setting.MinValue;
        slider.maxValue = setting.MaxValue;
        slider.value = setting.Value;

        // set the event action for the slider control
        //slider.onValueChanged.AddListener(sliderAction);
    }

    /**
    private void sliderAction(float num)
    {
        equipmentSetting.Value = num;
        controlValue.text = num.ToString();
    }
    **/

    public override void controlAction()
    {
        throw new System.NotImplementedException();
    }
}
