﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LungCancerBayesNetwork
{
    public class BayesNode
    {
        //from bottom to top Layers[0] Parents -> Layers[1] their's children etc
        public List<List<int>> Layers { get; set; }
    }
}
