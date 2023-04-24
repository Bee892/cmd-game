using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class MessageFactory : MonoBehaviour
{
    string directoryPath = "." + Path.DirectorySeparatorChar + "Assets" + Path.DirectorySeparatorChar + "Directories" + Path.DirectorySeparatorChar + "Messages";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Path.GetFullPath(directoryPath));
        //Message newMessage = ScriptableObject.CreateInstance<Message>();
        string newFileName = "Message1.asset";
        string finalPath = directoryPath + Path.DirectorySeparatorChar + newFileName;
        //AssetDatabase.CreateAsset(newMessage, finalPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
