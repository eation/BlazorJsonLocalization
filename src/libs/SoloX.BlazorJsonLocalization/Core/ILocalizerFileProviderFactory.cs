﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.FileProviders;

namespace SoloX.BlazorJsonLocalization.Core
{
    public interface ILocalizerFileProviderFactory
    {
        IFileProvider GetFileProvider(Assembly assembly);
    }
}
