﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToStart()
    {
        SceneManager.LoadScene("StartScreen"); // Load StartScene when button is pressed
    }

    public void ToInstruction()
    {
        SceneManager.LoadScene("InstructionScene"); // Load InstructionScene when the Instruction button is pressed
    }

    public void ToCredits()
    {
        SceneManager.LoadScene("CreditsScene"); // Load CreditsScene when the Credits button is pressed
    }
}
