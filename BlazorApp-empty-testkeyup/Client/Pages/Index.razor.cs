using Microsoft.AspNetCore.Components.Web;

namespace BlazorAppemptytestkeyup.Client.Pages;
public partial class Index
{
   public List<string> Logs { get; set; } = new();
   public void KeyEvent(KeyboardEventArgs e)
   {
      Logs.Clear();
      Logs.Add(e.Key);
      Logs.Add(e.Code);
      Logs.Add(e.Type);
   }
}

