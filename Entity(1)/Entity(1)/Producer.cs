//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_1_
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producer
    {        
        public Producer()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int IDProducer { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}
