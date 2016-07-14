// Decompiled with JetBrains decompiler
// Type: WinHongKongFCArduino.Program
// Assembly: WinHongKongFCArduino, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B971882D-8EFF-4C0B-B44C-AC05B0411DA0
// Assembly location: C:\Users\ITO\Desktop\WinHongKongSRC\WinHongKongFCArduino\WinHongKongFCArduino.exe

using System;
using System.Windows.Forms;

namespace WinHongKongFCArduino
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new WinHongKongFCArduino());
    }
  }
}
