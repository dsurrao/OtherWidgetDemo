# OtherWidgetDemo

A reusable Picker widget that allows a text entry option if "Other" is selected. The resulting selection can be bound to in the parent control like this:

```
<controls:OtherWidget x:Name="optionWidget1"/>
<Label BindingContext="{x:Reference optionWidget1}"
                   Text="{Binding SelectedOption}"/>
```
# OtherWidgetDemo

![Screenshot](https://github.com/dsurrao/OtherWidgetDemo/blob/main/demo_screenshot.png =100x)
