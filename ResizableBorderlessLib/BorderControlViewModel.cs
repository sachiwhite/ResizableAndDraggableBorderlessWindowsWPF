using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ResizableBorderlessLib
{
    public class BorderControlViewModel :ViewModelBase
    {
        public BorderControlViewModel()
        {
            DragWindowCommand=new RelayCommand(DragWindow);
            CloseWindowCommand=new RelayCommand(CloseWindow);
            MaximizeWindowCommand=new RelayCommand(MaximizeWindow);
            MinimizeWindowCommand=new RelayCommand(MinimizeWindow);
          
        }

        private void MaximizeWindow()
        {
            WindowState windowState = Application.Current.MainWindow.WindowState;
            if (windowState == WindowState.Normal)  
                Application.Current.MainWindow.WindowState=WindowState.Maximized;
            else Application.Current.MainWindow.WindowState=WindowState.Normal;

        }

        public ImageSource IconSource => Application.Current.MainWindow.Icon;
        private void DragWindow() => Application.Current.MainWindow.DragMove();
        public string BorderLabel => Application.Current.MainWindow.Title;
        public RelayCommand DragWindowCommand { get;}
        public RelayCommand CloseWindowCommand{get;}
        public RelayCommand MaximizeWindowCommand{get;}
        public RelayCommand MinimizeWindowCommand{get;}
        public void MinimizeWindow() => Application.Current.MainWindow.WindowState = WindowState.Minimized;
        public void CloseWindow() => Application.Current.MainWindow.Close();
    }
}
