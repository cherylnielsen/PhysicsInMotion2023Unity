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

namespace LabManagers
{
   
    public class LabManager : MonoBehaviour
    {
        // save lab settings data graphs math diagrams etc to database
        // inititalize settings from database
        [SerializeField] private EquipmentCabinet equipCabinet;
        [SerializeField] private EquipmentControlDisplay equipControlDisplay;

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
       

        // member variables for controlling lab actions
        //

        // Awake is called when the script instance is being loaded
        private void Awake()
        {
            GameObject gb = GameObject.Find("LabManager");
            equipCabinet = gb.GetComponent<EquipmentCabinet>();
            equipControlDisplay = gb.GetComponent<EquipmentControlDisplay>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }





    }
}