﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Models.EF;

namespace WhyNotSolution.Repository {
    public interface IUserRepository : IRepository<UserDTO,UserDTO> { }
}
