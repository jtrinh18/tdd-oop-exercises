﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TestTools.Helpers;

namespace TestTools.Structure.Generic
{
    public class FieldDefinition<TClass, T> : FieldDefinition, IAccessible<TClass, T>, IMemberable<TClass>
    {
        public FieldDefinition(FieldInfo fieldInfo) : base(fieldInfo)
        {
        }

        public T Get(TClass instance)
        {
            return (T)base.Get(instance);
        }

        public void Set(TClass instance, T value)
        {
            base.Set(instance, value);
        }

        public FieldDefinition<TClass, T> Field<T>(string fieldName, AccessLevel? accessLevel = null)
        {
            FieldInfo fieldInfo = StructureHelper.GetFieldInfo(Info.FieldType, fieldName, typeof(T), accessLevel, isStatic: false);
            return new FieldDefinition<TClass, T>(fieldInfo) { PreviousDefinition = this };
        }

        public StaticFieldDefinition<T> StaticField<T>(string fieldName, AccessLevel? accessLevel = null)
        {
            FieldInfo fieldInfo = StructureHelper.GetFieldInfo(Info.FieldType, fieldName, typeof(T), accessLevel, isStatic: true);
            return new StaticFieldDefinition<T>(fieldInfo) { PreviousDefinition = this };
        }


        public PropertyDefinition<TClass, T> Property<T>(string propertyName, PropertyAccessor get = null, PropertyAccessor set = null)
        {
            PropertyInfo propertyInfo = StructureHelper.GetPropertyInfo(Info.FieldType, propertyName, typeof(T), get, set, isStatic: false);
            return new PropertyDefinition<TClass, T>(propertyInfo) { PreviousDefinition = this };
        }
        public StaticPropertyDefinition<T> StaticProperty<T>(string propertyName, PropertyAccessor get = null, PropertyAccessor set = null)
        {
            PropertyInfo propertyInfo = StructureHelper.GetPropertyInfo(Info.FieldType, propertyName, typeof(T), get, set, isStatic: true);
            return new StaticPropertyDefinition<T>(propertyInfo) { PreviousDefinition = this };
        }

        public IAccessible<TClass, T> FieldOrProperty<T>(string memberName, AccessLevel? accessLevel = null)
        {
            MemberInfo memberInfo = StructureHelper.GetFieldOrPropertyInfo(Info.FieldType, memberName, typeof(T), accessLevel, isStatic: false);

            if (memberInfo is FieldInfo fieldInfo)
                return new FieldDefinition<TClass, T>(fieldInfo) { PreviousDefinition = this };
            else if (memberInfo is PropertyInfo propertyInfo)
                return new PropertyDefinition<TClass, T>(propertyInfo) { PreviousDefinition = this };
            else throw new ArgumentException("INTERNAL: member is not field or property");
        }
        public IStaticAccessible<T> StaticFieldOrProperty<T>(string memberName, AccessLevel? accessLevel = null)
        {
            MemberInfo memberInfo = StructureHelper.GetFieldOrPropertyInfo(Info.FieldType, memberName, typeof(T), accessLevel, isStatic: true);

            if (memberInfo is FieldInfo fieldInfo)
                return new StaticFieldDefinition<T>(fieldInfo);
            else if (memberInfo is PropertyInfo propertyInfo)
                return new StaticPropertyDefinition<T>(propertyInfo);
            else throw new ArgumentException("INTERNAL: member is not field or property");
        }

        public MethodDefinition<TClass, TReturn> Method<TReturn>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), accessLevel, isStatic: false);
            return new MethodDefinition<TClass, TReturn>(methodInfo) { PreviousDefinition = this };
        }
        public MethodDefinition<TClass, TReturn, T1> Method<TReturn, T1>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), new Type[] { typeof(T1) }, accessLevel, isStatic: false);
            return new MethodDefinition<TClass, TReturn, T1>(methodInfo) { PreviousDefinition = this };
        }
        public MethodDefinition<TClass, TReturn, T1, T2> Method<TReturn, T1, T2>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), new Type[] { typeof(T1), typeof(T2) }, accessLevel, isStatic: false);
            return new MethodDefinition<TClass, TReturn, T1, T2>(methodInfo) { PreviousDefinition = (Definition)this };
        }
        public MethodDefinition<TClass, TReturn, T1, T2, T3> Method<TReturn, T1, T2, T3>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), new Type[] { typeof(T1), typeof(T2), typeof(T3) }, accessLevel, isStatic: false);
            return new MethodDefinition<TClass, TReturn, T1, T2, T3>(methodInfo) { PreviousDefinition = (Definition)this };
        }
        public MethodDefinition<TClass, TReturn, T1, T2, T3, T4> Method<TReturn, T1, T2, T3, T4>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) }, accessLevel, isStatic: false);
            return new MethodDefinition<TClass, TReturn, T1, T2, T3, T4>(methodInfo) { PreviousDefinition = this };
        }
        public MethodDefinition<TClass, TReturn, T1, T2, T3, T4, T5> Method<TReturn, T1, T2, T3, T4, T5>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) }, accessLevel, isStatic: false);
            return new MethodDefinition<TClass, TReturn, T1, T2, T3, T4, T5>(methodInfo) { PreviousDefinition = this };
        }

        public StaticMethodDefinition<TReturn> StaticMethod<TReturn>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), accessLevel, isStatic: true);
            return new StaticMethodDefinition<TReturn>(methodInfo) { PreviousDefinition = this };
        }
        public StaticMethodDefinition<TReturn, T1> StaticMethod<TReturn, T1>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), new Type[] { typeof(T1) }, accessLevel, isStatic: true);
            return new StaticMethodDefinition<TReturn, T1>(methodInfo) { PreviousDefinition = this };
        }
        public StaticMethodDefinition<TReturn, T1, T2> StaticMethod<TReturn, T1, T2>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), new Type[] { typeof(T1), typeof(T2) }, accessLevel, isStatic: true);
            return new StaticMethodDefinition<TReturn, T1, T2>(methodInfo) { PreviousDefinition = this };
        }
        public StaticMethodDefinition<TReturn, T1, T2, T3> StaticMethod<TReturn, T1, T2, T3>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), new Type[] { typeof(T1), typeof(T2), typeof(T3) }, accessLevel, isStatic: true);
            return new StaticMethodDefinition<TReturn, T1, T2, T3>(methodInfo) { PreviousDefinition = this };
        }
        public StaticMethodDefinition<TReturn, T1, T2, T3, T4> StaticMethod<TReturn, T1, T2, T3, T4>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) }, accessLevel, isStatic: true);
            return new StaticMethodDefinition<TReturn, T1, T2, T3, T4>(methodInfo) { PreviousDefinition = this };
        }
        public StaticMethodDefinition<TReturn, T1, T2, T3, T4, T5> StaticMethod<TReturn, T1, T2, T3, T4, T5>(string methodName, AccessLevel? accessLevel = null)
        {
            MethodInfo methodInfo = StructureHelper.GetMethodInfo(Info.FieldType, methodName, typeof(TReturn), new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) }, accessLevel, isStatic: true);
            return new StaticMethodDefinition<TReturn, T1, T2, T3, T4, T5>(methodInfo) { PreviousDefinition = this };
        }

        //event
    }
}