using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class jsonscript : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    private string filePath;

    void Start()
    {
        filePath = Application.dataPath + "/jason.json";
    }

    public void LoadTextFromJson()
    {
        if (File.Exists(filePath))
        {
            string jsonContent = File.ReadAllText(filePath);
            Data data = JsonUtility.FromJson<Data>(jsonContent);
            textMeshPro.text = data.text;
        }
    }

    public class Data
    {
        public string text;
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}
