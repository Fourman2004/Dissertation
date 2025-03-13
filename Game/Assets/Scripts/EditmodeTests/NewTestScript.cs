using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    public static GameManager manager = new GameManager();
    public static int points = manager.Points;
    public bool CSVCreate = true;

    // A Test behaves as an ordinary method
    [Test]
    public void Point()
    {
        Assert.AreEqual(0, points, "Manager Points add up");
    }

    [Test]
    public void CSVSave()
    {
        Assert.AreNotEqual(CSVCreate, manager.Testbool, "CSV saves properly");
    }

}
