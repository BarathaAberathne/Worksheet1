using System;
namespace TrueMarbleGUI
{
    public partial class WindowImgLoader : Gtk.Window
    {
        public WindowImgLoader() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
