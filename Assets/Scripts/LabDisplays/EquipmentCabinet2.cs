/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 14, 2023  
 * File: EquipmentCabinet2.cs
 * 
 * Class: EquipmentCabinet2
 * Purpose: Lets the user select lab equipment from a list to add to the lab room.  
 * 
 * The user clicks a button on the equipment list to choose an equipment item.
 * The user then clicks a location in the lab room to place the equipment item.
 * 
 **/


using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static EquipmentType;

public class EquipmentCabinet2 : MonoBehaviour
{
    [SerializeField] private GameObject[] equipmentPrefabs;
    [SerializeField] private Image buttonPanel;
    [SerializeField] private Camera cam;

    private EquipmentType equipmentType;
    private bool showCabinet;    

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        ShowCabinet = false;
        equipmentType = new EquipmentType();
        equipmentType.EquipType = eType.None;
        buttonPanel.gameObject.SetActive(ShowCabinet);
    }


    // Update is called once per frame
    void Update()
    {
        if (equipmentType.EquipType != eType.None)
        {
            AddEquipmentToLab();
        }
    }


    public void ShowEquipmentCabinet()
    {
        if (ShowCabinet)
        {
            ShowCabinet = false;
            buttonPanel.gameObject.SetActive(ShowCabinet);            
        }
        else
        {
            ShowCabinet = true;
            buttonPanel.gameObject.SetActive(ShowCabinet);
            
        }

    }

    public void SetEquipmentType(int equipType)
    {
        equipmentType.EquipType = (eType)equipType;
        Debug.Log("equipmentType: " + equipmentType.EquipType);
    }

    public bool ShowCabinet { get => showCabinet; set => showCabinet = value; }


    // equipment chosen is placed at the location the user clicks with the mouse.
    public void AddEquipmentToLab()
    {
        // If the left mouse buttton has been clicked in the lab room,
        // and if an equipment type has been selected, then this returns true.
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()
            && equipmentType.EquipType != eType.None)
        {

            // Send a ray into the screen in the direction of the mouse.
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            // Place the equipment where the ray cast hit.
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                LabEquipment labEquipment = Instantiate(equipmentPrefabs[(int)equipmentType.EquipType]).GetComponent<LabEquipment>();
                labEquipment.transform.position = hit.point;
                LabManager.Intance.AddEquipmentToLab(labEquipment);
                Debug.Log("new " + equipmentType.EquipType.ToString() + "added to lab");
            }

            equipmentType.EquipType = eType.None;
        }

    }

    

    }
