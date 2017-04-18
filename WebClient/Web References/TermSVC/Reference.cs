﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebClient.TermSVC {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TermServiceSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class TermService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateNewAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback WriteNewFileToStorageOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAccountInfoWithEmailOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFileDataOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TermService() {
            this.Url = global::WebClient.Properties.Settings.Default.WebClient_TermSVC_TermService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event LoginCompletedEventHandler LoginCompleted;
        
        /// <remarks/>
        public event CreateNewAccountCompletedEventHandler CreateNewAccountCompleted;
        
        /// <remarks/>
        public event WriteNewFileToStorageCompletedEventHandler WriteNewFileToStorageCompleted;
        
        /// <remarks/>
        public event UpdateFileCompletedEventHandler UpdateFileCompleted;
        
        /// <remarks/>
        public event DeleteFileCompletedEventHandler DeleteFileCompleted;
        
        /// <remarks/>
        public event GetAccountInfoWithEmailCompletedEventHandler GetAccountInfoWithEmailCompleted;
        
        /// <remarks/>
        public event GetFileDataCompletedEventHandler GetFileDataCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Login(string[] credentials, bool rememberMe, string verify) {
            object[] results = this.Invoke("Login", new object[] {
                        credentials,
                        rememberMe,
                        verify});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void LoginAsync(string[] credentials, bool rememberMe, string verify) {
            this.LoginAsync(credentials, rememberMe, verify, null);
        }
        
        /// <remarks/>
        public void LoginAsync(string[] credentials, bool rememberMe, string verify, object userState) {
            if ((this.LoginOperationCompleted == null)) {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        credentials,
                        rememberMe,
                        verify}, this.LoginOperationCompleted, userState);
        }
        
        private void OnLoginOperationCompleted(object arg) {
            if ((this.LoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CreateNewAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateNewAccount(object[] data, bool rememberMe, string verify) {
            object[] results = this.Invoke("CreateNewAccount", new object[] {
                        data,
                        rememberMe,
                        verify});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreateNewAccountAsync(object[] data, bool rememberMe, string verify) {
            this.CreateNewAccountAsync(data, rememberMe, verify, null);
        }
        
        /// <remarks/>
        public void CreateNewAccountAsync(object[] data, bool rememberMe, string verify, object userState) {
            if ((this.CreateNewAccountOperationCompleted == null)) {
                this.CreateNewAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateNewAccountOperationCompleted);
            }
            this.InvokeAsync("CreateNewAccount", new object[] {
                        data,
                        rememberMe,
                        verify}, this.CreateNewAccountOperationCompleted, userState);
        }
        
        private void OnCreateNewAccountOperationCompleted(object arg) {
            if ((this.CreateNewAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateNewAccountCompleted(this, new CreateNewAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WriteNewFileToStorage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int WriteNewFileToStorage(object[] data, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] filecontent, string accEmail, string verify) {
            object[] results = this.Invoke("WriteNewFileToStorage", new object[] {
                        data,
                        filecontent,
                        accEmail,
                        verify});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void WriteNewFileToStorageAsync(object[] data, byte[] filecontent, string accEmail, string verify) {
            this.WriteNewFileToStorageAsync(data, filecontent, accEmail, verify, null);
        }
        
        /// <remarks/>
        public void WriteNewFileToStorageAsync(object[] data, byte[] filecontent, string accEmail, string verify, object userState) {
            if ((this.WriteNewFileToStorageOperationCompleted == null)) {
                this.WriteNewFileToStorageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWriteNewFileToStorageOperationCompleted);
            }
            this.InvokeAsync("WriteNewFileToStorage", new object[] {
                        data,
                        filecontent,
                        accEmail,
                        verify}, this.WriteNewFileToStorageOperationCompleted, userState);
        }
        
        private void OnWriteNewFileToStorageOperationCompleted(object arg) {
            if ((this.WriteNewFileToStorageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WriteNewFileToStorageCompleted(this, new WriteNewFileToStorageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int UpdateFile(object[] data, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] filecontent, string accEmail, string verify) {
            object[] results = this.Invoke("UpdateFile", new object[] {
                        data,
                        filecontent,
                        accEmail,
                        verify});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateFileAsync(object[] data, byte[] filecontent, string accEmail, string verify) {
            this.UpdateFileAsync(data, filecontent, accEmail, verify, null);
        }
        
        /// <remarks/>
        public void UpdateFileAsync(object[] data, byte[] filecontent, string accEmail, string verify, object userState) {
            if ((this.UpdateFileOperationCompleted == null)) {
                this.UpdateFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateFileOperationCompleted);
            }
            this.InvokeAsync("UpdateFile", new object[] {
                        data,
                        filecontent,
                        accEmail,
                        verify}, this.UpdateFileOperationCompleted, userState);
        }
        
        private void OnUpdateFileOperationCompleted(object arg) {
            if ((this.UpdateFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateFileCompleted(this, new UpdateFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int DeleteFile(int fileID, int fileSize, string email) {
            object[] results = this.Invoke("DeleteFile", new object[] {
                        fileID,
                        fileSize,
                        email});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteFileAsync(int fileID, int fileSize, string email) {
            this.DeleteFileAsync(fileID, fileSize, email, null);
        }
        
        /// <remarks/>
        public void DeleteFileAsync(int fileID, int fileSize, string email, object userState) {
            if ((this.DeleteFileOperationCompleted == null)) {
                this.DeleteFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteFileOperationCompleted);
            }
            this.InvokeAsync("DeleteFile", new object[] {
                        fileID,
                        fileSize,
                        email}, this.DeleteFileOperationCompleted, userState);
        }
        
        private void OnDeleteFileOperationCompleted(object arg) {
            if ((this.DeleteFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteFileCompleted(this, new DeleteFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAccountInfoWithEmail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetAccountInfoWithEmail(string email) {
            object[] results = this.Invoke("GetAccountInfoWithEmail", new object[] {
                        email});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetAccountInfoWithEmailAsync(string email) {
            this.GetAccountInfoWithEmailAsync(email, null);
        }
        
        /// <remarks/>
        public void GetAccountInfoWithEmailAsync(string email, object userState) {
            if ((this.GetAccountInfoWithEmailOperationCompleted == null)) {
                this.GetAccountInfoWithEmailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAccountInfoWithEmailOperationCompleted);
            }
            this.InvokeAsync("GetAccountInfoWithEmail", new object[] {
                        email}, this.GetAccountInfoWithEmailOperationCompleted, userState);
        }
        
        private void OnGetAccountInfoWithEmailOperationCompleted(object arg) {
            if ((this.GetAccountInfoWithEmailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAccountInfoWithEmailCompleted(this, new GetAccountInfoWithEmailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetFileData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetFileData(string email) {
            object[] results = this.Invoke("GetFileData", new object[] {
                        email});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetFileDataAsync(string email) {
            this.GetFileDataAsync(email, null);
        }
        
        /// <remarks/>
        public void GetFileDataAsync(string email, object userState) {
            if ((this.GetFileDataOperationCompleted == null)) {
                this.GetFileDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFileDataOperationCompleted);
            }
            this.InvokeAsync("GetFileData", new object[] {
                        email}, this.GetFileDataOperationCompleted, userState);
        }
        
        private void OnGetFileDataOperationCompleted(object arg) {
            if ((this.GetFileDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFileDataCompleted(this, new GetFileDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void CreateNewAccountCompletedEventHandler(object sender, CreateNewAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateNewAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateNewAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void WriteNewFileToStorageCompletedEventHandler(object sender, WriteNewFileToStorageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WriteNewFileToStorageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WriteNewFileToStorageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void UpdateFileCompletedEventHandler(object sender, UpdateFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void DeleteFileCompletedEventHandler(object sender, DeleteFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetAccountInfoWithEmailCompletedEventHandler(object sender, GetAccountInfoWithEmailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAccountInfoWithEmailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAccountInfoWithEmailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetFileDataCompletedEventHandler(object sender, GetFileDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFileDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFileDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591