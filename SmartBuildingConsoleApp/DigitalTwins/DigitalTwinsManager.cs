using Azure.DigitalTwins.Core;
using Azure.Identity;
using System;
using System.IO;
namespace SmartBuildingConsoleApp.DigitalTwins
{ 
    public class DigitalTwinsManager 
    { 
        private static readonly string adtInstanceUrl = "<Azure Digital Twins Instance URL>"; 

        private DigitalTwinsClient client; 

        public DigitalTwinsManager() { Connect(); } 

        public void Connect() 
        { 
        
        } 
    } 
}