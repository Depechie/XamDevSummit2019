using System;
using _2019_XamDevSummit.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Page), typeof(CustomPageRenderer))]
namespace _2019_XamDevSummit.iOS
{
    public class CustomPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
        }

        public override void DidMoveToParentViewController(UIViewController parent)
        {
            base.DidMoveToParentViewController(parent);
            //Avoid new iOS13 modal PageSheet style
            parent.ModalPresentationStyle = UIModalPresentationStyle.FullScreen;
        }
    }
}