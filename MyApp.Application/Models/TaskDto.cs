﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Models
{
    public record TaskDto(Guid Id, string Title, DateTime CreatedAt);
}
