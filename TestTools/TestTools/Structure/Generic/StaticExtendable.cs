﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TestTools.Helpers;

namespace TestTools.Structure.Generic
{
    public static class StaticExtendable
    {
        public static FieldStaticElement<TRoot, T> Field<TRoot, T>(IStaticExtendable<TRoot> instance, string fieldName, FieldOptions options)
        {
            FieldInfo fieldInfo = ReflectionHelper.GetFieldInfo(instance.Type, fieldName, typeof(T), options, isStatic: false);
            return new FieldStaticElement<TRoot, T>(fieldInfo) { PreviousElement = instance };
        }
        public static FieldStaticElement<TRoot, T> StaticField<TRoot, T>(this IStaticExtendable<TRoot> instance, string fieldName, FieldOptions options)
        {
            FieldInfo fieldInfo = ReflectionHelper.GetFieldInfo(typeof(TRoot), fieldName, typeof(T), options, isStatic: true);
            return new FieldStaticElement<TRoot, T>(fieldInfo) { PreviousElement = instance };
        }

        public static PropertyStaticElement<TRoot, T> Property<TRoot, T>(IStaticExtendable<TRoot> instance, string propertyName, AccessorOptions get, AccessorOptions set)
        {
            PropertyInfo propertyInfo = ReflectionHelper.GetPropertyInfo(typeof(TRoot), propertyName, typeof(T), get, set, isStatic: false);
            return new PropertyStaticElement<TRoot, T>(propertyInfo) { PreviousElement = instance };
        }
        public static PropertyStaticElement<TRoot, T> StaticProperty<TRoot, T>(IStaticExtendable<TRoot> instance, string propertyName, AccessorOptions get, AccessorOptions set)
        {
            PropertyInfo propertyInfo = ReflectionHelper.GetPropertyInfo(typeof(TRoot), propertyName, typeof(T), get, set, isStatic: true);
            return new PropertyStaticElement<TRoot, T>(propertyInfo) { PreviousElement = instance };
        }


        public static ActionMethodStaticElement<TRoot> ActionMethod<TRoot>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), options, isStatic: false);
            return new ActionMethodStaticElement<TRoot>(methodInfo) { PreviousElement = instance };
        }
        public static ActionMethodStaticElement<TRoot, T1> ActionMethod<TRoot, T1>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), new Type[] { typeof(T1) }, options, isStatic: false);
            return new ActionMethodStaticElement<TRoot, T1>(methodInfo) { PreviousElement = instance };
        }
        public static ActionMethodStaticElement<TRoot, T1, T2> ActionMethod<TRoot, T1, T2>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), new Type[] { typeof(T1), typeof(T2) }, options, isStatic: false);
            return new ActionMethodStaticElement<TRoot, T1, T2>(methodInfo) { PreviousElement = instance };
        }
        public static ActionMethodStaticElement<TRoot, T1, T2, T3> ActionMethod<TRoot, T1, T2, T3>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), new Type[] { typeof(T1), typeof(T2), typeof(T3) }, options, isStatic: false);
            return new ActionMethodStaticElement<TRoot, T1, T2, T3>(methodInfo) { PreviousElement = instance };
        }
        public static ActionMethodStaticElement<TRoot, T1, T2, T3, T4> ActionMethod<TRoot, T1, T2, T3, T4>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) }, options, isStatic: false);
            return new ActionMethodStaticElement<TRoot, T1, T2, T3, T4>(methodInfo) { PreviousElement = instance };
        }
        public static ActionMethodStaticElement<TRoot, T1, T2, T3, T4, T5> ActionMethod<TRoot, T1, T2, T3, T4, T5>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) }, options, isStatic: false);
            return new ActionMethodStaticElement<TRoot, T1, T2, T3, T4, T5>(methodInfo) { PreviousElement = instance };
        }

        public static FuncMethodStaticElement<TRoot, TResult> FuncMethod<TRoot, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), options, isStatic: false);
            return new FuncMethodStaticElement<TRoot, TResult>(methodInfo) { PreviousElement = instance };
        }
        public static FuncMethodStaticElement<TRoot, T1, TResult> FuncMethod<TRoot, T1, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), new Type[] { typeof(T1) }, options, isStatic: false);
            return new FuncMethodStaticElement<TRoot, T1, TResult>(methodInfo) { PreviousElement = instance };
        }
        public static FuncMethodStaticElement<TRoot, T1, T2, TResult> FuncMethod<TRoot, T1, T2, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), new Type[] { typeof(T1), typeof(T2) }, options, isStatic: false);
            return new FuncMethodStaticElement<TRoot, T1, T2, TResult>(methodInfo) { PreviousElement = instance };
        }
        public static FuncMethodStaticElement<TRoot, T1, T2, T3, TResult> FuncMethod<TRoot, T1, T2, T3, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), new Type[] { typeof(T1), typeof(T2), typeof(T3) }, options, isStatic: false);
            return new FuncMethodStaticElement<TRoot, T1, T2, T3, TResult>(methodInfo) { PreviousElement = instance };
        }
        public static FuncMethodStaticElement<TRoot, T1, T2, T3, T4, TResult> FuncMethod<TRoot, T1, T2, T3, T4, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) }, options, isStatic: false);
            return new FuncMethodStaticElement<TRoot, T1, T2, T3, T4, TResult>(methodInfo) { PreviousElement = instance };
        }
        public static FuncMethodStaticElement<TRoot, T1, T2, T3, T4, T5, TResult> FuncMethod<TRoot, T1, T2, T3, T4, T5, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) }, options, isStatic: false);
            return new FuncMethodStaticElement<TRoot, T1, T2, T3, T4, T5, TResult>(methodInfo) { PreviousElement = instance };
        }

        public static ActionMethodStaticElement<TRoot> StaticActionMethod<TRoot>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), options, isStatic: true);
            return new ActionMethodStaticElement<TRoot>(methodInfo) { PreviousElement = instance };
        }
        public static ActionMethodStaticElement<TRoot, T1> StaticActionMethod<TRoot, T1>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), new Type[] { typeof(T1) }, options, isStatic: true);
            return new ActionMethodStaticElement<TRoot, T1>(methodInfo) { PreviousElement = instance };
        }
        public static ActionMethodStaticElement<TRoot, T1, T2> StaticActionMethod<TRoot, T1, T2>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), new Type[] { typeof(T1), typeof(T2) }, options, isStatic: true);
            return new ActionMethodStaticElement<TRoot, T1, T2>(methodInfo) { PreviousElement = instance };
        }
        public static ActionMethodStaticElement<TRoot, T1, T2, T3> StaticActionMethod<TRoot, T1, T2, T3>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), new Type[] { typeof(T1), typeof(T2), typeof(T3) }, options, isStatic: true);
            return new ActionMethodStaticElement<TRoot, T1, T2, T3>(methodInfo) { PreviousElement = instance };
        }
        public static ActionMethodStaticElement<TRoot, T1, T2, T3, T4> StaticActionMethod<TRoot, T1, T2, T3, T4>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) }, options, isStatic: true);
            return new ActionMethodStaticElement<TRoot, T1, T2, T3, T4>(methodInfo) { PreviousElement = instance };
        }
        public static ActionMethodStaticElement<TRoot, T1, T2, T3, T4, T5> StaticActionMethod<TRoot, T1, T2, T3, T4, T5>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(void), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) }, options, isStatic: true);
            return new ActionMethodStaticElement<TRoot, T1, T2, T3, T4, T5>(methodInfo) { PreviousElement = instance };
        }

        public static FuncMethodStaticElement<TRoot, TResult> StaticFuncMethod<TRoot, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), options, isStatic: true);
            return new FuncMethodStaticElement<TRoot, TResult>(methodInfo) { PreviousElement = instance };
        }
        public static FuncMethodStaticElement<TRoot, T1, TResult> StaticFuncMethod<TRoot, T1, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), new Type[] { typeof(T1) }, options, isStatic: true);
            return new FuncMethodStaticElement<TRoot, T1, TResult>(methodInfo) { PreviousElement = instance };
        }
        public static FuncMethodStaticElement<TRoot, T1, T2, TResult> StaticFuncMethod<TRoot, T1, T2, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), new Type[] { typeof(T1), typeof(T2) }, options, isStatic: true);
            return new FuncMethodStaticElement<TRoot, T1, T2, TResult>(methodInfo) { PreviousElement = instance };
        }
        public static FuncMethodStaticElement<TRoot, T1, T2, T3, TResult> StaticFuncMethod<TRoot, T1, T2, T3, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), new Type[] { typeof(T1), typeof(T2), typeof(T3) }, options, isStatic: true);
            return new FuncMethodStaticElement<TRoot, T1, T2, T3, TResult>(methodInfo) { PreviousElement = instance };
        }
        public static FuncMethodStaticElement<TRoot, T1, T2, T3, T4, TResult> StaticFuncMethod<TRoot, T1, T2, T3, T4, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) }, options, isStatic: true);
            return new FuncMethodStaticElement<TRoot, T1, T2, T3, T4, TResult>(methodInfo) { PreviousElement = instance };
        }
        public static FuncMethodStaticElement<TRoot, T1, T2, T3, T4, T5, TResult> StaticFuncMethod<TRoot, T1, T2, T3, T4, T5, TResult>(IStaticExtendable<TRoot> instance, string methodName, MethodOptions options)
        {
            MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TRoot), methodName, typeof(TResult), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) }, options, isStatic: true);
            return new FuncMethodStaticElement<TRoot, T1, T2, T3, T4, T5, TResult>(methodInfo) { PreviousElement = instance };
        }
    }
}
