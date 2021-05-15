﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface IDatabase
    {
        void connect();
        void disconnect();

        void insert(String data);

    }
}
