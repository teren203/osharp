﻿// -----------------------------------------------------------------------
//  <copyright file="AppBuilderExtensions.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2015 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2015-09-29 23:06</last-date>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OSharp.Core;
using OSharp.Utility;

using Owin;


namespace OSharp.Web.SignalR.Initialize
{
    /// <summary>
    /// <see cref="IAppBuilder"/>初始化扩展
    /// </summary>
    public static class AppBuilderExtensions
    {
        /// <summary>
        /// 初始化SignalR框架
        /// </summary>
        public static IAppBuilder UseSignalRInitialize(this IAppBuilder app, SignalRInitializeOptions options)
        {
            options.CheckNotNull("options");
            IFrameworkInitializer initializer = new SignalRFrameworkInitializer(options);
            initializer.Initialize();
            return app;
        }
    }
}