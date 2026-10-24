namespace FixFlow.Models
{
    public enum RepairStatus
    {
        Received = 0,
        Diagnosing = 1,
        WaitingForParts = 2,
        Repairing = 3,
        ReadyForPickup = 4,
        Released = 5
    }
}