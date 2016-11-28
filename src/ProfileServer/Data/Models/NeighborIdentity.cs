﻿using ProfileServer.Utils;
using ProfileServerProtocol;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileServer.Data.Models
{
  /// <summary>
  /// Database representation of IoP Identity profile that is hosted in the node's neighborhood.
  /// </summary>
  public class NeighborIdentity : BaseIdentity
  {
    private static NLog.Logger log = NLog.LogManager.GetLogger("ProfileServer.Data.Models.NeighborIdentity");
  }
}
