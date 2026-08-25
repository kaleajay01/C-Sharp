using System;
// 1. Create a delegate
delegate void DoorBellHandler();
class DoorBell
{
    // 2. Create an event using the delegate
    public event DoorBellHandler Ring;
    // 3. Method to ring the doorbell
    public void PressButton()
    {
        Console.WriteLine("Doorbell button pressed.");
        // 4. Raise the event
        Ring?.Invoke();
    }
}
class Program
{
    static void Main()
    {
        // 5. Create a DoorBell object
        DoorBell doorBell = new DoorBell();
        // 6. Subscribe a method to the event
        doorBell.Ring += OpenDoor;
        // 7. Press the doorbell
        doorBell.PressButton();
    }
    // 8. This method runs when the event happens
    static void OpenDoor()
    {
        Console.WriteLine("Someone opened the door.");
    }
}