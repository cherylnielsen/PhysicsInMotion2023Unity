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
    [SerializeField] private Texture mouseImage;
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject[] equipmentPrefabs;

    private enum EquipmentType
    {
        cart, ramp, sensor
    }
   
    private GameObject newEquipment;
    private bool showCabinet;

    private void Awake()
    {
        equipmentButtonPanel.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        equipmentButton.onClick.AddListener(ShowEquipmentCabinet);
        cartButton.onClick.AddListener(delegate { PlaceEquipment(EquipmentType.cart); });
        rampButton.onClick.AddListener(delegate { PlaceEquipment(EquipmentType.ramp); });
        sensorButton.onClick.AddListener(delegate { PlaceEquipment(EquipmentType.sensor); });

        // locks the location of the mouse cursor in the center of the screen,
        // and makes it invisible so that it does not distract.
        // WARNING: Remember to use Escape Key (ESC) to restore the mouse cursor so you can leave the game.
        //Debug.Log("WARNING: Remember to use Escape Key to restore the mouse cursor.");
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    
    void OnGUI()
    {
        // Lets the user know where the ray shooter is currently pointing
        int size = 20;
        float posX = cam.pixelWidth / 2 - size / 4;
        float posY = cam.pixelHeight / 2 - size / 2;
        GUI.DrawTexture(new Rect(posX, posY, size, size), mouseImage);
        //GUI.Label(new Rect(posX, posY, size, size), "*");


    }
    

    //void PlaceEquipment(EquipmentType equipType)
    //{
        /**
        Vector3 point = new Vector3();
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();

        // Get the mouse position from Event.
        // Note that the y position from Event is inverted.
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
        **/
        /**
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
            Debug.Log("Hit: " + hit.point);
        }


    }**/


    
    void PlaceEquipment(EquipmentType equipType)
    {

        // Send a ray in the direction that the camera is looking at the center of the camera field of view.
        Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
        Ray ray = cam.ScreenPointToRay(point);
        RaycastHit hit;

        // If a hit, then place equipment where the ray cast hit.
        if (Physics.Raycast(ray, out hit))
        {
            newEquipment = Instantiate(equipmentPrefabs[(int)equipType]);
            newEquipment.transform.position = hit.point;
            Debug.Log("Hit: " + hit.point);
        }

    }
    


    void ShowEquipmentCabinet()
    {
        if(showCabinet)
        {
            equipmentButtonPanel.gameObject.SetActive(false);
            showCabinet = false;
        }
        else
        {
            equipmentButtonPanel.gameObject.SetActive(true);
            showCabinet = true;
        }

    }

    
}
