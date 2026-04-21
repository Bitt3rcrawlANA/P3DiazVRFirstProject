using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel.DataAnnotation
using System.Linq;
using TMPro;

public class SubtitleController : MonoBehaviour
{

    [SerializeField, Required]private TextAsset subtitlesTextFile;
    [SerializeField, Required] private string voiceLinesFolderPath;
    [SerializeField] private Subtitle[] subtitles;
    [SerializeField] private int currentSubtitleIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public class Subtitle
{
    public int line;
    public string text;
    public float duration;
}