//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manager
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class List
    {
        public List()
        {
            this.Items = new ObservableCollection<Item>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string ListType { get; set; }
    
        public virtual ObservableCollection<Item> Items { get; set; }
    }
}
