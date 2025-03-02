using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;

public class QuestionGenerator : MonoBehaviour
{
    public TextMeshProUGUI questionText;
    public string[] questions;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // questionText = GetComponent<Text>();
        Load();
        GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateQuestion() {
        int i = UnityEngine.Random.Range(0,5);
        Console.WriteLine(i);
        questionText.text = questions[i];
    }

    public void Load() {
        if (File.Exists(Path.Combine(Application.streamingAssetsPath, "/questions.txt"))) {
            questions = File.ReadAllLines(Application.dataPath + "/questions.txt");
            Debug.Log("done!!");

        }
    }
}
