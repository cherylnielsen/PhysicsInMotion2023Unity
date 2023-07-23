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


using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using LabManagers;


public class EquipmentCabinet : MonoBehaviour
{
    [SerializeField] private Button cabinetButton;
    [SerializeField] private Button cartBtn, blockBtn, rampBtn, sensorBtn;
    [SerializeField] private Image equipmentButtonPanel;
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject[] equipmentPrefabs;
    [SerializeField] private LabManager labManager;

    private GameObject newEquipment;
    private bool showCabinet;

    private enum EquipmentType
    {
        none = -1, cart = 0, block, ramp, sensor
    }

    private EquipmentType equipmentType;




    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        showCabinet = false;
        equipmentButtonPanel.gameObject.SetActive(showCabinet);
        equipmentType = EquipmentType.none;

        // setup the button on click actions
        cabinetButton.onClick.AddListener(ShowEquipmentCabinet);
        cartBtn.onClick.AddListener(delegate { SetEquipmentType(EquipmentType.cart); });
        blockBtn.onClick.AddListener(delegate { SetEquipmentType(EquipmentType.block); });
        rampBtn.onClick.AddListener(delegate { SetEquipmentType(EquipmentType.ramp); });
        sensorBtn.onClick.AddListener(delegate { SetEquipmentType(EquipmentType.sensor); });
    }


    // Start is called before the first frame update
    void Start()
    {
        //labManager = new LabManager();
    }

    // Update is called once per frame
    void Update()
    {
        if (equipmentType >= 0)
        {
            PlaceEquipment();
        }

    }


    private void SetEquipmentType(EquipmentType equip)
    {
        equipmentType = equip;
        Debug.Log("equipmentType: " + equipmentType.ToString());
    }

 
    void PlaceEquipment()
    {
        // If the mouse has been clicked in the lab room
        // and if an equipment type has been selected, then this returns true.
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()
            && equipmentType != EquipmentType.none)
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

                newEquipment = Instantiate(equipmentPrefabs[(int)equipmentType]);
                newEquipment.transform.position = hit.point;
                //Debug.Log("Hit: " + hit.point);

                // reset equipmentType to none to prevent unintended new equipment instantiations
                equipmentType = EquipmentType.none;
            }

        }

    }


    void ShowEquipmentCabinet()
    {
        if(showCabinet)
        {
            showCabinet = false;
            equipmentButtonPanel.gameObject.SetActive(showCabinet);
            equipmentType = EquipmentType.none;            
        }
        else
        {
            showCabinet = true;
            equipmentButtonPanel.gameObject.SetActive(showCabinet);            
        }

    }

    
}
