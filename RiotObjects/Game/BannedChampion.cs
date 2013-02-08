﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Game
{
    /// <summary>
    /// Class with banned champion information at specific ban turn.
    /// </summary>
    public class BannedChampion : RiotGamesObject
    {
        #region Constructors and Callbacks

        public BannedChampion(Callback callback)
        {
            this.callback = callback;
        }

        public BannedChampion(TypedObject result)
        {
            base.SetFields<BannedChampion>(this, result);
        }

        public delegate void Callback(BannedChampion result);
        private Callback callback;
        public override void DoCallback(TypedObject result)
        {
            base.SetFields<BannedChampion>(this, result);
            callback(this);
        }

        #endregion

        #region Member Properties

        /// <summary>
        /// Order of ban, pick turn
        /// </summary>
        [InternalName("pickTurn")]
        public int PickTurn { get; set; }

        /// <summary>
        /// Banned champion ID number.
        /// </summary>
        [InternalName("championId")]
        public int ChampionID { get; set; }

        /// <summary>
        /// Id of Team (100 = 1, 200 = 2)
        /// </summary>
        [InternalName("teamId")]
        public int TeamID { get; set; }

        #endregion
    }
}