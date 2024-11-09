using System;
using System.ComponentModel;
using System.Windows.Forms;
namespace Kizura
{
  public class KizuraApp : ApplicationContext
  {
    private NotifyIcon trayIcon;
    private ContextMenuStrip contextMenu;
    private ToolStripMenuItem exitMenuItem;
    private PlayerForm playerForm;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

    public KizuraApp()
    {
      exitMenuItem = new ToolStripMenuItem();
      exitMenuItem.Text = "&Exit";
      exitMenuItem.Click += Exit;

      contextMenu = new ContextMenuStrip(new Container());
      contextMenu.Items.Add(exitMenuItem);

      trayIcon = new NotifyIcon();
      trayIcon.Text = "Show/Hide Player";
      trayIcon.Icon = Properties.Resources.KizuraIcon;
      trayIcon.DoubleClick += ShowHidePlayer;
      trayIcon.ContextMenuStrip = contextMenu;
      trayIcon.Visible = true;
      playerForm = new PlayerForm();
    }


    void ShowHidePlayer(object? sender, EventArgs e)
    {
      if (playerForm.Visible) { playerForm.Hide(); } else { playerForm.Show(); playerForm.Focus(); playerForm.TopMost = true; }
    }
    void Exit(object? sender, EventArgs e)
    {
      trayIcon.Visible = false;
      Application.Exit();
    }
  }
}
