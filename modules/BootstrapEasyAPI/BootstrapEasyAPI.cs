/************************************************************************************
EasyAPI - Documentation: http://steamcommunity.com/sharedfiles/filedetails/?id=381043
*************************************************************************************/

public class Example : EasyAPI
{
    public Example(IMyGridTerminalSystem grid, IMyProgrammableBlock me, Action<string> echo, TimeSpan elapsedTime) : base(grid, me, echo, elapsedTime)
    {
        // Start your code here
    }
}


/*********************************************/ 
/*** Advanced users only beyond this point ***/ 
/*********************************************/ 

Example state;

void Main(string argument)
{
    if(state == null)
    {
        state = new Example(GridTerminalSystem, Me, Echo, ElapsedTime);
    }

    // Set the minimum time between ticks here to prevent lag.
    // To utilise onSingleTap and onDoubleTap, set the minimum time to the same
    // time period of the timer running this script (e.g. 1 * EasyAPI.Seconds).
    state.Tick(100 * EasyAPI.Milliseconds, argument);
}
