﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sklep.WebApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderDTO", Namespace="http://schemas.datacontract.org/2004/07/Sklep.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class OrderDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Sklep.WebApp.ServiceReference1.CartDTO CartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CartIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime OrderDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Sklep.WebApp.ServiceReference1.UserDTO UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Sklep.WebApp.ServiceReference1.CartDTO Cart {
            get {
                return this.CartField;
            }
            set {
                if ((object.ReferenceEquals(this.CartField, value) != true)) {
                    this.CartField = value;
                    this.RaisePropertyChanged("Cart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CartID {
            get {
                return this.CartIDField;
            }
            set {
                if ((this.CartIDField.Equals(value) != true)) {
                    this.CartIDField = value;
                    this.RaisePropertyChanged("CartID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime OrderDate {
            get {
                return this.OrderDateField;
            }
            set {
                if ((this.OrderDateField.Equals(value) != true)) {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderID {
            get {
                return this.OrderIDField;
            }
            set {
                if ((this.OrderIDField.Equals(value) != true)) {
                    this.OrderIDField = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Sklep.WebApp.ServiceReference1.UserDTO User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CartDTO", Namespace="http://schemas.datacontract.org/2004/07/Sklep.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class CartDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CartIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Sklep.WebApp.ServiceReference1.CartItemDTO[] CartItemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrizeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CartID {
            get {
                return this.CartIDField;
            }
            set {
                if ((this.CartIDField.Equals(value) != true)) {
                    this.CartIDField = value;
                    this.RaisePropertyChanged("CartID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Sklep.WebApp.ServiceReference1.CartItemDTO[] CartItems {
            get {
                return this.CartItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.CartItemsField, value) != true)) {
                    this.CartItemsField = value;
                    this.RaisePropertyChanged("CartItems");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Prize {
            get {
                return this.PrizeField;
            }
            set {
                if ((this.PrizeField.Equals(value) != true)) {
                    this.PrizeField = value;
                    this.RaisePropertyChanged("Prize");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDTO", Namespace="http://schemas.datacontract.org/2004/07/Sklep.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class UserDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Sklep.WebApp.ServiceReference1.AddressDTO AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AddressIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RolesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Sklep.WebApp.ServiceReference1.AddressDTO Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AddressID {
            get {
                return this.AddressIDField;
            }
            set {
                if ((this.AddressIDField.Equals(value) != true)) {
                    this.AddressIDField = value;
                    this.RaisePropertyChanged("AddressID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pasword {
            get {
                return this.PaswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PaswordField, value) != true)) {
                    this.PaswordField = value;
                    this.RaisePropertyChanged("Pasword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Roles {
            get {
                return this.RolesField;
            }
            set {
                if ((object.ReferenceEquals(this.RolesField, value) != true)) {
                    this.RolesField = value;
                    this.RaisePropertyChanged("Roles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CartItemDTO", Namespace="http://schemas.datacontract.org/2004/07/Sklep.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class CartItemDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CartItemIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Sklep.WebApp.ServiceReference1.ItemDTO ItemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuanityField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CartItemID {
            get {
                return this.CartItemIDField;
            }
            set {
                if ((this.CartItemIDField.Equals(value) != true)) {
                    this.CartItemIDField = value;
                    this.RaisePropertyChanged("CartItemID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Sklep.WebApp.ServiceReference1.ItemDTO Item {
            get {
                return this.ItemField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemField, value) != true)) {
                    this.ItemField = value;
                    this.RaisePropertyChanged("Item");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemID {
            get {
                return this.ItemIDField;
            }
            set {
                if ((this.ItemIDField.Equals(value) != true)) {
                    this.ItemIDField = value;
                    this.RaisePropertyChanged("ItemID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Prize {
            get {
                return this.PrizeField;
            }
            set {
                if ((this.PrizeField.Equals(value) != true)) {
                    this.PrizeField = value;
                    this.RaisePropertyChanged("Prize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quanity {
            get {
                return this.QuanityField;
            }
            set {
                if ((this.QuanityField.Equals(value) != true)) {
                    this.QuanityField = value;
                    this.RaisePropertyChanged("Quanity");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemDTO", Namespace="http://schemas.datacontract.org/2004/07/Sklep.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class ItemDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuanityField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemID {
            get {
                return this.ItemIDField;
            }
            set {
                if ((this.ItemIDField.Equals(value) != true)) {
                    this.ItemIDField = value;
                    this.RaisePropertyChanged("ItemID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Prize {
            get {
                return this.PrizeField;
            }
            set {
                if ((this.PrizeField.Equals(value) != true)) {
                    this.PrizeField = value;
                    this.RaisePropertyChanged("Prize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quanity {
            get {
                return this.QuanityField;
            }
            set {
                if ((this.QuanityField.Equals(value) != true)) {
                    this.QuanityField = value;
                    this.RaisePropertyChanged("Quanity");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AddressDTO", Namespace="http://schemas.datacontract.org/2004/07/Sklep.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class AddressDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AddressIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AddressID {
            get {
                return this.AddressIDField;
            }
            set {
                if ((this.AddressIDField.Equals(value) != true)) {
                    this.AddressIDField = value;
                    this.RaisePropertyChanged("AddressID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderCheck", Namespace="http://schemas.datacontract.org/2004/07/Sklep.Service.DTO")]
    [System.SerializableAttribute()]
    public partial class OrderCheck : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CartIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CartID {
            get {
                return this.CartIDField;
            }
            set {
                if ((this.CartIDField.Equals(value) != true)) {
                    this.CartIDField = value;
                    this.RaisePropertyChanged("CartID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IOrderService")]
    public interface IOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/getAll", ReplyAction="http://tempuri.org/IOrderService/getAllResponse")]
        Sklep.WebApp.ServiceReference1.OrderDTO[] getAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/getAll", ReplyAction="http://tempuri.org/IOrderService/getAllResponse")]
        System.Threading.Tasks.Task<Sklep.WebApp.ServiceReference1.OrderDTO[]> getAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/get", ReplyAction="http://tempuri.org/IOrderService/getResponse")]
        Sklep.WebApp.ServiceReference1.OrderDTO get(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/get", ReplyAction="http://tempuri.org/IOrderService/getResponse")]
        System.Threading.Tasks.Task<Sklep.WebApp.ServiceReference1.OrderDTO> getAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/add", ReplyAction="http://tempuri.org/IOrderService/addResponse")]
        void add(Sklep.WebApp.ServiceReference1.OrderCheck order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/add", ReplyAction="http://tempuri.org/IOrderService/addResponse")]
        System.Threading.Tasks.Task addAsync(Sklep.WebApp.ServiceReference1.OrderCheck order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/update", ReplyAction="http://tempuri.org/IOrderService/updateResponse")]
        void update(Sklep.WebApp.ServiceReference1.OrderDTO order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/update", ReplyAction="http://tempuri.org/IOrderService/updateResponse")]
        System.Threading.Tasks.Task updateAsync(Sklep.WebApp.ServiceReference1.OrderDTO order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/delete", ReplyAction="http://tempuri.org/IOrderService/deleteResponse")]
        void delete(Sklep.WebApp.ServiceReference1.OrderDTO order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/delete", ReplyAction="http://tempuri.org/IOrderService/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(Sklep.WebApp.ServiceReference1.OrderDTO order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderServiceChannel : Sklep.WebApp.ServiceReference1.IOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<Sklep.WebApp.ServiceReference1.IOrderService>, Sklep.WebApp.ServiceReference1.IOrderService {
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Sklep.WebApp.ServiceReference1.OrderDTO[] getAll() {
            return base.Channel.getAll();
        }
        
        public System.Threading.Tasks.Task<Sklep.WebApp.ServiceReference1.OrderDTO[]> getAllAsync() {
            return base.Channel.getAllAsync();
        }
        
        public Sklep.WebApp.ServiceReference1.OrderDTO get(string id) {
            return base.Channel.get(id);
        }
        
        public System.Threading.Tasks.Task<Sklep.WebApp.ServiceReference1.OrderDTO> getAsync(string id) {
            return base.Channel.getAsync(id);
        }
        
        public void add(Sklep.WebApp.ServiceReference1.OrderCheck order) {
            base.Channel.add(order);
        }
        
        public System.Threading.Tasks.Task addAsync(Sklep.WebApp.ServiceReference1.OrderCheck order) {
            return base.Channel.addAsync(order);
        }
        
        public void update(Sklep.WebApp.ServiceReference1.OrderDTO order) {
            base.Channel.update(order);
        }
        
        public System.Threading.Tasks.Task updateAsync(Sklep.WebApp.ServiceReference1.OrderDTO order) {
            return base.Channel.updateAsync(order);
        }
        
        public void delete(Sklep.WebApp.ServiceReference1.OrderDTO order) {
            base.Channel.delete(order);
        }
        
        public System.Threading.Tasks.Task deleteAsync(Sklep.WebApp.ServiceReference1.OrderDTO order) {
            return base.Channel.deleteAsync(order);
        }
    }
}
