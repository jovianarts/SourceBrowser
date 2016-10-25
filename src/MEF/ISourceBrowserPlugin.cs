﻿using System.Collections.Generic;

namespace MEF
{
    public interface ISourceBrowserPlugin
    {
        void Init(Dictionary<string, string> configuration, ILog logger);
        IEnumerable<ISymbolVisitor> ManufactureSymbolVisitors(string projectPath);
        IEnumerable<ITextVisitor> ManufactureTextVisitors(string projectPath);
    }
}
