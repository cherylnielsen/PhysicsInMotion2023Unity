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
    [SerializeField] private Button cabinetButton;
    [SerializeField] private Button cartBtn, blockBtn, rampBtn, sensorBtn;
    [SerializeField] private Image buttonPanel;
    [SerializeField] private Camera cam;

    private bool showCabinet;
    private GameObject newEquipment;
    private EquipmentType equipmentType;
    public bool ShowCabinet { get => showCabinet; set => showCabinet = value; }


    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        ShowCabinet = false;
        equipmentType = new EquipmentType();
        equipmentType.EquipType = eType.None;
        buttonPanel.gameObject.SetActive(ShowCabinet);
        
        // buttons to select what equipment to add to the lab
        //blockBtn.onClick.AddListener(() => addEquipmentToLab(eType.Block));
        //rampBtn.onClick.AddListener(() => addEquipmentToLab(eType.Ramp));

    }


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (equipmentType.EquipType >= 0)
        {
            addEquipmentToLab();
        }
    }


    public void showEquipmentCabinet()
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



    // equipment chosen is placed at the location the user clicks with the mouse.
    public void addEquipmentToLab()
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
                // get the object that the ray hit
                // GameObject hitObject = hit.transform.gameObject;
                // or use Transform objectHit = hit.transform;
                // Do something with the object that was hit by the raycast.

                switch (equipmentType.EquipType)
                {
                    case (eType.Block):
                        newEquipment = Instantiate(equipmentPrefabs[(int)eType.Block]);
                        newEquipment.transform.position = hit.point;
                        newEquipment.GetComponent<Block>().InitializeSettings();
                        Debug.Log("new Block added to lab");
                        //LabManager.Instance.AddEquipmentControlGUI(newEquipment);
                        break;

                    case (eType.Ramp):
                        newEquipment = Instantiate(equipmentPrefabs[(int)eType.Ramp]);
                        newEquipment.transform.position = hit.point;
                        newEquipment.GetComponent<Ramp>().InitializeSettings();
                        Debug.Log("new Ramp added to lab");
                        //LabManager.Instance.AddEquipmentControlGUI(newEquipment);
                        break;
                }                
            }

        }
    }

    /**
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
    **/

    }
