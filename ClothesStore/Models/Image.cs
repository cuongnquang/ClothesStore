//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClothesStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        public string ImageID { get; set; }
        public string ImageName { get; set; }
        public string MainImage { get; set; }
        public string UrlMainImg { get; set; }
        public string SecondaryImage1 { get; set; }
        public string UrlSecondaryImage1 { get; set; }
        public string SecondaryImage2 { get; set; }
        public string UrlSecondaryImage2 { get; set; }
        public string SecondaryImage3 { get; set; }
        public string UrlSecondaryImage3 { get; set; }
        public string ClothesID { get; set; }
        public string ColorID { get; set; }
        public int ImageOrder { get; set; }
        public bool IsHidden { get; set; }
    
        public virtual Cloth Cloth { get; set; }
        public virtual Color Color { get; set; }
    }
}
