using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccpacCOMAPI;
using AccpacSessionManager;
using System.Windows.Forms;


namespace COMAPI_Connection
{
    public static class Connection
    {
        public static AccpacSession CurrentSession;

        public static Boolean ConnectToAccpac()
        {
            try
            {
                int lSignonID = 0;
                AccpacSessionManager.AccpacSessionMgr accpacSessionMgr = new AccpacSessionManager.AccpacSessionMgr();

                accpacSessionMgr.AppID = "AS";
                accpacSessionMgr.ProgramName = "AS0001";
                accpacSessionMgr.ServerName = "";
                accpacSessionMgr.AppVersion = "68";
                accpacSessionMgr.CreateSession("", ref lSignonID, out CurrentSession);
                

                if (CurrentSession.IsOpened)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Accpac Connection Is Closed");
                    return false;
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                //DO SOMETHING
            }
        }
    }


}
