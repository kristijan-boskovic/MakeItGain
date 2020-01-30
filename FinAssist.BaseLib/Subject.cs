﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinAssist.BaseLib
{
    public abstract class Subject
    {
        static List<IObserver> _listObservers = new List<IObserver>();

        public void Attach(IObserver obs)
        {
            _listObservers.Add(obs);
        }
        public void Delete(IObserver obs)
        {
            _listObservers.Remove(obs);
        }
        public void NotifyObservers()
        {
            foreach(IObserver obs in _listObservers)
                obs.UpdateObserved();
        }
    }
}
