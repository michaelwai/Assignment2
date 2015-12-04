

using System;
using BackEnd;

namespace GUI.Controls
{
	/// <summary>
	/// This is interface to all possible views in bts
	/// </summary>
    public interface IView
    {
        /// <summary>
        /// initialize all internal data needs for view
        /// called before show view (control)
        /// </summary>
        void Initialize(IBugTrackDB db,string login, string password,System.Windows.Forms.MainMenu ApplicationMenu);

        /// <summary>
        /// deinitialize view (control)
        /// then control will disposed
        /// </summary>
        void DeInitialize();
    }
}
