
using System; 

namespace Application
{
	
	public class BTS_app
	{
		public BTS_app()
		{
			//
			// TODO: Add constructor logic here
			//
		}

        [STAThread]
        static void Main() 
        {
            System.Windows.Forms.Application.Run(new MainForm());
        }
	}
}
