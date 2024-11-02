using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms.VisualStyles;

namespace Kizura
{
  partial class PlayerForm
  {
    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      WebView = new WebView2();
      ((System.ComponentModel.ISupportInitialize)WebView).BeginInit();
      SuspendLayout();
      // 
      // WebView
      // 
      WebView.AllowExternalDrop = true;
      WebView.BackColor = Color.FromArgb(143, 110, 93);
      WebView.CreationProperties = null;
      WebView.DefaultBackgroundColor = Color.White;
      WebView.Dock = DockStyle.Fill;
      WebView.Location = new Point(0, 0);
      WebView.Name = "WebView";
      WebView.Size = new Size(400, 700);
      WebView.TabIndex = 0;
      WebView.ZoomFactor = 1D;
      WebView.KeyDown += ShowDeveloperTools;
      // 
      // PlayerForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(400, 700);
      Controls.Add(WebView);
      FormBorderStyle = FormBorderStyle.None;
      Icon = Properties.Resources.KizuraIcon;
      Name = "PlayerForm";
      Text = "Youtube Music";
      FormClosing += HideForm;
      KeyDown += ShowDeveloperTools;
      ((System.ComponentModel.ISupportInitialize)WebView).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
  }
}
