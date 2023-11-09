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
    private Dictionary<int, LabEquipment> labEquipmentList;

    private int equipmentId = 0;

    // Singleton Pattern, private instance of this class
    public static LabManager Intance;

    public int EquipmentId { get => equipmentId++; private set => equipmentId = value; }

    // Singleton Pattern, public access to this single object, so it can only be created once.




    // Awake is called when the script instance is being loaded
    // Awake acts like the initializer or constructor for the class
    private void Awake()
    {
        if (Intance == null)
        {
            labEquipmentList = new Dictionary<int, LabEquipment>();
            equipmentCabinet = equipCabinet.GetComponent<EquipmentCabinet2>();
            equipmentControls = equipControl.GetComponent<EquipmentControlDisplay>();
        }

        Intance = this;
    }


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {        
        

    }

    public void AddEquipmentToLab(LabEquipment equip)
    {
        int equipmentID = equip.EquipmentID;       
        labEquipmentList[equipmentID] = equip;      
        equipmentControls.AddEquipmentControls(equip);

    }


}
