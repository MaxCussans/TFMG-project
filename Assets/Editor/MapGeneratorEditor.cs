using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;

        //if any changes made
        if (DrawDefaultInspector())
        {
            //if auto update is true (ticked in inspector)
            if (mapGen.autoUpdate)
            {
                //update the map
                mapGen.GenerateMap();
            }
        }

        if(GUILayout.Button("Generate"))
        {
            mapGen.GenerateMap();
        }
    }
	
}
