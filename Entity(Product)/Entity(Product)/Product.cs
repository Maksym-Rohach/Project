//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Product_
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int IDPRoduct { get; set; }
        public string Name { get; set; }
        public Nullable<int> IDCategory { get; set; }
        public decimal Price { get; set; }
        public short Quantity { get; set; }
        public Nullable<int> IDProducer { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Producer Producer { get; set; }
    }
}
