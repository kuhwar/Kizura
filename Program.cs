namespace Kizura
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    static Mutex mutex = new Mutex(false, "kizura.kuhwar.net");

    [STAThread]
    static void Main()
    {
      if (!mutex.WaitOne(TimeSpan.Zero, true))
      {
        return;
      }
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      Application.Run(new KizuraApp());
      mutex.ReleaseMutex();
    }
  }
}