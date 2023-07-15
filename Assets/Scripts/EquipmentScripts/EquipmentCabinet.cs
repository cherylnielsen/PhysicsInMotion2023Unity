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


public class EquipmentCabinet : MonoBehaviour
{
    private enum EquipmentType
    {
        cart, ramp, sensor
    }
   
    private GameObject newEquipment;

    public Camera cam;
    // for linking to the prefabricated equipment game object assets
    public GameObject[] equipmentPrefabs;

    // Start is called before the first frame update
    void Start()
    {        
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
        int equipmentType = -1;

        if()

        // if the mouse has been clicked in the lab room this returns true
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && equipmentType >= 0)
        {
            PlaceEquipment(equipmentType);
        }

    }


    void OnGUI()
    {
        // this lets the user know where the ray shooter is currently pointing,
        // by laying the text "*" on the screen using a GUI game interface lable
        int size = 100;
        float posX = cam.pixelWidth / 2 - size / 4;
        float posY = cam.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");


    }


    void PlaceEquipment(int index)
    {
        // Send a ray in the direction that the camera is looking,
        // at the center of the camera field of view.
        Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
        Ray ray = cam.ScreenPointToRay(point);
        RaycastHit hit;

        // did the cast out ray hit anything
        if (Physics.Raycast(ray, out hit))
        {
            // Place equipment where the ray hit.
            newEquipment = Instantiate(equipmentPrefabs[index]);
            newEquipment.transform.position = hit.point;
            Debug.Log("Hit: " + hit.point);
        }

    }


    void ShowEquipmentCabinet(bool showCabinet)
    {
        if(showCabinet)
        {

        }
        else
        {

        }

    }

    
}
