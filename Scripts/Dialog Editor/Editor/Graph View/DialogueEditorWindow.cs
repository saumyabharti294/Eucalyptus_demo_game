using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.UIElements;
using UnityEngine.UI;

public class DialogueEditorWindow : EditorWindow
{
    private DialogueContainerSO currentDialogueContainer;
    private DialogueGraphView graphView;

    [OnOpenAsset(1)]
     public static bool ShowWindow(int _instanceId, int line)
    {
        UnityEngine.Object item = EditorUtility.InstanceIDToObject(_instanceId);

        if(item is DialogueContainerSO)
        {
            DialogueEditorWindow window = (DialogueEditorWindow)GetWindow(typeof(DialogueEditorWindow));
            window.titleContent = new GUIContent("Dialogue Editor");
            window.currentDialogueContainer = item as DialogueContainerSO;
            window.minSize = new Vector2(500, 250);
            window.Load();
        }
        return false;
    }
    private void OnEnable()
    {
        GenerateToolbar();
    }

    // Update is called once per frame
    private void OnDisable()
    {

    }

    private void ConstructGraphView()
    {

    }

    private void GenerateToolbar()
    {
        Toolbar toolbar = new Toolbar();

      
        
    }

    private void Load()
    {

    }

    private void Save()
    {
        Debug.Log("Load");
    }

    private void Language()
    {

    }
}
