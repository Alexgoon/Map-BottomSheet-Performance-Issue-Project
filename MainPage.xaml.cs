using Microsoft.Maui.Platform;

namespace MapAndBottmSheetExample {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void Pin_MarkerClicked(object sender, Microsoft.Maui.Controls.Maps.PinClickedEventArgs e) {
            var mauiContext = Content.Handler.MauiContext;
            var droidContext = mauiContext.Context;
            var myDialog = new MyDialog(droidContext);
            var dialogContent = new Label { Text = "Hello" + Environment.NewLine + "from" + Environment.NewLine + "Maui!", };
            dialogContent.Parent = this;
            myDialog.Content = dialogContent.ToPlatform(mauiContext);
            myDialog.ShowDialog();
        }
    }
}