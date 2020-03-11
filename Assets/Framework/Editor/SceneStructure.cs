using System.Collections.Generic;

using UnityEditor;
using UnityEditor.SceneManagement;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


[InitializeOnLoad]
public static class SceneStructure
{

    private static string setupFolder = "[SETUP]";
    private static string worldFolder = "[WORLD]";
    private static string uiFolder = "[UI]";
    private static string poolFolder = "[POOL]";
    private static string eventFolder = "[EVENT]";
    
    
    
    private static Dictionary<string, GameObject> folderStructure = new Dictionary<string, GameObject>(10);

    static SceneStructure()
    {
        EditorSceneManager.newSceneCreated += CreateScene;

    }

    public static void CreateScene(Scene scene, NewSceneSetup setup, NewSceneMode mode)
    {

        CreateFolderStructure();

        var _camera = GameObject.Find("Main Camera");
        if(_camera)
            _camera.transform.parent = GetFolder("Cameras").transform;
        
        var _light = GameObject.Find("Directional Light");
        if(_light)
            _light.transform.parent = GetFolder("Light").transform;


        Debug.Log("New scene has been created!");

    }

    private static void CreateFolderStructure()
    {
        var _main = CreateFolder(setupFolder);
        CreateFolder("Light", _main.transform);
        CreateFolder("Cameras", _main.transform);

        var _world = CreateFolder(worldFolder);
        CreateFolder("Static", _world.transform);
        CreateFolder("Dynamic", _world.transform);
        
        var _ui =  CreateFolder(uiFolder);
        var _canvas = CreateFolder("Canvas", _ui.transform);
        _canvas.AddComponent<Canvas>();
        _canvas.AddComponent<CanvasScaler>();

        CreateFolder(poolFolder);


        var _event = CreateFolder(eventFolder);
        var _eventSystem = CreateFolder("EventSystem", _event.transform);
        _eventSystem.AddComponent<EventSystem>();
    }

    private static GameObject CreateFolder(string name, Transform parent = null)
    {
        var _obj = new GameObject(name);
        if(parent)
        {
            _obj.transform.parent = parent;
        }
            
        folderStructure.Add(name, _obj);
        return _obj;
    }

    private static GameObject GetFolder(string name)
    {
        GameObject _obj;
        folderStructure.TryGetValue(name, out _obj);

        return _obj;

    }


}
