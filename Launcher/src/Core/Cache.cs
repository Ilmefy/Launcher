using Launcher.src.View.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.src.Core
{
    public static class Cache
    {
		private static ExpansionButton _currentlyActiveExpansionButton;

		public static ExpansionButton CurrentlyActiveExpansionButton
		{
			get { return _currentlyActiveExpansionButton; }
			set { Events.CurrentlyActiveExpansionButtonChanged(_currentlyActiveExpansionButton, value); _currentlyActiveExpansionButton = value;  }
		}


	}
}
