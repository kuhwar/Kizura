using Microsoft.Web.WebView2.Core;

namespace Kizura
{
  public partial class PlayerForm : Form
  {
    public PlayerForm()
    {

      Location = new Point(Screen.GetWorkingArea(this).Width - 400, Screen.GetWorkingArea(this).Height - 700);
      InitializeComponent();
      InitializeComponentAsync();
    }

    private async Task InitializeComponentAsync()
    {
      string _cacheFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName);
      var webView2Environment = await CoreWebView2Environment.CreateAsync(null, _cacheFolderPath);
      await WebView.EnsureCoreWebView2Async(webView2Environment);
      WebView.Source = new Uri("https://music.youtube.com", UriKind.Absolute);

    }

    private void ShowDeveloperTools(object? sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.F12: { WebView.CoreWebView2.OpenDevToolsWindow(); break; }
        case Keys.Escape: { Hide(); break; }
        default: break;
      };


    }

    void HideForm(object? sender, FormClosingEventArgs e)
    {
      Visible = false;
      if (e.CloseReason == CloseReason.UserClosing)
      {
        e.Cancel = true;
      }
    }
  }
}
