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
using UnityEngine;

namespace LabManagers
{
    public class LabManager : MonoBehaviour
    {
        public static LabManager intance = null;
        private LabManager() { }

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
            
            // other initializations

        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


        // save lab settings data graphs math diagrams etc to database
        // inititalize settings from database


    }
}