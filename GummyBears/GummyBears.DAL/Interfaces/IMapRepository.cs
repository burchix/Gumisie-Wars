﻿using GummyBears.DTO.Models;
using GummyBears.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GummyBears.DAL.Interfaces
{
    public interface IMapRepository: IBaseRepository<MapDB, Map>
    {
    }
}