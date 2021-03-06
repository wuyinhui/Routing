// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.AspNet.Http;

namespace Microsoft.AspNet.Routing
{
    public class RouteContext
    {
        public RouteContext(HttpContext httpContext)
        {
            HttpContext = httpContext;

            RequestPath = httpContext.Request.Path.Value;
        }

        public HttpContext HttpContext { get; private set; }

        public bool IsHandled { get; set; }

        public string RequestPath { get; private set; }

        public IRouter Router { get; set; }

        public IDictionary<string, object> Values { get; set; }
    }
}
