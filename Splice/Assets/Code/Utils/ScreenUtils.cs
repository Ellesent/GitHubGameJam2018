using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Util class for all screen related variables 
/// This class should only be instantiated ONCE. Singleton implementation should be added
/// </summary>
public class ScreenUtils: MonoBehaviour{
    // Property to get the height of the screen in game coordinates
    float ScreenheightCoord { get; set; }

    // Property to get the width of the screen in game coordinates
    public float ScreenWidthCoord { get; private set; }

    private void Awake()
    {
        // Don't destroy this object if a new scene is loaded
        DontDestroyOnLoad(gameObject);

        // Get the screen height/width in coordinates
        Vector2 screenCoord = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));

        ScreenWidthCoord = screenCoord.x;
        ScreenheightCoord = screenCoord.y;
    }

}
