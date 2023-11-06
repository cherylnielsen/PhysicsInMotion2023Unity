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
 * 
 **/

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Numerics;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static EquipmentType;


public class LabManager : MonoBehaviour
{    
    // the equipment cabinet menu
    [SerializeField] private GameObject equipCabinet;
    private EquipmentCabinet2 equipmentCabinet;

    // the equipment controls menu
    [SerializeField] private GameObject equipControl;
    private EquipmentControlDisplay equipmentControls;

    // the main camera in the scene, attached to the first person player controler
    [SerializeField] private Camera cam;

    // the list of equipment in the lab
    private Dictionary<int, GameObject> labEquipmentList; 


    // Singleton Pattern, private instance of this class
    private static LabManager intance = null;       
    // Singleton Pattern, public access to this single object, so it can only be created once.
    public static LabManager Instance
    { 
        get 
        {
            if (intance == null)
            {
                intance = new LabManager();
            }
               
            return Instance;                
        } 
    }


    // Awake is called when the script instance is being loaded
    // Awake acts like the initializer or constructor for the class
    private void Awake()
    {
        labEquipmentList = new Dictionary<int, GameObject>();
        
        equipmentCabinet = equipCabinet.GetComponent<EquipmentCabinet2>();
        equipmentControls = equipControl.GetComponent<EquipmentControlDisplay>();

    }


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {        
        

    }

    public void AddEquipmentControlGUI(GameObject equip)
    {
        int equipmentID = equip.GetComponent<LabEquipment>().EquipmentID;       
        labEquipmentList[equipmentID] = equip;      
        equipmentControls.AddEquipmentControl(equip);
    }

    

    }
