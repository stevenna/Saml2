﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;

namespace Kentor.AuthServices
{
    interface ICommand
    {
        CommandResult Run(HttpRequestBase request);
    }
}
