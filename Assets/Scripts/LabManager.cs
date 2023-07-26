/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 14, 2023 
 * File: LabManager.cs
 * 
 * Class: LabManager
 * Purpose: Singleton controller for the lab room scenes. 
 * 
 **/

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using LabEquipment;
using System;


public class LabManager : MonoBehaviour
{    
    
    [SerializeField] private GameObject equipCabinetOb;
    private EquipmentCabinet2 equipmentCabinet;

    [SerializeField] private GameObject equipControlOb;
    private EquipmentControlDisplay equipmentControls;

    [SerializeField] private Camera cam;
    [SerializeField] private GameObject[] equipmentPrefabs;
    //[SerializeField] private GameObject[] equipControlPrefabs;
        

    private GameObject newEquipment;
    private int equipmentId;

    // global list of all equipment types available to the lab room
    // populated from the database
    private EquipmentTypes equipmentTypes;

    // global list of all equipment instances added to the lab room by the user
    private List<GameObject> equipmentInLab;


    // Singleton Pattern, persistant single created object of this class
    public static LabManager intance = null;       
    // Singleton Pattern, public access to this single object, so it can only be created once.
    public static LabManager Instance
    { 
        get 
        {
            if (LabManager.intance == null)
            {
                LabManager.intance = new LabManager();
            }
               
            return LabManager.Instance;                
        } 
    }
       


    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        //equipCabinetOb = GameObject.Find("EquipmentInventoryCabinetUI");
        equipmentCabinet = equipCabinetOb.GetComponent<EquipmentCabinet2>();
        //equipControlOb = GameObject.Find("EquipmentControlsUI");
        equipmentControls = equipControlOb.GetComponent<EquipmentControlDisplay>();

    }


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        equipmentId = (int)equipmentCabinet.EquipType;

        if (equipmentId >= 0)
        {
            AddEquipmentToLab();
                
        }


    }


    private void AddEquipmentToControls()
    {
            
    }


    public void AddEquipmentToLab()
    {
        // If the mouse has been clicked in the lab room
        // and if an equipment type has been selected, then this returns true.
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()
            && equipmentId >= -1)
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

                newEquipment = Instantiate(equipmentPrefabs[equipmentId]);
                newEquipment.transform.position = hit.point;
                //Debug.Log("Hit: " + hit.point);

                AddEquipmentToControls();
                equipmentCabinet.SetEquipmentType(-1);
            }

        }

    }


}
