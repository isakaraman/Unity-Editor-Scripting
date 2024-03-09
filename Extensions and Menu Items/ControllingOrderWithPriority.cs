using UnityEngine;
using System.Collections;
using UnityEditor;

public class ControllingOrderWithPriority : MonoBehaviour
{
    [MenuItem("NewMenu/Option1", false, 1)]
    private static void NewMenuOption()
    {
    }

    [MenuItem("NewMenu/Option2", false, 2)]
    private static void NewMenuOption2()
    {
    }

    [MenuItem("NewMenu/Option3", false, 3)]
    private static void NewMenuOption3()
    {
    }

    [MenuItem("NewMenu/Option4", false, 51)]
    private static void NewMenuOption4()
    {
    }

    [MenuItem("NewMenu/Option5", false, 52)]
    private static void NewMenuOption5()
    {
    }
}
