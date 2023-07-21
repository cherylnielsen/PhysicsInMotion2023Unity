/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 14, 2023 
 * File: EquipmentControl.cs
 * 
 * Class: EquipmentControls
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
    public class EquipmentControl : MonoBehaviour
    {
        private ArrayList labEquipmentList;


        // Awake is called when the script instance is being loaded
        private void Awake()
        {
            labEquipmentList = new ArrayList();
            // populate settings from database
            initializeEquipmentList();
            initializeEquipmentSettings();
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