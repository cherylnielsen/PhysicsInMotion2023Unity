/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 14, 2023 
 * File: EquipmentControlDisplay.cs
 * 
 * Class: EquipmentControlDisplay
 * Purpose: Lets the user change lab equipment settings from a control pannel. 
 * 
 **/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

namespace LabManagers
{
    public class EquipmentControlDisplay : MonoBehaviour
    {
        [SerializeField] private List<GameObject> labEquipmentList;
        
        public EquipmentControlDisplay() 
        {
            labEquipmentList = new List<GameObject>();
        }


        // Awake is called when the script instance is being loaded
        private void Awake()
        {
            
        }

        // Start is called before the first frame update
        void Start()
        {

        }


        // Update is called once per frame
        void Update()
        {

        }


        bool initializeEquipmentList()
        {

            return true;
        }


        bool initializeEquipmentSettings()
        {

            return true;
        }

    }
}