using UnityEngine;
using System.Collections;
using UnityEditor;

public class RelatedClasses : MonoBehaviour
{
    //MenuCommand
    [MenuItem("CONTEXT/Rigidbody/New Option")]
    private static void NewMenuOption(MenuCommand menuCommand)
    {
        // The RigidBody component can be extracted from the menu command using the context field.
        var rigid = menuCommand.context as Rigidbody;
    }
    //ContextMenu
    //public string Name;

    [ContextMenu("Reset Name")]
    private static void ResetName()
    {
        //Name = string.Empty;
    }

    //ContextMenuItem
    [ContextMenuItem("Randomize Name", "Randomize")]
    public string Name;

    private void Randomize()
    {
        Name = "Some Random Name";
    }
}
