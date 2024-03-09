using UnityEngine;
using System.Collections;
using UnityEditor;

public class MenuItemsExample : MonoBehaviour
{
    // Add a new menu item under an existing menu

    [MenuItem("Window/New Option")]
    private static void NewMenuOption()
    {
    }

    // Add a menu item with multiple levels of nesting

    [MenuItem("Tools/SubMenu/Option")]
    private static void NewNestedOption()
    {
    }
}
