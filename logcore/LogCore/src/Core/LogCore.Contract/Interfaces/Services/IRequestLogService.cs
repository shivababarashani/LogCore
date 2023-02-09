﻿using LogCore.Contract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Contract.Interfaces.Services
{
    public interface IRequestLogService
    {
        Task<bool> AddRequestLog(RequestLogRow request);
    }
}
