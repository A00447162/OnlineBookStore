﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TheOnlineBookStore.Data.Base;

namespace TheOnlineBookStore.Models
{
    public class Publisher:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string PictureURL { get; set; }
        public string Name { get; set; }
        public string About { get; set; }


        public List<Book> Books { get; set; }
    }
}
