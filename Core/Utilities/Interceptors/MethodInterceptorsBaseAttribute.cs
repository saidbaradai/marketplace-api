﻿
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{

    [AttributeUsage(AttributeTargets.Method| AttributeTargets.Class,AllowMultiple =true, Inherited =true)]
    public class MethodInterceptorsBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }
        public virtual void Intercept(IInvocation invocation)
        {
            
        }
    }
}
