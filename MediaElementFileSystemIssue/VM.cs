using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MediaElementFileSystemIssue
{

    
    public partial class VM:ObservableObject
    {
        public VM()
        {
           

        }

        [ObservableProperty]        
        private string _capturedVideo;

        partial void OnCapturedVideoChanged(string value)
        {
            
        }


        [RelayCommand()]
        private void LoadVideo()
        {
            //REPLACE THE FILE PATH WHERE YOUR VIDEO IS BELOW

            //I have tried the following but they all throw errors, see MediaFailed event handler:            
            //CapturedVideo = "filesystem://C:\\Users\\User-Pc\\Videos\\yourvideonamehere.mp4";
            //CapturedVideo = @"filesystem://C:\Users\User-Pc\Videos\yourvideonamehere.mp4";
            //CapturedVideo = "filesystem://C://Users//User-Pc//Videos//yourvideonamehere.mp4";

        }




    }
}
