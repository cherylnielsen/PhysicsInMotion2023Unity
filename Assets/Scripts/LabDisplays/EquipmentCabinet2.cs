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


using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using System;
using static EquipmentType;

public class EquipmentCabinet2 : MonoBehaviour
{
    [SerializeField] private GameObject[] equipmentPrefabs;
    [SerializeField] private Button cabinetButton;
    [SerializeField] private Button cartBtn, blockBtn, rampBtn, sensorBtn;
    [SerializeField] private Image buttonPanel;
    [SerializeField] private Camera cam;

    private bool showCabinet;
    private GameObject newEquipment;
    public bool ShowCabinet { get => showCabinet; set => showCabinet = value; }


    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        ShowCabinet = false;
        buttonPanel.gameObject.SetActive(ShowCabinet);
        
        // setup the button on click actions
        // button to show or hide the equipment list
        cabinetButton.onClick.AddListener(showEquipmentCabinet);
        // buttons to select what equipment to add to the lab
        blockBtn.onClick.AddListener(() => addEquipmentToLab(eType.Block));
        rampBtn.onClick.AddListener(() => addEquipmentToLab(eType.Ramp));

    }
   

    void showEquipmentCabinet()
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


    // eType is placed at the location the user chooses by clicking with the mouse.
    public void addEquipmentToLab(eType equipType)
    {
        if (equipType != eType.None)
        {
            // If the mouse has been clicked in the lab room
            // and if an equipment type has been selected, then this returns true.
            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                // Send a ray into the screen in the direction of the mouse.
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);

                // Place the equipment where the ray cast hit.
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    // get the object that the ray hit
                    // GameObject hitObject = hit.transform.gameObject;
                    // or use Transform objectHit = hit.transform;
                    // Do something with the object that was hit by the raycast.

                    newEquipment = Instantiate(equipmentPrefabs[(int)equipType]);
                    newEquipment.transform.position = hit.point;

                    switch (equipType)
                    {
                        case eType.Block:
                            newEquipment.GetComponent<Block>().initializeSettings(LabManager.LabEquipmentNumber++);
                            Debug.Log("new Block added to lab");
                            LabManager.Instance.addLabEquipment(newEquipment);                            
                            break;

                        case eType.Ramp:
                            newEquipment.GetComponent<Ramp>().initializeSettings(LabManager.LabEquipmentNumber++);
                            Debug.Log("new Ramp added to lab");
                            LabManager.Instance.addLabEquipment(newEquipment);
                            break;
                    }
                                        
                }
            }
        }
    }


}
