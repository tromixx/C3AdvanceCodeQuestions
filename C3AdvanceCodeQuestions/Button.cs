//4 Delegate
public class Button
{
    // Define a delegate that represents the event signature
    public delegate void ClickEventHandler(object sender, EventArgs e);

    // Define the event using the delegate
    public event ClickEventHandler Click;

    // Method to raise the event
    protected virtual void OnClick(EventArgs e)
    {
        if (Click != null)
        {
            Click(this, e);
        }
    }

    // Method to simulate button click
    public void PerformClick()
    {
        OnClick(EventArgs.Empty);
    }
}