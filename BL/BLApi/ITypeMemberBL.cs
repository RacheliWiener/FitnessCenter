﻿using BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLApi
{
    public interface ITypeMemberBL
    {
        public List<BLtypeMember> GettypeMembers();
    }
}
