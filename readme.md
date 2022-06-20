This example shows how to display a list of objects in Canvas using data templates and ItemsSource.

If you want to implement this functionality, you should do the following:
1. Create `ItemsControl` with `ItemsSource={Binding YourListInViewModel}`
2. Replace ItemsControl's `ItemsPanel` property with `Canvas` object
3. Define data template for your list item
4. **Magic is here.** Please note that both WPF and Avalonia wrap your templated object with ContentPresenter.
   Now you need to set `Canvas.Top` and `Canvas.Left` of items presented with `ContentPresenter`, not for your templated items.
5. Create styles for `ContentPresenter` and set appropriate properties using `Binding` expressions.
