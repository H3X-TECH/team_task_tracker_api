﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Domain.Entities
{
    public class UserCredential : BaseEntity
    {
        public string UserId { get; set; }
        public string PasswordHash { get; set; }
        //public string PasswordSalt { get; set; }
        public DateTime LastPasswordChangeDate { get; set; }

        //navigation property back to UserInfo
        public virtual UserInfo UserInfo { get; set; }
    }
}
