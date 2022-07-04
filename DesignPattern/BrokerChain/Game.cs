﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BrokerChain
{
    public class Game
    {
        public event EventHandler<Query> Queries;

        public void PerformQuery(object sender, Query query)
        {
            Queries?.Invoke(sender, query);
        }
    }
}
