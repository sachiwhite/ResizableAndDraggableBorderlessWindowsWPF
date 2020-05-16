# ResizableAndDraggableBorderlessWindowsWPF
This is a wrapper to simplify creating borderless windows in WPF.

## How to use?
* Download the repository

* Add ResizableBorderlessLib project to your solution:
Right click on your solution, then click Add->Existing Project. Move to the directory, where you downloaded repository and choose the ResizableBorderlessLib.csproj file. 

* Add reference to ResizableBorderlessLib project in your desired project
Right click on your main project, then right click on References and Add reference. Choose the ResizableBorderlessLib.

* Add namespace in your MainWindow file
```xaml
xmlns:resizable="clr-namespace:ResizableBorderlessLib;assembly=ResizableBorderlessLib"
```

* Specify RowDefinition to put border in a proper place
```xaml
<Grid.RowDefinitions>
           <RowDefinition Height="30"></RowDefinition>
           <RowDefinition></RowDefinition>
           <!--more rows if you need...-->
</Grid.RowDefinitions>
```

* Add border to the desired row
```xaml
<resizable:BorderControl Grid.Row="0"></resizable:BorderControl>
```

## Made with
* .NET Framework 4.6
* [MVVM Light Toolkit](https://github.com/lbugnion/mvvmlight)

