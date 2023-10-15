// Created on 2023-09-23 by Manavjot Singh

namespace GameOfLife;


class IntervalTimer 
{
    TimeSpan _interval;
    DateTimeOffset _lastInterval;

    public IntervalTimer(TimeSpan interval) 
    {
        _interval = interval;
        _lastInterval = DateTimeOffset.Now;
    }

    public void Wait()
    {
        var elapsed = DateTimeOffset.Now - _lastInterval;
        if (elapsed < _interval) Thread.Sleep(_interval - elapsed);
        _lastInterval = DateTimeOffset.Now;
    }
}   