﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Recon.BoundingVolumes {

    public interface IConvexPolyhedron {

        IEnumerable<Vector3> Edges();
        IEnumerable<Vector3> Vertices();
    }
}
