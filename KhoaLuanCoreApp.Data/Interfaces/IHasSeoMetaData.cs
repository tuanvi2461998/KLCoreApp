using System;
using System.Collections.Generic;
using System.Text;

namespace KhoaLuanCoreApp.Data.Interfaces
{
    public  interface IHasSeoMetaData
    {
        string SeoPageTitle { set; get; }   // Tiêu đề trang Seo
        string SeoAlias { set; get; }  
        string SeoKeywords { set; get; }
        string SeoDescription { set; get; }
    }
}
