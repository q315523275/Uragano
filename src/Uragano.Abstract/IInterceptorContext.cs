﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Uragano.Abstractions
{
    public interface IInterceptorContext
    {
        string ServiceRoute { get; }

        Dictionary<string, string> Meta { get; }

        object[] Args { get; }

        IServiceProvider ServiceProvider { get; }

        MethodInfo MethodInfo { get; }

        Task<IServiceResult> Next();
    }
}
