using UnityEngine;
using System.Collections;
using UnityEditor;

public class HotKeysScript
{

    // Add a new menu item with hotkey CTRL-SHIFT-A

    [MenuItem("Tools/New Option %#a")]
    private static void NewMenuOption()
    {
    }

    // Add a new menu item with hotkey CTRL-G

    [MenuItem("Tools/Item %g")]
    private static void NewNestedOption()
    {
    }

    // Add a new menu item with hotkey G
    [MenuItem("Tools/Item2 _g")]
    private static void NewOptionWithHotkey()
    {
    }
}
