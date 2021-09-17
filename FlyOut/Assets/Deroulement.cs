using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deroulement : MonoBehaviour
{
    public TypeWriterEffect text;

    public GameManager gM;

    private float timer;

    public GameObject phase1;
    public GameObject phase2;
    public GameObject phase3;
    public GameObject phase4;
    public GameObject phase5;

    private bool bool1 = false;
    private bool bool2 = false;
    private bool bool3 = false;
    private bool bool4 = false;
    private bool bool5 = false;
    private bool bool6 = false;
    private bool bool7 = false;
    private bool bool8 = false;
    private bool bool9 = false;
    private bool bool10 = false;
    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        
        if(timer <= 13 && timer >= 12 && bool1 == false)
        {
            text.UpdateText("Do I really feel like myself ? ");
            bool1 = true;
        }

        if(timer <= 24 && timer >= 23 && bool2 == false)
        {
            text.UpdateText("What if my body wasn't really... me ? ");
            bool2 = true;
        }

        // PHASE 2
        if(timer <= 35 && timer >= 34 && bool3 == false)
        {
            text.UpdateText("Will they hate me ? ");
            phase1.SetActive(false);
            phase2.SetActive(true);
            bool3 = true;
        }

        if(timer <= 44 && timer >= 43 && bool4 == false)
        {
            text.UpdateText("What if I'm wrong ? What if in the end I just... Regret ? ");
            bool4 = true;
        }

        if(timer <= 58 && timer >= 57 && bool5 == false)
        {
            text.UpdateText("Have I the right to feel that way ? ");
            bool5 = true;
        }

        // PHASE 3
        if(timer <= 70 && timer >= 69 && bool6 == false)
        {
            text.UpdateText("Okay. It's gorgeous. I want to wear that. Fuck everything. ");
            phase2.SetActive(false);
            phase3.SetActive(true);
            bool6 = true;
        }

        if(timer <= 82 && timer >= 81 && bool7 == false)
        {
            text.UpdateText("Come to think of it... It would actually make much more sense than what I live right now. ");
            bool7 = true;
        }

        // PHASE 4
        if(timer <= 100 && timer >= 99 && bool8 == false)
        {
            text.UpdateText("I could never go to my school... Dressed like that. ");
            phase3.SetActive(false);
            phase4.SetActive(true);
            bool8 = true;
        }

        if(timer <= 112 && timer >= 111 && bool9 == false)
        {
            text.UpdateText("I finally feel like myself. ");
            phase4.SetActive(false);
            phase5.SetActive(true);
            bool9 = true;
        }
        if(timer <= 130 && timer >= 129 && bool10 == false)
        {
            // text.UpdateText("I finally feel like myself. ");
            gM.MainMenu();
            bool10 = true;
        }
    }
}
