using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Cricket.Tournament.RNCricketTournament
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCricketTournamentModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCricketTournamentModule"/>.
        /// </summary>
        internal RNCricketTournamentModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCricketTournament";
            }
        }
    }
}
