﻿using KhoaLuanCoreApp.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhoaLuanCoreApp.Data.Entities
{
    [Table("BlogTags")]
    public class BlogTag :DomainEntity<int>
    {
        public int BlogId { get; set; }
        public string TagId { get; set; }

        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }

    }
}
