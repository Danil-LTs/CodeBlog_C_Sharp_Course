﻿using System;

namespace delegate_events
{
    public class Person
    {
        public event Action GoToSleep;
        public event EventHandler DoWork;
        public string Name { get; set; }
        public void TakeTime(DateTime now)
        {
            if (now.Hour <= 8)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                var args = new EventArgs();
                DoWork?.Invoke(this, null);
            }
        }
    }
}
