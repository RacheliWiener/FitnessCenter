﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models;

public class BLTrining
{
    public string Name { get; set; } = null!;
    public string? PurposeOfTraining { get; set; }
    public byte[] imageBytes { get; set; }
    public string? Img { get; set; }
}
