/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 14, 2023  
 * File: EquipmentCabinet.cs
 * 
 * Class: EquipmentCabinet
 * Purpose: Lets the user add lab equipment to the lab room.  Equipment is placed at 
 * the location the user chooses by clicking with the mouse.  A control pannel is also 
 * added to the lab room for the chosen equipment.
 * 
 * The user clicks a button on the equipment list to choose an equipment item.
 * The user then clicks a location in the lab room to place the equipment item.
 * The chosen equipment item is added to the room at that location and a 
 * 
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;


public class EquipmentCabinet : MonoBehaviour
{
    [SerializeField] private Button equipmentButton, cartButton, rampButton, sensorButton;
    [SerializeField] private Image equipmentButtonPanel;
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject[] equipmentPrefabs;

    private enum EquipmentType
    {
        cart, ramp, sensor, none
    }
   
    private GameObject newEquipment;
    private bool showCabinet;
    private EquipmentType equipmentType;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        equipmentButtonPanel.gameObject.SetActive(false);
        equipmentType = EquipmentType.none;
    }

    // Start is called before the first frame update
    void Start()
    {
        equipmentButton.onClick.AddListener(ShowEquipmentCabinet);
        cartButton.onClick.AddListener(delegate { SetEquipmentType(EquipmentType.cart); });
        rampButton.onClick.AddListener(delegate { SetEquipmentType(EquipmentType.ramp); });
        sensorButton.onClick.AddListener(delegate { SetEquipmentType(EquipmentType.sensor); });

    }

    // Update is called once per frame
    void Update()
    {

        if ((int)equipmentType != (int)EquipmentType.none)
        {
            PlaceEquipment();
        }

    }
    
    
    void SetEquipmentType(EquipmentType equipType)
    {
        equipmentType = equipType;
    }

 
    void PlaceEquipment()
    {
        int equipType = (int)equipmentType;
        int none = (int)EquipmentType.none;

        // if the mouse has been clicked in the lab room this returns true
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()
            && equipType != none)
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
            newEquipment = Instantiate(equipmentPrefabs[equipType]);
            newEquipment.transform.position = hit.point;
            Debug.Log("Hit: " + hit.point);
            }
        }

    }


    void ShowEquipmentCabinet()
    {
        if(showCabinet)
        {
            equipmentButtonPanel.gameObject.SetActive(false);
            equipmentType = EquipmentType.none;
            showCabinet = false;
        }
        else
        {
            equipmentButtonPanel.gameObject.SetActive(true);
            showCabinet = true;
        }

    }

    
}
