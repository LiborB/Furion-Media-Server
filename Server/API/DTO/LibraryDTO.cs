﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public record LibraryDTO(int Id, string Name, bool CanRemove, string FolderPath);
}