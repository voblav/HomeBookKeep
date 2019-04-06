using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBookKeep
{
    public interface IPath
    {
        string GetDatabasePath(string filename);
    }
}
