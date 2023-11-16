using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public abstract class EquipmentControl : MonoBehaviour
{
    protected LabEquipment labEquipment;
    protected EquipmentSetting equipmentSetting;

    public abstract void InitializeControl(LabEquipment equipment, EquipmentSetting setting);
    public abstract void controlAction();


}
