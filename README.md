# How to apply custom fonts in Xamarin.Forms Chart(SfChart)?

You can set a custom font family to all the text elements in the chart. The following steps describe how to add a custom font file in the platform-specific projects.

**Android:** 

Add a custom font file in the **Assets** folder and set **Build Action** to **AndroidAsset** for the font file.

**iOS:** 

**Step1:** Add a custom font file in the **Resources** folder and set **Build Action** to **BundleResource**. Then, ensure that the copy to output directory is set to **AlwaysCopy**.

**Step2:** Add a custom font file name in the **info.plist** file as demonstrated in the following code sample.
```
<dict>……<key>UIAppFonts</key>
<array>
<string>Lobster-Regular.ttf</string>
……</dict>
```

**UWP:** 

Add a custom font file in the **Assets** folder and set **Build Action** to **Content**.

Please refer to the following code sample to set a custom font for chart legend labels.

**XAML**
```
<ResourceDictionary>
   <OnPlatform x:TypeArguments="x:String" x:Key="CustomFont">
      <On Platform="iOS" Value="Lobster-Regular" />
      <On Platform="Android" Value="Lobster-Regular.ttf#Lobster-Regular" />
      <On Platform="UWP" Value="Assets/Fonts/Lobster-Regular.ttf#Lobster" />
   </OnPlatform>
</ResourceDictionary>
 
<chart:SfChart.Legend>
   <chart:ChartLegend>
      <chart:ChartLegend.LabelStyle>
         <chart:ChartLegendLabelStyle FontFamily="{StaticResource CustomFont}" TextColor="Blue" FontSize="18"/>
      </chart:ChartLegend.LabelStyle>
   </chart:ChartLegend>
</chart:SfChart.Legend>
```

**C#**
```
chart.Legend = new ChartLegend();
chart.Legend.LabelStyle.TextColor = Color.Blue;
 
if (Device.RuntimePlatform == Device.Android)
{
    chart.Legend.LabelStyle.FontFamily = "Lobster-Regular.ttf#Lobster-Regular";
}
else if (Device.RuntimePlatform == Device.iOS)
{
    chart.Legend.LabelStyle.FontFamily = "Lobster-Regular";
}
else if (Device.RuntimePlatform == Device.UWP)
{
    chart.Legend.LabelStyle.FontFamily = "Assets/Fonts/Lobster-Regular.ttf#Lobster";
}
```

## Output:

![Chart legend with customized font in Xamarin.Forms](https://user-images.githubusercontent.com/53489303/200593758-a871cf3d-8b1a-4d27-a71b-690823264c9c.png)

KB article - [How to apply custom fonts in Xamarin.Forms Chart?](https://www.syncfusion.com/kb/9388/how-to-apply-custom-fonts-in-xamarin-forms-chart)

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
