using KhoaLuanCoreApp.Data.Enums;
using KhoaLuanCoreApp.Data.Interfaces;
using KhoaLuanCoreApp.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KhoaLuanCoreApp.Data.Entities
{
    [Table("Blogs")]
    public class Blog : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData
    {
        // Constructer
        public Blog()
        {
        }
        //
        public Blog(string name, string image, string description, string content, bool? homeFlag,
           bool? hotFlag, int viewCount, string tags, Status status, string seoPageTitle, string seoAlias,
            string seoKeywords, string seoDescription)
        {
            Name = name;
            Image = image;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            ViewCount = viewCount;
            Tags = tags;
            Status = status;
            SeoAlias = seoAlias;
            SeoKeywords = seoKeywords;
            SeoDescription = seoDescription;
        }

        //
        public Blog(int id, string name, string image, string description, string content, bool? homeFlag,
           bool? hotFlag, int viewCount, string tags, Status status, string seoPageTitle, string seoAlias,
            string seoKeywords, string seoDescription)
        {
            Id = id;
            Name = name;
            Image = image;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            ViewCount = viewCount;
            Tags = tags;
            Status = status;
            SeoAlias = seoAlias;
            SeoKeywords = seoKeywords;
            SeoDescription = seoDescription;
        }

        //
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; } //Hiển thị ra home

        public bool? HotFlag { get; set; }

        public int ViewCount { get; set; }
        public string Tags { get; set; }
        public virtual ICollection<BlogTag> BlogTags { get; set; } // Dùng để sửa

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public Status Status { get; set; }

        [MaxLength(256)]
        public string SeoPageTitle { get; set; }

        [MaxLength(256)]
        public string SeoAlias { get; set; }

        [MaxLength(256)]
        public string SeoKeywords { get; set; }

        [MaxLength(256)]
        public string SeoDescription { get; set; }
    }
}