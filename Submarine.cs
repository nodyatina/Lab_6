using System;

    namespace Patterns{
        public class Submarine
{
    private ISubmarineState _state;

    public Submarine()
    {
        _state = new SurfaceState();  
    }

    public void SetState(ISubmarineState state)
    {
        _state = state;
    }

    public int GetSpeed()
    {
        return _state.GetSpeed();
    }
}
}