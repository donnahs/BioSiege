using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitSelection : MonoBehaviour {

    public List<int> selectionLightAircraft;
    public List<int> selectionMediumAircraft;
    public List<int> selectionHeavyAircraft;

    public List<GameObject> lightAircraft;
    public List<GameObject> mediumAircraft;
    public List<GameObject> heavyAircraft;

    public List<Button> lightAircraftButton;
    public List<Button> mediumAircraftButton;
    public List<Button> heavyAircraftButton;

    public List<GameObject> lightAircraftSelectionBox;
    public List<GameObject> mediumAircraftSelectionBox;
    public List<GameObject> heavyAircraftSelectionBox;

    public List<GameObject>SelectedAircraft;


    public bool lightAircraftSelectOne;
    public bool lightAircraftSelectTwo;
    public bool lightAircraftSelectThree;
    public bool lightAircraftSelectFour;

    public bool mediumAircraftSelectOne;
    public bool mediumAircraftSelectTwo;
    public bool mediumAircraftSelectThree;
    public bool mediumAircraftSelectFour;

    public bool heavyAircraftSelectOne;
    public bool heavyAircraftSelectTwo;
    public bool heavyAircraftSelectThree;
    public bool heavyAircraftSelectFour;

    // Use this for initialization
    void Start ()
    {
        lightAircraftSelectOne = false;
        lightAircraftSelectTwo = false;
        lightAircraftSelectThree = false;
        lightAircraftSelectFour = false;

        mediumAircraftSelectOne = false;
        mediumAircraftSelectTwo = false;
        mediumAircraftSelectThree = false;
        mediumAircraftSelectFour = false;

        heavyAircraftSelectOne = false;
        heavyAircraftSelectTwo = false;
        heavyAircraftSelectThree = false;
        heavyAircraftSelectFour = false;

        lightAircraftButton[0].GetComponent<Button>().onClick.AddListener(LightAircraftSelectionOne);
        



        lightAircraftButton[1].GetComponent<Button>().onClick.AddListener(LightAircraftSelectionTwo);
       


        lightAircraftButton[2].GetComponent<Button>().onClick.AddListener(LightAircraftSelectionThree); 
        


        lightAircraftButton[3].GetComponent<Button>().onClick.AddListener(LightAircraftSelectionFour); 
        


        mediumAircraftButton[0].GetComponent<Button>().onClick.AddListener(MediumAircraftSelectionOne); 
        


        mediumAircraftButton[1].GetComponent<Button>().onClick.AddListener(MediumAircraftSelectionTwo); 
        


        mediumAircraftButton[2].GetComponent<Button>().onClick.AddListener(MediumAircraftSelectionThree);
        

        mediumAircraftButton[3].GetComponent<Button>().onClick.AddListener(MediumAircraftSelectionFour);
        


        heavyAircraftButton[0].GetComponent<Button>().onClick.AddListener(HeavyAircraftSelectionOne);

        heavyAircraftButton[1].GetComponent<Button>().onClick.AddListener(HeavyAircraftSelectionTwo);



        heavyAircraftButton[2].GetComponent<Button>().onClick.AddListener(HeavyAircraftSelectionThree);



        heavyAircraftButton[3].GetComponent<Button>().onClick.AddListener(HeavyAircraftSelectionFour);




        
     


        selectionLightAircraft[0] = 1;
        selectionLightAircraft[1] = 2;
        selectionLightAircraft[2] = 3;
        selectionLightAircraft[3] = 4;

        selectionMediumAircraft[0] = 5;
        selectionMediumAircraft[1] = 6;
        selectionMediumAircraft[2] = 7;
        selectionMediumAircraft[3] = 8;

        selectionHeavyAircraft[0] = 9;
        selectionHeavyAircraft[1] = 10;
        selectionHeavyAircraft[2] = 11;
        selectionHeavyAircraft[3] = 12;

        
       
        





    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void LightAircraftSelectionOne()
    {
        if (lightAircraftSelectOne == false)
        {
            lightAircraftSelectionBox[0].SetActive(true);
            SelectedAircraft.Add(lightAircraft[0]);
            Debug.Log("Click");
            lightAircraftSelectOne = true;
        }
        else
        {
            lightAircraftSelectionBox[0].SetActive(false);
            SelectedAircraft.Remove(lightAircraft[0]);
            Debug.Log("Click");
            lightAircraftSelectOne = false;
        }
        
    }

    



    void LightAircraftSelectionTwo()
    {
        lightAircraftSelectionBox[1].SetActive(true);
        SelectedAircraft.Add(lightAircraft[1]);
        Debug.Log("Click");

    }

    

    void LightAircraftSelectionThree()
    {
        lightAircraftSelectionBox[2].SetActive(true);
        SelectedAircraft.Add(lightAircraft[2]);
        Debug.Log("Click");
    }

    

    void LightAircraftSelectionFour()
    {
        lightAircraftSelectionBox[3].SetActive(true);
        SelectedAircraft.Add(lightAircraft[3]);
        Debug.Log("Click");
    }

    

    void MediumAircraftSelectionOne()
    {
        mediumAircraftSelectionBox[0].SetActive(true);
        SelectedAircraft.Add(mediumAircraft[0]);
        Debug.Log("Click");
    }

    

    void MediumAircraftSelectionTwo()
    {
        mediumAircraftSelectionBox[1].SetActive(true);
        SelectedAircraft.Add(mediumAircraft[1]);
        Debug.Log("Click");
    }

   

    void MediumAircraftSelectionThree()
    {
        mediumAircraftSelectionBox[2].SetActive(true);
        SelectedAircraft.Add(mediumAircraft[2]);
        Debug.Log("Click");
    }

   

    void MediumAircraftSelectionFour()
    {
        mediumAircraftSelectionBox[3].SetActive(true);
        SelectedAircraft.Add(mediumAircraft[3]);
        Debug.Log("Click");
    }

   

    void HeavyAircraftSelectionOne()
    {
        heavyAircraftSelectionBox[0].SetActive(true);
        SelectedAircraft.Add(heavyAircraft[0]);
        Debug.Log("Click");
    }

    

    void HeavyAircraftSelectionTwo()
    {
        heavyAircraftSelectionBox[1].SetActive(true);
        SelectedAircraft.Add(heavyAircraft[1]);
        Debug.Log("Click");
    }

   

    void HeavyAircraftSelectionThree()
    {
        heavyAircraftSelectionBox[2].SetActive(true);
        SelectedAircraft.Add(heavyAircraft[2]);
        Debug.Log("Click");
    }

   

    void HeavyAircraftSelectionFour()
    {
        heavyAircraftSelectionBox[3].SetActive(true);
        SelectedAircraft.Add(heavyAircraft[3]);
        Debug.Log("Click");
    }

   



}
