using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    /// <summary>
    ///  Directory of music files
    /// </summary>
    public string FileDirectory = "Assets/Sound/Music";

    /// <summary>
    /// Audio Source
    /// </summary>
    public AudioSource Source;
    
    /// <summary>
    ///  Current sound playing
    /// </summary>
    public AudioClip Clip;

    /// <summary>
    /// List all valid directory
    /// </summary>
    List<string> Files = new List<string>();
    
    /// <summary>
    /// List all audio clip
    /// </summary>
    List<AudioClip> Clips = new List<AudioClip>();
    
    
    // Start is called before the first frame update
    void Start()
    {
        Source = GetComponent<AudioSource>();
        
        //Grabs all files from FileDirectory
        string[] files;
        files = Directory.GetFiles(FileDirectory);
 
        //Checks all files and stores all WAV files into the Files list.
        for (int i = 0; i < files.Length; i++)
        {
            if (files[i].EndsWith(".wav"))
            {
                Files.Add(files[i]);
                Clips.Add(new WWW(files[i]).GetAudioClip(false, true, AudioType.WAV));
            }
        }
        //Calls the below method
        PlaySong(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PlaySong(int _listIndex)
    {
        Clip = Clips[_listIndex];
        Source.clip = Clip;
        Source.Play();
    }
}
