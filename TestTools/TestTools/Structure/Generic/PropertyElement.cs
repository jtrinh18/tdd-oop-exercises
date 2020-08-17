﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TestTools.Helpers;

namespace TestTools.Structure.Generic
{
    public class PropertyElement<TRoot, TValue> : PropertyElement, IAccessible<TRoot, TValue>, IExtendable<TRoot>
    {
        public PropertyElement(PropertyInfo propertyInfo) : base(propertyInfo)
        {
        }

        public TValue Get(TRoot instance)
        {
            return (TValue)base.Get(instance);
        }

        public void Set(TRoot instance, TValue value)
        {
            base.Set(instance, value);
        }


        public FieldElement<TRoot, T> Field<T>(string fieldName, FieldOptions options = null) => Extendable.Field<TRoot, T>(this, fieldName, options);
        public FieldStaticElement<TRoot, T> StaticField<T>(string fieldName, FieldOptions options = null) => Extendable.StaticField<TRoot, T>(this, fieldName, options);

        public PropertyElement<TRoot, T> Property<T>(string propertyName, AccessorOptions get = null, AccessorOptions set = null) => Extendable.Property<TRoot, T>(this, propertyName, get, set);
        public PropertyStaticElement<TRoot, T> StaticProperty<T>(string propertyName, AccessorOptions get = null, AccessorOptions set = null) => Extendable.StaticProperty<TRoot, T>(this, propertyName, get, set);

        public ActionMethodElement<TRoot> ActionMethod(string methodName, MethodOptions options = null) => Extendable.ActionMethod<TRoot>(this, methodName, options);
        public ActionMethodElement<TRoot, T1> ActionMethod<T1>(string methodName, MethodOptions options = null) => Extendable.ActionMethod<TRoot, T1>(this, methodName, options);
        public ActionMethodElement<TRoot, T1, T2> ActionMethod<T1, T2>(string methodName, MethodOptions options = null) => Extendable.ActionMethod<TRoot, T1, T2>(this, methodName, options);
        public ActionMethodElement<TRoot, T1, T2, T3> ActionMethod<T1, T2, T3>(string methodName, MethodOptions options = null) => Extendable.ActionMethod<TRoot, T1, T2, T3>(this, methodName, options);
        public ActionMethodElement<TRoot, T1, T2, T3, T4> ActionMethod<T1, T2, T3, T4>(string methodName, MethodOptions options = null) => Extendable.ActionMethod<TRoot, T1, T2, T3, T4>(this, methodName, options);
        public ActionMethodElement<TRoot, T1, T2, T3, T4, T5> ActionMethod<T1, T2, T3, T4, T5>(string methodName, MethodOptions options = null) => Extendable.ActionMethod<TRoot, T1, T2, T3, T4, T5>(this, methodName, options);

        public FuncMethodElement<TRoot, TResult> FuncMethod<TResult>(string methodName, MethodOptions options = null) => Extendable.FuncMethod<TRoot, TResult>(this, methodName, options);
        public FuncMethodElement<TRoot, T1, TResult> FuncMethod<T1, TResult>(string methodName, MethodOptions options = null) => Extendable.FuncMethod<TRoot, T1, TResult>(this, methodName, options);
        public FuncMethodElement<TRoot, T1, T2, TResult> FuncMethod<T1, T2, TResult>(string methodName, MethodOptions options = null) => Extendable.FuncMethod<TRoot, T1, T2, TResult>(this, methodName, options);
        public FuncMethodElement<TRoot, T1, T2, T3, TResult> FuncMethod<T1, T2, T3, TResult>(string methodName, MethodOptions options = null) => Extendable.FuncMethod<TRoot, T1, T2, T3, TResult>(this, methodName, options);
        public FuncMethodElement<TRoot, T1, T2, T3, T4, TResult> FuncMethod<T1, T2, T3, T4, TResult>(string methodName, MethodOptions options = null) => Extendable.FuncMethod<TRoot, T1, T2, T3, T4, TResult>(this, methodName, options);
        public FuncMethodElement<TRoot, T1, T2, T3, T4, T5, TResult> FuncMethod<T1, T2, T3, T4, T5, TResult>(string methodName, MethodOptions options = null) => Extendable.FuncMethod<TRoot, T1, T2, T3, T4, T5, TResult>(this, methodName, options);

        public ActionMethodStaticElement<TRoot> StaticActionMethod(string methodName, MethodOptions options = null) => Extendable.StaticActionMethod<TRoot>(this, methodName, options);
        public ActionMethodStaticElement<TRoot, T1> StaticActionMethod<T1>(string methodName, MethodOptions options = null) => Extendable.StaticActionMethod<TRoot, T1>(this, methodName, options);
        public ActionMethodStaticElement<TRoot, T1, T2> StaticActionMethod<T1, T2>(string methodName, MethodOptions options = null) => Extendable.StaticActionMethod<TRoot, T1, T2>(this, methodName, options);
        public ActionMethodStaticElement<TRoot, T1, T2, T3> StaticActionMethod<T1, T2, T3>(string methodName, MethodOptions options = null) => Extendable.StaticActionMethod<TRoot, T1, T2, T3>(this, methodName, options);
        public ActionMethodStaticElement<TRoot, T1, T2, T3, T4> StaticActionMethod<T1, T2, T3, T4>(string methodName, MethodOptions options = null) => Extendable.StaticActionMethod<TRoot, T1, T2, T3, T4>(this, methodName, options);
        public ActionMethodStaticElement<TRoot, T1, T2, T3, T4, T5> StaticActionMethod<T1, T2, T3, T4, T5>(string methodName, MethodOptions options = null) => Extendable.StaticActionMethod<TRoot, T1, T2, T3, T4, T5>(this, methodName, options);

        public FuncMethodStaticElement<TRoot, TResult> StaticFuncMethod<TResult>(string methodName, MethodOptions options = null) => Extendable.StaticFuncMethod<TRoot, TResult>(this, methodName, options);
        public FuncMethodStaticElement<TRoot, T1, TResult> StaticFuncMethod<T1, TResult>(string methodName, MethodOptions options = null) => Extendable.StaticFuncMethod<TRoot, T1, TResult>(this, methodName, options);
        public FuncMethodStaticElement<TRoot, T1, T2, TResult> StaticFuncMethod<T1, T2, TResult>(string methodName, MethodOptions options = null) => Extendable.StaticFuncMethod<TRoot, T1, T2, TResult>(this, methodName, options);
        public FuncMethodStaticElement<TRoot, T1, T2, T3, TResult> StaticFuncMethod<T1, T2, T3, TResult>(string methodName, MethodOptions options = null) => Extendable.StaticFuncMethod<TRoot, T1, T2, T3, TResult>(this, methodName, options);
        public FuncMethodStaticElement<TRoot, T1, T2, T3, T4, TResult> StaticFuncMethod<T1, T2, T3, T4, TResult>(string methodName, MethodOptions options = null) => Extendable.StaticFuncMethod<TRoot, T1, T2, T3, T4, TResult>(this, methodName, options);
        public FuncMethodStaticElement<TRoot, T1, T2, T3, T4, T5, TResult> StaticFuncMethod<T1, T2, T3, T4, T5, TResult>(string methodName, MethodOptions options = null) => Extendable.StaticFuncMethod<TRoot, T1, T2, T3, T4, T5, TResult>(this, methodName, options);

    }
}
