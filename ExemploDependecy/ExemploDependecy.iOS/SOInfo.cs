using System; using Xamarin.Forms;

[assembly: Dependency(typeof(ExemploDependecy.iOS.SOInfo))] namespace ExemploDependecy.iOS {     public class SOInfo : ISOInfo     {  
        string ISOInfo.Dados => new UIKit.UIDevice().Model;     } }  