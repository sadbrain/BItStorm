﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public class Role
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
