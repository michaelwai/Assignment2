

using System;

namespace BTS_APP
{
	
            
        

        public void UpdateStatus()
        {
            itemItem_Disconnect.Enabled=IsLoggedIn;
            itemItem_File_ConnectTo.Enabled=!IsLoggedIn;
            if (IsLoggedIn)
            {
                this.Text="Connected - The Bug Tracking System";
                statusBarPanel_user.Text=item.ToString();
                statusBarPanel_server.Text=theServer;
            }
            else
            {
                this.Text="Not Connected - The Bug Tracking System";
                statusBarPanel_user.Text="";
                statusBarPanel_server.Text="";
            }
        }

	}
}
