// Events

// A mechanism for communication between objects
// Used in building Loosely Coupled Applications
// Helps extending applications

// Below Example demonstrates an Button Click Event

// Publisher, subscriber pattern
// ClickHandler : Publisher of event


// Without passing any event data
internal class ClickHandler
{

    // 1. Define a delegate
    // 2. Define an event based on above delegate
    // 3. Raise the event

    public delegate void KeyPressedHandler(object obj, EventArgs args);
    public event KeyPressedHandler? KeyPressed;

    public void KeyboardEvent()
    {
        System.Console.WriteLine("Keyboard keys are ready to be pressed..!");
        Thread.Sleep(3000);

        OnKeyPressed();
    }

    // Convention for Event Handler
    // 1. Should be protected virtual void
    // 2. Naming Prefix "On"
    protected virtual void OnKeyPressed()
    {
        // If there are any notifications (functions attached to delegate) then Invoke the delegate;
        KeyPressed?.Invoke(this, EventArgs.Empty);
    }

}

// With passing event data

public class SomeData : EventArgs
{
    // some props;
}
internal class ClickHandler
{

    // 1. Define a delegate
    // 2. Define an event based on above delegate
    // 3. Raise the event

    public delegate void KeyPressedHandler(object obj, SomeData args);
    public event KeyPressedHandler? KeyPressed;

    // Modern approach to create Event delegates

    // 1. Without passing event data
    // public event EventHandler KeyPressed;

    // 2. For passing event data
    // public event EventHandler<T> KeyPressed;

    public void KeyboardEvent(SomeData data)
    {
        System.Console.WriteLine("Keyboard keys are ready to be pressed..!");
        Thread.Sleep(3000);

        OnKeyPressed(data);
    }

    // Convention for Event Handler
    // 1. Should be protected virtual void
    // 2. Naming Prefix "On"
    protected virtual void OnKeyPressed(SomeData data)
    {
        // If there are any notifications (functions attached to delegate) then Invoke the delegate;
        KeyPressed?.Invoke(this, data);
    }

}


// Creating Subscribers

public class EnterKey
{
    public virtual void OnKeyPressed(object obj, SomeData data)
    {
        System.Console.WriteLine("Enter was pressed.." + data);
    }
}

public class SpaceKey
{
    public virtual void OnKeyPressed(object obj, SomeData data)
    {
        System.Console.WriteLine("Space was pressed.." + data);
    }
}


class Program
{
    static void Main()
    {
        var keyPress = new ClickHandler();

        // Regestring the fn() in delegate
        keyPress.KeyPressed += EnterKey.OnKeyPressed;
        keyPress.KeyPressed += SpaceKey.OnKeyPressed;

        keyPress.KeyboardEvent();
    }
}

