namespace XamlSamples
{
    public partial class XamlPlusCodePage
    {
        public XamlPlusCodePage()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, 
                                  ValueChangedEventArgs args)
        {
            valueLabel.Text = args.NewValue.ToString("F3");
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Clicked!",
                "The button labeled '" + ((Button)sender).Text + "' has been clicked",
                "OK");
        }
    }
}
