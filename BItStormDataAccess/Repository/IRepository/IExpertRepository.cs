﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DataAccess.Repository.IRepository;

public interface IExpertRepository : IRepository<Expert>
{
    void Update(Expert obj);
}
