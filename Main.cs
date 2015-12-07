using System;
using ScanIP;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using itk.simple;

public static class Router
{
  public static void Main()
  {
    new SimpleUserAction("Home", "Tools", "Test", () => {
          App.GetInstance().ShowMessage("Do something");
        });
  }
}

