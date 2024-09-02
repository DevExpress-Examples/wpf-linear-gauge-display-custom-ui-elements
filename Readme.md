<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128570694/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3537)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Linear Gauge - Display Custom UI Elements

This example displays **Up** and **Down** buttons within the linear scale. The **Up** button increases the scale value. The **Down** button decreases the scale value.

![WPF Linear Gauge - Display Custom UI Elements, DevExpress](https://raw.githubusercontent.com/DevExpress-Examples/how-to-use-custom-elements-in-the-linear-gauge-control-e3537/22.2.2%2B/i/wpf-linear-gauge-with-custom-ui-element-devexpress.png)

## Implementation Details

Create a [ScaleCustomElement](https://docs.devexpress.com/WPF/DevExpress.Xpf.Gauges.ScaleCustomElement) object with a custom UI element and add the object to the [Scale.CustomElements](https://docs.devexpress.com/WPF/DevExpress.Xpf.Gauges.Scale.CustomElements) collection to display custom content within a scale. This example creates two `ScaleCustomElement` objects with **Up** and **Down** buttons:

```xaml
<dxga:LinearScale >
    <dxga:LinearScale.CustomElements>
        <dxga:ScaleCustomElement VerticalAlignment="Top" HorizontalAlignment="Right">
            <Button Name="button1" Content="Up" Width="59"  Click="button1_Click" />
        </dxga:ScaleCustomElement>
        <dxga:ScaleCustomElement VerticalAlignment="Bottom" HorizontalAlignment="Right">
            <Button Name="button2" Content="Down" Width="59" Click="button2_Click" />
        </dxga:ScaleCustomElement>
    </dxga:LinearScale.CustomElements>
</dxga:LinearScale>
```

The `Click` event of each button is handled to allow users to change the scale value:

```csharp
private void button1_Click(object sender, RoutedEventArgs e) {
    if (bar.Value < 100)
        bar.Value += 10;
}
private void button2_Click(object sender, RoutedEventArgs e) {
    if (bar.Value > 0)
        bar.Value -= 10;
}
```

## Files to Review

* [MainWindow.xaml](./CS/LinearGauge_CustomElement/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/LinearGauge_CustomElement/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/LinearGauge_CustomElement/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/LinearGauge_CustomElement/MainWindow.xaml.vb))


## Documentation

* [Scale.CustomElements](https://docs.devexpress.com/WPF/DevExpress.Xpf.Gauges.Scale.CustomElements)
* [ScaleCustomElement](https://docs.devexpress.com/WPF/DevExpress.Xpf.Gauges.ScaleCustomElement)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-linear-gauge-display-custom-ui-elements&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-linear-gauge-display-custom-ui-elements&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
