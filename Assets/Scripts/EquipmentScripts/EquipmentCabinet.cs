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
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EquipmentCabinet : MonoBehaviour
{

    private Vector3 screenPosition;
    private GameObject newEquipment;
    private Camera _camera;


    // Start is called before the first frame update
    void Start()
    {
        // get access to the camera and its components
        _camera = GetComponent<Camera>();
        // locks the location of the mouse cursor in the center of the screen,
        // and makes it invisible so that it does not distract.
        // WARNING: Remember to use Escape Key (ESC) to restore the mouse cursor so you can leave the game.
        Debug.Log("WARNING: Remember to use Escape Key to restore the mouse cursor.");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        // if the mouse has been clicked this returns true
        if (Input.GetMouseButtonDown(0))
        {
            PlaceEquipment(1);
        }

    }


    // this lets the user know where the ray shooter is currently pointing,
    // by laying the text "*" on the screen using a GUI game interface lable
    void OnGUI()
    {
        int size = 12;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }


    void PlaceEquipment(int type = 0)
    {
        // if the mouse was clicked shoot a ray in the direction that the camera is looking,
        // and shoot it at the center of the camera field of view
        // find the center of the camera field of view X and Y
        Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
        // create the ray (cast it out) with that vector location as its point of origin
        Ray ray = _camera.ScreenPointToRay(point);
        RaycastHit hit;
        // did the cast out ray hit anything
        if (Physics.Raycast(ray, out hit))
        {
            // if false, show where the object was hit, by running a coroutine called SphereIndicator
            StartCoroutine(SphereIndicator(hit.point));
            //MakeAnimal(1);
        }

        //GameObject dummy;
        // Make a new dummy GameObeject to be the new animal or plant.
        //newEquipment = Instantiate(dummy, screenPosition, Quaternion.identity) as GameObject;
        //newEquipment.transform.Find("Plane").GetComponent<Renderer>().material = animal1;

    }


    // this is the coroutine called 
    // This shows where an object was hit by the ray at point pos,
    // by creating a sphere at that point for one second.
    private IEnumerator SphereIndicator(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;

        // pause this function for one second, so that the user can see the sphere 
        // indicating where the ray hit an object, and meanwhile keep the game playing,
        // then come back to this function to continue to the next line in one second.
        yield return new WaitForSeconds(1);

        // destroy the temporary sphere object
        Destroy(sphere);
    }


    
}
