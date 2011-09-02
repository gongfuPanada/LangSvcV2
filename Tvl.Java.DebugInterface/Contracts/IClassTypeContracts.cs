﻿namespace Tvl.Java.DebugInterface.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IClassType))]
    internal abstract class IClassTypeContracts : IClassType
    {
        #region IClassType Members

        public ReadOnlyCollection<IInterfaceType> GetInterfaces(bool includeInherited)
        {
            Contract.Ensures(Contract.Result<ReadOnlyCollection<IInterfaceType>>() != null);
#if CONTRACTS_FORALL
            Contract.Ensures(Contract.ForAll(Contract.Result<ReadOnlyCollection<IInterfaceType>>(), type => type != null && this.GetVirtualMachine().Equals(type.GetVirtualMachine())));
#endif

            throw new NotImplementedException();
        }

        public IMethod GetConcreteMethod(string name, string signature)
        {
            Contract.Requires<ArgumentNullException>(name != null, "name");
            Contract.Requires<ArgumentNullException>(signature != null, "signature");
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(name));
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(signature));
            Contract.Ensures(Contract.Result<IMethod>() == null || this.GetVirtualMachine().Equals(Contract.Result<IMethod>().GetVirtualMachine()));

            throw new NotImplementedException();
        }

        public IValue InvokeMethod(IThreadReference thread, IMethod method, InvokeOptions options, params IValue[] arguments)
        {
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Requires<VirtualMachineMismatchException>(thread == null || this.GetVirtualMachine().Equals(thread.GetVirtualMachine()));
            Contract.Requires<VirtualMachineMismatchException>(method.GetVirtualMachine().Equals(this.GetVirtualMachine()));
#if CONTRACTS_FORALL
            Contract.Requires<VirtualMachineMismatchException>(arguments == null || Contract.ForAll(arguments, argument => this.GetVirtualMachine().Equals(argument.GetVirtualMachine())));
#endif
            Contract.Ensures(Contract.Result<IValue>() != null);
            Contract.Ensures(this.GetVirtualMachine().Equals(Contract.Result<IValue>().GetVirtualMachine()));

            throw new NotImplementedException();
        }

        public bool GetIsEnum()
        {
            throw new NotImplementedException();
        }

        public IObjectReference CreateInstance(IThreadReference thread, IMethod method, InvokeOptions options, params IValue[] arguments)
        {
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Requires<VirtualMachineMismatchException>(thread == null || this.GetVirtualMachine().Equals(thread.GetVirtualMachine()));
            Contract.Requires<VirtualMachineMismatchException>(method.GetVirtualMachine().Equals(this.GetVirtualMachine()));
#if CONTRACTS_FORALL
            Contract.Requires<VirtualMachineMismatchException>(arguments == null || Contract.ForAll(arguments, argument => this.GetVirtualMachine().Equals(argument.GetVirtualMachine())));
#endif
            Contract.Ensures(Contract.Result<IObjectReference>() != null);
            Contract.Ensures(this.GetVirtualMachine().Equals(Contract.Result<IObjectReference>().GetVirtualMachine()));

            throw new NotImplementedException();
        }

        public void SetValue(IField field, IValue value)
        {
            Contract.Requires<ArgumentNullException>(field != null, "field");
            Contract.Requires<ArgumentNullException>(value != null, "value");
            Contract.Requires<VirtualMachineMismatchException>(this.GetVirtualMachine().Equals(field.GetVirtualMachine()));
            Contract.Requires<VirtualMachineMismatchException>(this.GetVirtualMachine().Equals(value.GetVirtualMachine()));

            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IClassType> GetSubclasses()
        {
            Contract.Ensures(Contract.Result<ReadOnlyCollection<IClassType>>() != null);
#if CONTRACTS_FORALL
            Contract.Ensures(Contract.ForAll(Contract.Result<ReadOnlyCollection<IClassType>>(), type => type != null && this.GetVirtualMachine().Equals(type.GetVirtualMachine())));
#endif

            throw new NotImplementedException();
        }

        public IClassType GetSuperclass()
        {
            Contract.Ensures(Contract.Result<IClassType>() == null || this.GetVirtualMachine().Equals(Contract.Result<IClassType>().GetVirtualMachine()));

            throw new NotImplementedException();
        }

        #endregion

        #region IReferenceType Members

        public ReadOnlyCollection<IField> GetFields(bool includeInherited)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<ILocation> GetLineLocations()
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<ILocation> GetLineLocations(string stratum, string sourceName)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IMethod> GetMethods(bool includeInherited)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<string> GetAvailableStrata()
        {
            throw new NotImplementedException();
        }

        public IClassLoaderReference GetClassLoader()
        {
            throw new NotImplementedException();
        }

        public IClassObjectReference GetClassObject()
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<Types.ConstantPoolEntry> GetConstantPool()
        {
            throw new NotImplementedException();
        }

        public int GetConstantPoolCount()
        {
            throw new NotImplementedException();
        }

        public string GetDefaultStratum()
        {
            throw new NotImplementedException();
        }

        public bool GetFailedToInitialize()
        {
            throw new NotImplementedException();
        }

        public IField GetFieldByName(string fieldName)
        {
            throw new NotImplementedException();
        }

        public string GetGenericSignature()
        {
            throw new NotImplementedException();
        }

        public IValue GetValue(IField field)
        {
            throw new NotImplementedException();
        }

        public IDictionary<IField, IValue> GetValues(IEnumerable<IField> fields)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IObjectReference> GetInstances(long maxInstances)
        {
            throw new NotImplementedException();
        }

        public bool GetIsAbstract()
        {
            throw new NotImplementedException();
        }

        public bool GetIsFinal()
        {
            throw new NotImplementedException();
        }

        public bool GetIsInitialized()
        {
            throw new NotImplementedException();
        }

        public bool GetIsPrepared()
        {
            throw new NotImplementedException();
        }

        public bool GetIsStatic()
        {
            throw new NotImplementedException();
        }

        public bool GetIsVerified()
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<ILocation> GetLocationsOfLine(int lineNumber)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<ILocation> GetLocationsOfLine(string stratum, string sourceName, int lineNumber)
        {
            throw new NotImplementedException();
        }

        public int GetMajorVersion()
        {
            throw new NotImplementedException();
        }

        public int GetMinorVersion()
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IMethod> GetMethodsByName(string name)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IMethod> GetMethodsByName(string name, string signature)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IReferenceType> GetNestedTypes()
        {
            throw new NotImplementedException();
        }

        public string GetSourceDebugExtension()
        {
            throw new NotImplementedException();
        }

        public string GetSourceName()
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<string> GetSourceNames(string stratum)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<string> GetSourcePaths(string stratum)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IField> GetVisibleFields()
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IMethod> GetVisibleMethods()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IType Members

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public string GetSignature()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IMirror Members

        public IVirtualMachine GetVirtualMachine()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IAccessible Members

        public bool GetIsPackagePrivate()
        {
            throw new NotImplementedException();
        }

        public bool GetIsPrivate()
        {
            throw new NotImplementedException();
        }

        public bool GetIsProtected()
        {
            throw new NotImplementedException();
        }

        public bool GetIsPublic()
        {
            throw new NotImplementedException();
        }

        public AccessModifiers GetModifiers()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEquatable<IReferenceType> Members

        public bool Equals(IReferenceType other)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}