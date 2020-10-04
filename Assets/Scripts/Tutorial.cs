using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject Movement;
    public GameObject Attack;
    private bool hasMoved = false;
    private bool hasAttacked = false;
    private bool TutorialComplete = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!TutorialComplete)
        {
            if ((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.UpArrow)) || (Input.GetKeyDown(KeyCode.DownArrow)) || (Input.GetKeyDown(KeyCode.LeftArrow)) || (Input.GetKeyDown(KeyCode.RightArrow)))
            {
                hasMoved = true;
            }

            if (hasMoved)
            {
                Movement.SetActive(false);
                Attack.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.Mouse0) && (hasMoved))
            {
                hasAttacked = true;
            }

            if (hasAttacked)
            {
                Attack.SetActive(false);
                TutorialComplete = true;
            }
        }        
    }
}
